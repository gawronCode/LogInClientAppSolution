using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInClientApp
{
    class TextBoxManager
    {

        public void HideSuggestion(TextBox textBox, ref bool visibilityFlag)
        {
            if (!visibilityFlag) return;

            textBox.ForeColor = SystemColors.WindowText;
            textBox.Text = "";
            visibilityFlag = false;
        }

        public void ShowSuggestion(TextBox textBox, ref bool visibilityFlag, string suggestion)
        {
            if (!(!visibilityFlag && textBox.Text.Length == 0)) return;

            textBox.ForeColor = SystemColors.ControlDark;
            textBox.Text = suggestion;
            visibilityFlag = true;
        }
        
    }
}
