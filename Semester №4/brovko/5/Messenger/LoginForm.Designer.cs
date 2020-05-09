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
            this.loginLbl = new System.Windows.Forms.Label();
            this.helloLbl = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.sungUpBtn = new System.Windows.Forms.Button();
            this.singUpLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.warningLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLbl.Location = new System.Drawing.Point(169, 26);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(87, 15);
            this.loginLbl.TabIndex = 0;
            this.loginLbl.Text = "Please login";
            // 
            // helloLbl
            // 
            this.helloLbl.AutoSize = true;
            this.helloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helloLbl.Location = new System.Drawing.Point(189, 9);
            this.helloLbl.Name = "helloLbl";
            this.helloLbl.Size = new System.Drawing.Size(49, 17);
            this.helloLbl.TabIndex = 1;
            this.helloLbl.Text = "Hello!";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(163, 116);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(100, 20);
            this.userNameTxt.TabIndex = 2;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(84, 119);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(58, 13);
            this.userNameLbl.TabIndex = 3;
            this.userNameLbl.Text = "User name";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(163, 153);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(100, 20);
            this.passwordTxt.TabIndex = 4;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(84, 160);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 5;
            this.passwordLbl.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(87, 212);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // sungUpBtn
            // 
            this.sungUpBtn.Location = new System.Drawing.Point(172, 279);
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
            this.singUpLbl.Location = new System.Drawing.Point(33, 284);
            this.singUpLbl.Name = "singUpLbl";
            this.singUpLbl.Size = new System.Drawing.Size(122, 13);
            this.singUpLbl.TabIndex = 8;
            this.singUpLbl.Text = "Don\'t have an account?";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(264, 212);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // warningLbl
            // 
            this.warningLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warningLbl.ForeColor = System.Drawing.Color.Red;
            this.warningLbl.Location = new System.Drawing.Point(87, 79);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(252, 20);
            this.warningLbl.TabIndex = 10;
            this.warningLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 325);
            this.Controls.Add(this.warningLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.singUpLbl);
            this.Controls.Add(this.sungUpBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.helloLbl);
            this.Controls.Add(this.loginLbl);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label helloLbl;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button sungUpBtn;
        private System.Windows.Forms.Label singUpLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label warningLbl;
        private System.Windows.Forms.Button loginBtn;
    }
}