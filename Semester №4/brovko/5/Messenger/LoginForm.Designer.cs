namespace Lab_5
{
    partial class LoginForm
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
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.sungUpBtn = new System.Windows.Forms.Button();
            this.singUpLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(99, 70);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(132, 20);
            this.userNameTxt.TabIndex = 2;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(96, 54);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(33, 13);
            this.userNameLbl.TabIndex = 3;
            this.userNameLbl.Text = "Login";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(99, 114);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(132, 20);
            this.passwordTxt.TabIndex = 4;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(96, 98);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 5;
            this.passwordLbl.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(86, 155);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // sungUpBtn
            // 
            this.sungUpBtn.Location = new System.Drawing.Point(126, 243);
            this.sungUpBtn.Name = "sungUpBtn";
            this.sungUpBtn.Size = new System.Drawing.Size(75, 23);
            this.sungUpBtn.TabIndex = 7;
            this.sungUpBtn.Text = "Sign Up";
            this.sungUpBtn.UseVisualStyleBackColor = true;
            this.sungUpBtn.Click += new System.EventHandler(this.SungUpBtn_Click);
            // 
            // singUpLbl
            // 
            this.singUpLbl.AutoSize = true;
            this.singUpLbl.Location = new System.Drawing.Point(103, 227);
            this.singUpLbl.Name = "singUpLbl";
            this.singUpLbl.Size = new System.Drawing.Size(122, 13);
            this.singUpLbl.TabIndex = 8;
            this.singUpLbl.Text = "Don\'t have an account?";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(167, 155);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 278);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.singUpLbl);
            this.Controls.Add(this.sungUpBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.userNameTxt);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button sungUpBtn;
        private System.Windows.Forms.Label singUpLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button loginBtn;
    }
}