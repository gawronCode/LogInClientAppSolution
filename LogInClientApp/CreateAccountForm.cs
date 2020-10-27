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
    public partial class CreateAccountForm : Form
    {

        private readonly ITextBoxManager _textBoxManager;

        private bool _nickTextBoxSuggestionOn = true;
        private bool _passCodeTextBoxSuggestionOn = true;
        private bool _repeatPassCodeTextBoxSuggestionOn = true;
        private bool _emailAddressTextBoxSuggestionOn = true;

        public CreateAccountForm(ITextBoxManager textBoxManager)
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

        private void NickTextBox_Click(object sender, EventArgs e)
        {
            _textBoxManager.HideSuggestion(this.NickTextBox, ref _nickTextBoxSuggestionOn);
        }

        private void NickTextBox_Leave(object sender, EventArgs e)
        {
            _textBoxManager.ShowSuggestion(this.NickTextBox, ref _nickTextBoxSuggestionOn, "Nick");
        }

        private void PassCodeTextBox_Click(object sender, EventArgs e)
        {
            _textBoxManager.HideSuggestion(this.PassCodeTextBox, ref _passCodeTextBoxSuggestionOn);
            this.PassCodeTextBox.UseSystemPasswordChar = true;
        }

        private void PassCodeTextBox_Leave(object sender, EventArgs e)
        {
            _textBoxManager.ShowSuggestion(this.PassCodeTextBox, ref _passCodeTextBoxSuggestionOn, "PassCode");
            if (_passCodeTextBoxSuggestionOn) this.PassCodeTextBox.UseSystemPasswordChar = false;
        }

        private void RepeatPassCodeTextBox_Click(object sender, EventArgs e)
        {
            _textBoxManager.HideSuggestion(this.RepeatPassCodeTextBox, ref _repeatPassCodeTextBoxSuggestionOn);
            this.RepeatPassCodeTextBox.UseSystemPasswordChar = true;
        }

        private void RepeatPassCodeTextBox_Leave(object sender, EventArgs e)
        {
            _textBoxManager.ShowSuggestion(this.RepeatPassCodeTextBox, ref _repeatPassCodeTextBoxSuggestionOn, "Repeat PassCode");
            if (_repeatPassCodeTextBoxSuggestionOn) this.RepeatPassCodeTextBox.UseSystemPasswordChar = false;
        }

        private void EmailAddressTextBox_Click(object sender, EventArgs e)
        {
            _textBoxManager.HideSuggestion(this.EmailAddressTextBox, ref _emailAddressTextBoxSuggestionOn);
        }

        private void EmailAddressTextBox_Leave(object sender, EventArgs e)
        {
            _textBoxManager.ShowSuggestion(this.EmailAddressTextBox, ref _emailAddressTextBoxSuggestionOn, "Email Address");
        }

        private void EmailAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
