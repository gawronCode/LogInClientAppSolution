namespace LogInClientApp
{
    partial class LogInForm
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
            this.NickTextBox = new System.Windows.Forms.TextBox();
            this.PassCodeTextBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NickTextBox
            // 
            this.NickTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.NickTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NickTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NickTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NickTextBox.Location = new System.Drawing.Point(10, 10);
            this.NickTextBox.MaxLength = 64;
            this.NickTextBox.Name = "NickTextBox";
            this.NickTextBox.Size = new System.Drawing.Size(570, 38);
            this.NickTextBox.TabIndex = 0;
            this.NickTextBox.Text = "Nick";
            this.NickTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NickTextBox.Click += new System.EventHandler(this.NickTextBox_Click);
            this.NickTextBox.Leave += new System.EventHandler(this.NickTextBox_Leave);
            // 
            // PassCodeTextBox
            // 
            this.PassCodeTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.PassCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassCodeTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PassCodeTextBox.Location = new System.Drawing.Point(10, 58);
            this.PassCodeTextBox.MaxLength = 64;
            this.PassCodeTextBox.Name = "PassCodeTextBox";
            this.PassCodeTextBox.Size = new System.Drawing.Size(570, 38);
            this.PassCodeTextBox.TabIndex = 1;
            this.PassCodeTextBox.Text = "PassCode";
            this.PassCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassCodeTextBox.Click += new System.EventHandler(this.PassCodeTextBox_Click);
            this.PassCodeTextBox.Leave += new System.EventHandler(this.PassCodeTextBox_Leave);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackBtn.Location = new System.Drawing.Point(10, 106);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(280, 90);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInBtn.Location = new System.Drawing.Point(300, 106);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(280, 90);
            this.LogInBtn.TabIndex = 3;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(590, 206);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.PassCodeTextBox);
            this.Controls.Add(this.NickTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogInForm";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NickTextBox;
        private System.Windows.Forms.TextBox PassCodeTextBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button LogInBtn;
    }
}