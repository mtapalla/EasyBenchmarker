namespace EasyBenchmarker
{
    partial class MainGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.VisaAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StateFileLocation = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.measTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.Iterations = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoadStateFile = new System.Windows.Forms.CheckBox();
            this.ToBenchmark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isAscii8 = new System.Windows.Forms.ToolStripMenuItem();
            this.isReal32 = new System.Windows.Forms.ToolStripMenuItem();
            this.disableDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowReturnData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VISA Address";
            // 
            // VisaAddress
            // 
            this.VisaAddress.Location = new System.Drawing.Point(127, 34);
            this.VisaAddress.Name = "VisaAddress";
            this.VisaAddress.Size = new System.Drawing.Size(332, 20);
            this.VisaAddress.TabIndex = 0;
            this.VisaAddress.Text = "MXA_ADDRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "State File Location";
            // 
            // StateFileLocation
            // 
            this.StateFileLocation.Enabled = false;
            this.StateFileLocation.Location = new System.Drawing.Point(127, 63);
            this.StateFileLocation.Name = "StateFileLocation";
            this.StateFileLocation.Size = new System.Drawing.Size(311, 20);
            this.StateFileLocation.TabIndex = 0;
            this.StateFileLocation.TabStop = false;
            this.StateFileLocation.Text = "C:\\Documents and Settings\\Instrument\\Desktop\\State_0000.state";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(348, 109);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(111, 31);
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // measTime
            // 
            this.measTime.Location = new System.Drawing.Point(268, 406);
            this.measTime.Name = "measTime";
            this.measTime.ReadOnly = true;
            this.measTime.Size = new System.Drawing.Size(191, 20);
            this.measTime.TabIndex = 0;
            this.measTime.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(145, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Measurement Time";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(20, 146);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(442, 254);
            this.Output.TabIndex = 0;
            this.Output.TabStop = false;
            // 
            // Iterations
            // 
            this.Iterations.Location = new System.Drawing.Point(127, 89);
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(65, 20);
            this.Iterations.TabIndex = 1;
            this.Iterations.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Benchmark Iterations";
            // 
            // LoadStateFile
            // 
            this.LoadStateFile.AutoSize = true;
            this.LoadStateFile.Location = new System.Drawing.Point(444, 65);
            this.LoadStateFile.Name = "LoadStateFile";
            this.LoadStateFile.Size = new System.Drawing.Size(15, 14);
            this.LoadStateFile.TabIndex = 0;
            this.LoadStateFile.TabStop = false;
            this.LoadStateFile.UseVisualStyleBackColor = true;
            this.LoadStateFile.CheckedChanged += new System.EventHandler(this.LoadStateFile_CheckedChanged);
            // 
            // ToBenchmark
            // 
            this.ToBenchmark.Location = new System.Drawing.Point(127, 115);
            this.ToBenchmark.Name = "ToBenchmark";
            this.ToBenchmark.Size = new System.Drawing.Size(215, 20);
            this.ToBenchmark.TabIndex = 2;
            this.ToBenchmark.Text = "INIT:IMM;*OPC?";
            this.ToBenchmark.TextChanged += new System.EventHandler(this.ToBenchmark_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SCPI to Benchmark";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // instrumentToolStripMenuItem
            // 
            this.instrumentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataTypeToolStripMenuItem,
            this.disableDisplayToolStripMenuItem,
            this.ShowReturnData});
            this.instrumentToolStripMenuItem.Name = "instrumentToolStripMenuItem";
            this.instrumentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instrumentToolStripMenuItem.Text = "&Instrument";
            // 
            // dataTypeToolStripMenuItem
            // 
            this.dataTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isAscii8,
            this.isReal32});
            this.dataTypeToolStripMenuItem.Name = "dataTypeToolStripMenuItem";
            this.dataTypeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.dataTypeToolStripMenuItem.Text = "D&ata Type";
            // 
            // isAscii8
            // 
            this.isAscii8.Checked = true;
            this.isAscii8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isAscii8.Name = "isAscii8";
            this.isAscii8.Size = new System.Drawing.Size(116, 22);
            this.isAscii8.Text = "&ASCII,8";
            // 
            // isReal32
            // 
            this.isReal32.Name = "isReal32";
            this.isReal32.Size = new System.Drawing.Size(116, 22);
            this.isReal32.Text = "&REAL,32";
            // 
            // disableDisplayToolStripMenuItem
            // 
            this.disableDisplayToolStripMenuItem.Checked = true;
            this.disableDisplayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disableDisplayToolStripMenuItem.Name = "disableDisplayToolStripMenuItem";
            this.disableDisplayToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.disableDisplayToolStripMenuItem.Text = "&Disable Display";
            this.disableDisplayToolStripMenuItem.Click += new System.EventHandler(this.disableDisplayToolStripMenuItem_Click);
            // 
            // ShowReturnData
            // 
            this.ShowReturnData.Name = "ShowReturnData";
            this.ShowReturnData.Size = new System.Drawing.Size(168, 22);
            this.ShowReturnData.Text = "&Show Return Data";
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(474, 437);
            this.Controls.Add(this.LoadStateFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.measTime);
            this.Controls.Add(this.ToBenchmark);
            this.Controls.Add(this.Iterations);
            this.Controls.Add(this.StateFileLocation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VisaAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainGui";
            this.Text = "Easy Benchmarker v0.2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VisaAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StateFileLocation;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox measTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TextBox Iterations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox LoadStateFile;
        private System.Windows.Forms.TextBox ToBenchmark;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isAscii8;
        private System.Windows.Forms.ToolStripMenuItem isReal32;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowReturnData;
    }
}

