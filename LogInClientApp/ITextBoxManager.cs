using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInClientApp
{
    public interface ITextBoxManager
    {

        void HideSuggestion(TextBox textBox, ref bool visibilityFlag);
        void ShowSuggestion(TextBox textBox, ref bool visibilityFlag, string suggestion);

    }
}
