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
    public partial class MenuForm : Form
    {
        private readonly ITextBoxManager _textBoxManager;

        public MenuForm(ITextBoxManager textBoxManager)
        {
            InitializeComponent();
            _textBoxManager = textBoxManager;
        }

        private void LogInFormBtn_Click(object sender, EventArgs e)
        {
            var logInForm = new LogInForm(_textBoxManager);
            logInForm.StartPosition = FormStartPosition.CenterScreen;
            logInForm.FormClosing += delegate { this.Close(); };
            logInForm.Show();
            this.Hide();
        }

        private void ChangeCredentialsFormBtn_Click(object sender, EventArgs e)
        {
            var changeCredentialsForm = new ChangeCredentialsForm(_textBoxManager);
            changeCredentialsForm.StartPosition = FormStartPosition.CenterScreen;
            changeCredentialsForm.FormClosing += delegate { this.Close(); };
            changeCredentialsForm.Show();
            this.Hide();
        }

        private void CreateAccountFormBtn_Click(object sender, EventArgs e)
        {
            var createAccountForm = new CreateAccountForm(_textBoxManager);
            createAccountForm.StartPosition = FormStartPosition.CenterScreen;
            createAccountForm.FormClosing += delegate { this.Close(); };
            createAccountForm.Show();
            this.Hide();
        }
    }
}
