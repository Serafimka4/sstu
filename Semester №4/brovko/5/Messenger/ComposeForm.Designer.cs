namespace Lab_5
{
    partial class ComposeForm
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
            this.toLbl = new System.Windows.Forms.Label();
            this.subLbl = new System.Windows.Forms.Label();
            this.MessegeLbl = new System.Windows.Forms.Label();
            this.toTxt = new System.Windows.Forms.TextBox();
            this.subTxt = new System.Windows.Forms.TextBox();
            this.bodyRTxt = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(60, 61);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(20, 13);
            this.toLbl.TabIndex = 0;
            this.toLbl.Text = "To";
            // 
            // subLbl
            // 
            this.subLbl.AutoSize = true;
            this.subLbl.Location = new System.Drawing.Point(60, 97);
            this.subLbl.Name = "subLbl";
            this.subLbl.Size = new System.Drawing.Size(43, 13);
            this.subLbl.TabIndex = 1;
            this.subLbl.Text = "Subject";
            // 
            // MessegeLbl
            // 
            this.MessegeLbl.AutoSize = true;
            this.MessegeLbl.Location = new System.Drawing.Point(221, 130);
            this.MessegeLbl.Name = "MessegeLbl";
            this.MessegeLbl.Size = new System.Drawing.Size(50, 13);
            this.MessegeLbl.TabIndex = 2;
            this.MessegeLbl.Text = "Messege";
            // 
            // toTxt
            // 
            this.toTxt.Location = new System.Drawing.Point(224, 61);
            this.toTxt.Name = "toTxt";
            this.toTxt.Size = new System.Drawing.Size(204, 20);
            this.toTxt.TabIndex = 3;
            // 
            // subTxt
            // 
            this.subTxt.Location = new System.Drawing.Point(224, 97);
            this.subTxt.Name = "subTxt";
            this.subTxt.Size = new System.Drawing.Size(204, 20);
            this.subTxt.TabIndex = 4;
            // 
            // bodyRTxt
            // 
            this.bodyRTxt.Location = new System.Drawing.Point(63, 156);
            this.bodyRTxt.Name = "bodyRTxt";
            this.bodyRTxt.Size = new System.Drawing.Size(370, 162);
            this.bodyRTxt.TabIndex = 5;
            this.bodyRTxt.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(63, 333);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(353, 333);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(63, 26);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(365, 23);
            this.errorLbl.TabIndex = 8;
            this.errorLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ComposeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 368);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.bodyRTxt);
            this.Controls.Add(this.subTxt);
            this.Controls.Add(this.toTxt);
            this.Controls.Add(this.MessegeLbl);
            this.Controls.Add(this.subLbl);
            this.Controls.Add(this.toLbl);
            this.Name = "ComposeForm";
            this.Text = "New messege";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.Label subLbl;
        private System.Windows.Forms.Label MessegeLbl;
        private System.Windows.Forms.TextBox toTxt;
        private System.Windows.Forms.TextBox subTxt;
        private System.Windows.Forms.RichTextBox bodyRTxt;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label errorLbl;
    }
}