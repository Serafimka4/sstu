namespace WFLab8_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.moveToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.resizeToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lineToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.rectangleToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.EllipseToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.sizeToolStripTxt = new System.Windows.Forms.ToolStripTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.deleteToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToolStripBtn,
            this.resizeToolStripBtn,
            this.toolStripSeparator1,
            this.lineToolStripBtn,
            this.rectangleToolStripBtn,
            this.EllipseToolStripBtn,
            this.toolStripSeparator3,
            this.colorToolStripBtn,
            this.toolStripLabel1,
            this.sizeToolStripTxt,
            this.toolStripSeparator2,
            this.deleteToolStripBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(690, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // moveToolStripBtn
            // 
            this.moveToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moveToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("moveToolStripBtn.Image")));
            this.moveToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveToolStripBtn.Name = "moveToolStripBtn";
            this.moveToolStripBtn.Size = new System.Drawing.Size(41, 22);
            this.moveToolStripBtn.Text = "Move";
            this.moveToolStripBtn.Click += new System.EventHandler(this.MoveToolStripBtn_Click);
            // 
            // resizeToolStripBtn
            // 
            this.resizeToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resizeToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("resizeToolStripBtn.Image")));
            this.resizeToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resizeToolStripBtn.Name = "resizeToolStripBtn";
            this.resizeToolStripBtn.Size = new System.Drawing.Size(43, 22);
            this.resizeToolStripBtn.Text = "Resize";
            this.resizeToolStripBtn.Click += new System.EventHandler(this.ResizeToolStripBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lineToolStripBtn
            // 
            this.lineToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lineToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStripBtn.Image")));
            this.lineToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineToolStripBtn.Name = "lineToolStripBtn";
            this.lineToolStripBtn.Size = new System.Drawing.Size(33, 22);
            this.lineToolStripBtn.Text = "Line";
            this.lineToolStripBtn.Click += new System.EventHandler(this.LineToolStripBtn_Click);
            // 
            // rectangleToolStripBtn
            // 
            this.rectangleToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rectangleToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("rectangleToolStripBtn.Image")));
            this.rectangleToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangleToolStripBtn.Name = "rectangleToolStripBtn";
            this.rectangleToolStripBtn.Size = new System.Drawing.Size(63, 22);
            this.rectangleToolStripBtn.Text = "Rectangle";
            this.rectangleToolStripBtn.Click += new System.EventHandler(this.RectangleToolStripBtn_Click);
            // 
            // EllipseToolStripBtn
            // 
            this.EllipseToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EllipseToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("EllipseToolStripBtn.Image")));
            this.EllipseToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EllipseToolStripBtn.Name = "EllipseToolStripBtn";
            this.EllipseToolStripBtn.Size = new System.Drawing.Size(44, 22);
            this.EllipseToolStripBtn.Text = "Ellipse";
            this.EllipseToolStripBtn.Click += new System.EventHandler(this.EllipseToolStripBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // colorToolStripBtn
            // 
            this.colorToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.colorToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("colorToolStripBtn.Image")));
            this.colorToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorToolStripBtn.Name = "colorToolStripBtn";
            this.colorToolStripBtn.Size = new System.Drawing.Size(47, 22);
            this.colorToolStripBtn.Text = "Colour";
            this.colorToolStripBtn.Click += new System.EventHandler(this.ColorToolStripBtn_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel1.Text = "Size:";
            // 
            // sizeToolStripTxt
            // 
            this.sizeToolStripTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sizeToolStripTxt.Name = "sizeToolStripTxt";
            this.sizeToolStripTxt.Size = new System.Drawing.Size(100, 25);
            this.sizeToolStripTxt.TextChanged += new System.EventHandler(this.SizeToolStripTxt_TextChanged);
            // 
            // deleteToolStripBtn
            // 
            this.deleteToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripBtn.Image")));
            this.deleteToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripBtn.Name = "deleteToolStripBtn";
            this.deleteToolStripBtn.Size = new System.Drawing.Size(44, 22);
            this.deleteToolStripBtn.Text = "Delete";
            this.deleteToolStripBtn.Click += new System.EventHandler(this.DeleteToolStripBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 387);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton lineToolStripBtn;
        private System.Windows.Forms.ToolStripButton rectangleToolStripBtn;
        private System.Windows.Forms.ToolStripButton EllipseToolStripBtn;
        private System.Windows.Forms.ToolStripButton colorToolStripBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox sizeToolStripTxt;
        private System.Windows.Forms.ToolStripButton moveToolStripBtn;
        private System.Windows.Forms.ToolStripButton resizeToolStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton deleteToolStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

