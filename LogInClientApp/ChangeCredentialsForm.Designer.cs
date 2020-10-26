namespace LogInClientApp
{
    partial class ChangeCredentialsForm
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
            this.PassCodeFormBtn = new System.Windows.Forms.Button();
            this.EmailFormBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PassCodeFormBtn
            // 
            this.PassCodeFormBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.PassCodeFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassCodeFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassCodeFormBtn.Location = new System.Drawing.Point(10, 10);
            this.PassCodeFormBtn.Name = "PassCodeFormBtn";
            this.PassCodeFormBtn.Size = new System.Drawing.Size(280, 90);
            this.PassCodeFormBtn.TabIndex = 0;
            this.PassCodeFormBtn.Text = "Change PassCode";
            this.PassCodeFormBtn.UseVisualStyleBackColor = false;
            // 
            // EmailFormBtn
            // 
            this.EmailFormBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.EmailFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmailFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailFormBtn.Location = new System.Drawing.Point(10, 110);
            this.EmailFormBtn.Name = "EmailFormBtn";
            this.EmailFormBtn.Size = new System.Drawing.Size(280, 90);
            this.EmailFormBtn.TabIndex = 1;
            this.EmailFormBtn.Text = "Change Email";
            this.EmailFormBtn.UseVisualStyleBackColor = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackBtn.Location = new System.Drawing.Point(10, 210);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(280, 90);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ChangeCredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 310);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EmailFormBtn);
            this.Controls.Add(this.PassCodeFormBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeCredentialsForm";
            this.Text = "Change Credentials";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PassCodeFormBtn;
        private System.Windows.Forms.Button EmailFormBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}