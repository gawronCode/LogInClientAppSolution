﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogInClientApp.Data;
using LogInClientApp.Models;

namespace LogInClientApp
{
    public partial class LogInForm : Form
    {

        private readonly ITextBoxManager _textBoxManager;
        private readonly ApiRequest _apiRequest = new ApiRequest();

        private bool _nickTextBoxSuggestionOn = true;
        private bool _passCodeTextBoxSuggestionOn = true;

        public LogInForm(ITextBoxManager textBoxManager)
        {
            InitializeComponent();
            _textBoxManager = textBoxManager;
            this.ActiveControl = this.LogInBtn;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

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
            _textBoxManager.HideSuggestion(this.NickTextBox, ref this._nickTextBoxSuggestionOn);
        }

        private void NickTextBox_Leave(object sender, EventArgs e)
        {
            _textBoxManager.ShowSuggestion(this.NickTextBox, ref this._nickTextBoxSuggestionOn, "Nick");
        }

        private void PassCodeTextBox_Click(object sender, EventArgs e)
        {
            _textBoxManager.HideSuggestion(this.PassCodeTextBox, ref this._passCodeTextBoxSuggestionOn);
            this.PassCodeTextBox.UseSystemPasswordChar = true;
        }

        private void PassCodeTextBox_Leave(object sender, EventArgs e)
        {
            _textBoxManager.ShowSuggestion(this.PassCodeTextBox, ref this._passCodeTextBoxSuggestionOn, "PassCode");
            if (_passCodeTextBoxSuggestionOn) this.PassCodeTextBox.UseSystemPasswordChar = false;
        }
        
        private async void LogInBtn_Click(object sender, EventArgs e)
        {
            AppClientCredentials credentials = new AppClientCredentials
                {Nick = this.NickTextBox.Text, PassCode = this.PassCodeTextBox.Text};
            await _apiRequest.ValidateCredentials(credentials);
        }
    }
}
