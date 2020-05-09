namespace Lab_5
{
    partial class Messenger
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messenger));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.composeBtn = new System.Windows.Forms.ToolStripButton();
            this.checkBtn = new System.Windows.Forms.ToolStripButton();
            this.closeMsgBoxBtn = new System.Windows.Forms.ToolStripButton();
            this.logoutBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.composeBtn,
            this.checkBtn,
            this.closeMsgBoxBtn,
            this.logoutBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // composeBtn
            // 
            this.composeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.composeBtn.Enabled = false;
            this.composeBtn.Image = ((System.Drawing.Image)(resources.GetObject("composeBtn.Image")));
            this.composeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.composeBtn.Name = "composeBtn";
            this.composeBtn.Size = new System.Drawing.Size(62, 22);
            this.composeBtn.Text = "Compose";
            this.composeBtn.Click += new System.EventHandler(this.ComposeBtn_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.checkBtn.Enabled = false;
            this.checkBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkBtn.Image")));
            this.checkBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(98, 22);
            this.checkBtn.Text = "Check Messages";
            this.checkBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // closeMsgBoxBtn
            // 
            this.closeMsgBoxBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closeMsgBoxBtn.Enabled = false;
            this.closeMsgBoxBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeMsgBoxBtn.Image")));
            this.closeMsgBoxBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeMsgBoxBtn.Name = "closeMsgBoxBtn";
            this.closeMsgBoxBtn.Size = new System.Drawing.Size(112, 22);
            this.closeMsgBoxBtn.Text = "Close message box";
            this.closeMsgBoxBtn.Click += new System.EventHandler(this.CloseMsgBoxBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logoutBtn.Enabled = false;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(49, 22);
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Messenger";
            this.Text = "Messenger";
            this.Load += new System.EventHandler(this.Messenger_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton composeBtn;
        private System.Windows.Forms.ToolStripButton checkBtn;
        private System.Windows.Forms.ToolStripButton closeMsgBoxBtn;
        private System.Windows.Forms.ToolStripButton logoutBtn;
    }
}

