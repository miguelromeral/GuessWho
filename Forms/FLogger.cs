using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace Forms
{
    class FLogger : ILogger
    {
        private TextBox textBox;

        public FLogger(TextBox tb)
        {
            textBox = tb;
        }

        public override void WriteToLog(string text)
        {
            if (textBox != null)
            {
                textBox.AppendText(text + Environment.NewLine);

                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;
                textBox.ScrollToCaret();
            }
        }
    }
}
