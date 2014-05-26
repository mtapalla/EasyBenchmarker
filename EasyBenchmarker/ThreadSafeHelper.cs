using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyBenchmarker
{
    delegate void SetTextDelegate(Control control, String text);
    delegate void UpdateTextDelegate(Control control, String text);
    delegate void ControlEnabledDelegate(Control control, bool state);

    class ThreadSafeHelper
    {
        public static void SetText(Control control, String text)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetTextDelegate(SetText), new object[] { control, text });
            }
            else
            {
                control.Text = text;
            }
        }
        public static void AppendText(Control control, String text)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetTextDelegate(AppendText), new object[] { control, text });
            }
            else
            {
                if (control is TextBox)
                    ((TextBox)control).AppendText("\r\n" + text);
                else
                    control.Text += "\r\n" + text;
            }
        }

        public static void ControlEnabled(Control control, bool state)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new ControlEnabledDelegate(ControlEnabled), new object[] { control, state });
            }
            else
            {
                control.Enabled = state;
            }
        }

    }
}
