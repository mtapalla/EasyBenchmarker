using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

using SpeedSquadLib.SignalAnalyzers;
using SpeedSquadLib;
using System.ComponentModel;

namespace EasyBenchmarker
{
    public partial class MainGui : Form
    {
        public MainGui()
        {
            InitializeComponent();
        }

        #region GUI Methods
        private void RunButton_Click(object sender, EventArgs e)
        {
            var ActiveControls = new Control[] { RunButton, ToBenchmark, LoadStateFile, Iterations, VisaAddress };
            var ActiveMenus = new ToolStripMenuItem[] { settingsToolStripMenuItem };

            var worker = new BackgroundWorker();
            worker.DoWork += (s, args) => RunBenchmark();
            worker.RunWorkerCompleted += (s, arg) =>
            {
                foreach(var ActiveControl in ActiveControls)
                    ActiveControl.Enabled = !ActiveControl.Enabled;
                foreach (var ActiveMenu in ActiveMenus)
                    ActiveMenu.Enabled = !ActiveMenu.Enabled;
            };
            worker.RunWorkerAsync();

            // Update GUI
            foreach (Control ActiveControl in ActiveControls)
                ActiveControl.Enabled = false;
            foreach (var ActiveMenu in ActiveMenus)
                ActiveMenu.Enabled = false;

            Output.Clear();
        }

        private void ToBenchmark_TextChanged(object sender, EventArgs e)
        {
            if (ShowReturnData.Enabled == false && ToBenchmark.Text.Contains("?"))
                ShowReturnData.Enabled = true;
            else if (ShowReturnData.Enabled == true && !ToBenchmark.Text.Contains("?"))
                ShowReturnData.Enabled = false;
        }
        private void LoadStateFile_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadStateFile.Checked)
                StateFileLocation.Enabled = true;
            else
                StateFileLocation.Enabled = false;
        }
        #endregion

        private void RunBenchmark()
        {
            int iterations = int.Parse(Iterations.Text);

            var SA = new PXA();

            if (!SetupInstrument(SA))
                return;
            
            SA.Timeout = 20000;

            // Change to REAL,32 for faster data transfer speeds
            if (isAscii8.Checked)
            {
                SA.DataFormat = XSA.DataFormatChoices.ASCII;
                Print("> FORM:DATA ASCII");
            }
            else if (isReal32.Checked)
            {
                SA.DataFormat = XSA.DataFormatChoices.REAL_32;
                Print("> FORM:DATA REAL,32");
            }
            SA.WaitForOperationComplete();

            Print("Benchmarking: " + ToBenchmark.Text);
            var stopwatch = new Stopwatch();
            double[] timeStamps = new double[iterations];

            if (disableDisplayToolStripMenuItem.Checked)
                SA.DisplayEnabled = false;

            for (int i = 0; i < iterations; i++)
            {
                dynamic rawData = null;
                stopwatch.Restart();

                foreach(String scpi in ToBenchmark.Text.Split(';'))
                {
                    SA.ScpiCommand(scpi);

                    if (scpi.Contains("?"))
                    {
                        try
                        {
                            rawData = SA.ReadBlock();
                        }
                        catch
                        {
                            Print("\r\n*Error: Could not read data");
                            SA.DisplayEnabled = true;
                            return;
                        }
                    }                    
                }

                stopwatch.Stop();

                timeStamps[i] = stopwatch.ElapsedMilliseconds;
                Print(string.Format("  Iteration {0}:\t{1:0.00} ms", i + 1, timeStamps[i]));

                // Print out last iteration's return data, if requested
                if (i == iterations - 1 && ShowReturnData.Checked)
                {
                    if (rawData.GetType().IsArray)
                    {
                        string data = "";
                        foreach (var f in rawData)
                        {
                            data += f + ",";
                        }
                        data.TrimEnd(',');
                        Print(String.Format("\r\n{0}\r\n", data));
                    }
                    else
                    {
                        Print(String.Format("\r\n{0}\r\n", rawData));
                    }
                }
            }
            SA.DisplayEnabled = true;

            var AverageTime = MathUtil.Average(timeStamps);
            Print(String.Format("Average time: {0:0.00} ms", AverageTime));
            ThreadSafeHelper.SetText(measTime, String.Format("{0:0.00} ms", AverageTime));

            Print("> DISP:ENAB 1");
            SA.DisplayEnabled = true;
        }
        private bool SetupInstrument(XSA xsa)
        {
            Print("Connecting to: " + VisaAddress.Text);

            try
            {
                xsa.Connect(VisaAddress.Text);
            }
            catch (Exception e)
            {
                Print(e.Message);
                return false;
            }

            xsa.DataFormat = XSA.DataFormatChoices.ASCII;
            xsa.ScpiCommand("*IDN?");
            Print("Connected to: " + xsa.ReadString());
            xsa.Timeout = 5000;

            Print("> *CLS");
            xsa.ClearErrors();

            if (LoadStateFile.Checked)
            {
                string fileName = StateFileLocation.Text.Substring(StateFileLocation.Text.LastIndexOf('\\') + 1);
                Print("Loading '" + fileName + "'...");
                xsa.ScpiCommand("MMEM:LOAD:STAT '" + StateFileLocation.Text + "'");
                xsa.WaitForOperationComplete();

                xsa.ScpiCommand("SYST:ERR:NEXT?");
                var err = xsa.ReadString();
                if (err.StartsWith("-256"))
                {
                    Print("\r\n * State file does not exist: " + StateFileLocation.Text);
                    return false;
                }
                if (err.StartsWith("-257"))
                {
                    Print("\r\n * File name error, allowable extension is '.state'");
                    return false;
                }
            }

            return true;
        }

        private void Print(string message)
        {
            ThreadSafeHelper.AppendText(Output, message);
        }

        private void disableDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disableDisplayToolStripMenuItem.Checked = !disableDisplayToolStripMenuItem.Checked;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter || keyData == Keys.Space) && RunButton.Enabled != false)
            {
                RunButton_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}