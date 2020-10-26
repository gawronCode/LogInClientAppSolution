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
        public MenuForm()
        {
            InitializeComponent();
        }

        private void LogInFormBtn_Click(object sender, EventArgs e)
        {
            var logInForm = new LogInForm();
            logInForm.StartPosition = FormStartPosition.CenterScreen;
            logInForm.FormClosing += delegate { this.Close(); };
            logInForm.Show();
            this.Hide();
        }
    }
}
