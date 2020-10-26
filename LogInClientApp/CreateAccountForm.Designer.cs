namespace LogInClientApp
{
    partial class CreateAccountForm
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
            this.CreateBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.NickTextBox = new System.Windows.Forms.TextBox();
            this.PassCodeTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPassCodeTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateBtn.Location = new System.Drawing.Point(300, 202);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(280, 90);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackBtn.Location = new System.Drawing.Point(10, 202);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(280, 90);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NickTextBox
            // 
            this.NickTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.NickTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NickTextBox.Location = new System.Drawing.Point(10, 10);
            this.NickTextBox.Name = "NickTextBox";
            this.NickTextBox.Size = new System.Drawing.Size(570, 38);
            this.NickTextBox.TabIndex = 2;
            this.NickTextBox.Text = "Nick";
            // 
            // PassCodeTextBox
            // 
            this.PassCodeTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.PassCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassCodeTextBox.Location = new System.Drawing.Point(10, 58);
            this.PassCodeTextBox.Name = "PassCodeTextBox";
            this.PassCodeTextBox.Size = new System.Drawing.Size(570, 38);
            this.PassCodeTextBox.TabIndex = 3;
            this.PassCodeTextBox.Text = "PassCode";
            // 
            // RepeatPassCodeTextBox
            // 
            this.RepeatPassCodeTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.RepeatPassCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RepeatPassCodeTextBox.Location = new System.Drawing.Point(10, 106);
            this.RepeatPassCodeTextBox.Name = "RepeatPassCodeTextBox";
            this.RepeatPassCodeTextBox.Size = new System.Drawing.Size(570, 38);
            this.RepeatPassCodeTextBox.TabIndex = 4;
            this.RepeatPassCodeTextBox.Text = "Repeat PassCode";
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.EmailAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailAddressTextBox.Location = new System.Drawing.Point(10, 154);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(570, 38);
            this.EmailAddressTextBox.TabIndex = 5;
            this.EmailAddressTextBox.Text = "Email Address";
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(590, 302);
            this.Controls.Add(this.EmailAddressTextBox);
            this.Controls.Add(this.RepeatPassCodeTextBox);
            this.Controls.Add(this.PassCodeTextBox);
            this.Controls.Add(this.NickTextBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CreateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateAccountForm";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox NickTextBox;
        private System.Windows.Forms.TextBox PassCodeTextBox;
        private System.Windows.Forms.TextBox RepeatPassCodeTextBox;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
    }
}