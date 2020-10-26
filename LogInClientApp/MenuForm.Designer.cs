namespace LogInClientApp
{
    partial class MenuForm
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
            this.LogInFormBtn = new System.Windows.Forms.Button();
            this.ChangeCredentialsFormBtn = new System.Windows.Forms.Button();
            this.CreateAccountFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInFormBtn
            // 
            this.LogInFormBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.LogInFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInFormBtn.Location = new System.Drawing.Point(10, 10);
            this.LogInFormBtn.Name = "LogInFormBtn";
            this.LogInFormBtn.Size = new System.Drawing.Size(280, 90);
            this.LogInFormBtn.TabIndex = 0;
            this.LogInFormBtn.Text = "Log In";
            this.LogInFormBtn.UseVisualStyleBackColor = false;
            // 
            // ChangeCredentialsFormBtn
            // 
            this.ChangeCredentialsFormBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.ChangeCredentialsFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeCredentialsFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChangeCredentialsFormBtn.Location = new System.Drawing.Point(10, 110);
            this.ChangeCredentialsFormBtn.Name = "ChangeCredentialsFormBtn";
            this.ChangeCredentialsFormBtn.Size = new System.Drawing.Size(280, 90);
            this.ChangeCredentialsFormBtn.TabIndex = 1;
            this.ChangeCredentialsFormBtn.Text = "Change Credentials";
            this.ChangeCredentialsFormBtn.UseVisualStyleBackColor = false;
            // 
            // CreateAccountFormBtn
            // 
            this.CreateAccountFormBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.CreateAccountFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccountFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateAccountFormBtn.Location = new System.Drawing.Point(10, 210);
            this.CreateAccountFormBtn.Name = "CreateAccountFormBtn";
            this.CreateAccountFormBtn.Size = new System.Drawing.Size(280, 90);
            this.CreateAccountFormBtn.TabIndex = 2;
            this.CreateAccountFormBtn.Text = "Create Account";
            this.CreateAccountFormBtn.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 313);
            this.Controls.Add(this.CreateAccountFormBtn);
            this.Controls.Add(this.ChangeCredentialsFormBtn);
            this.Controls.Add(this.LogInFormBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogInFormBtn;
        private System.Windows.Forms.Button ChangeCredentialsFormBtn;
        private System.Windows.Forms.Button CreateAccountFormBtn;
    }
}

