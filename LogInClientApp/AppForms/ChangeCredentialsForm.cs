using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInClientApp
{
    public partial class ChangeCredentialsForm : Form
    {
        private readonly ITextBoxManager _textBoxManager;

        public ChangeCredentialsForm(ITextBoxManager textBoxManager)
        {
            InitializeComponent();
            _textBoxManager = textBoxManager;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var menuForm = new MenuForm(_textBoxManager);
            menuForm.StartPosition = FormStartPosition.CenterScreen;
            menuForm.FormClosing += delegate { this.Close(); };
            menuForm.Show();
            this.Hide();
        }

        private void PassCodeFormBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
