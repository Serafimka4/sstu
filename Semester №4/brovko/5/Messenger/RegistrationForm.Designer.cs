namespace Lab_5
{
    partial class RegistrationForm
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
            this.userNameLbl = new System.Windows.Forms.Label();
            this.fullNameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.fullNameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(120, 42);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(33, 13);
            this.userNameLbl.TabIndex = 1;
            this.userNameLbl.Text = "Login";
            // 
            // fullNameLbl
            // 
            this.fullNameLbl.AutoSize = true;
            this.fullNameLbl.Location = new System.Drawing.Point(120, 88);
            this.fullNameLbl.Name = "fullNameLbl";
            this.fullNameLbl.Size = new System.Drawing.Size(52, 13);
            this.fullNameLbl.TabIndex = 2;
            this.fullNameLbl.Text = "Full name";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(120, 131);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(123, 58);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(100, 20);
            this.userNameTxt.TabIndex = 4;
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Location = new System.Drawing.Point(123, 104);
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.Size = new System.Drawing.Size(100, 20);
            this.fullNameTxt.TabIndex = 5;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(123, 146);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(100, 20);
            this.passwordTxt.TabIndex = 6;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(132, 190);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 7;
            this.registerBtn.Text = "Sign Up";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(17, 14);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(295, 23);
            this.errorLbl.TabIndex = 8;
            this.errorLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 260);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.fullNameTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.fullNameLbl);
            this.Controls.Add(this.userNameLbl);
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label fullNameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox fullNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label errorLbl;
    }
}