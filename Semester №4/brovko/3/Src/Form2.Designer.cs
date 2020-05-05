namespace ThirdPractice
{
	partial class Form2
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.буклетПродуктаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.буклетГостиницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.буклетОрганизацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.мозаикойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выравнивнаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.поЛевомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.поЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.поПравомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel6 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel7 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel8 = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
					this.открытьToolStripMenuItem,
					this.видToolStripMenuItem,
					this.окноToolStripMenuItem,
					this.выравнивнаниеToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(600, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
					this.буклетПродуктаToolStripMenuItem,
					this.буклетГостиницыToolStripMenuItem,
					this.буклетОрганизацииToolStripMenuItem});
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.открытьToolStripMenuItem.Text = "Открыть";
			// 
			// буклетПродуктаToolStripMenuItem
			// 
			this.буклетПродуктаToolStripMenuItem.Name = "буклетПродуктаToolStripMenuItem";
			this.буклетПродуктаToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.буклетПродуктаToolStripMenuItem.Text = "Буклет продукта";
			this.буклетПродуктаToolStripMenuItem.Click += new System.EventHandler(this.createProduct_Click);
			// 
			// буклетГостиницыToolStripMenuItem
			// 
			this.буклетГостиницыToolStripMenuItem.Name = "буклетГостиницыToolStripMenuItem";
			this.буклетГостиницыToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.буклетГостиницыToolStripMenuItem.Text = "Буклет гостиницы";
			this.буклетГостиницыToolStripMenuItem.Click += new System.EventHandler(this.createHotel_Click);
			// 
			// буклетОрганизацииToolStripMenuItem
			// 
			this.буклетОрганизацииToolStripMenuItem.Name = "буклетОрганизацииToolStripMenuItem";
			this.буклетОрганизацииToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.буклетОрганизацииToolStripMenuItem.Text = "Буклет организации";
			this.буклетОрганизацииToolStripMenuItem.Click += new System.EventHandler(this.organizationCreate_Click);
			// 
			// видToolStripMenuItem
			// 
			this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
					this.каскадомToolStripMenuItem,
					this.мозаикойToolStripMenuItem});
			this.видToolStripMenuItem.Name = "видToolStripMenuItem";
			this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.видToolStripMenuItem.Text = "Вид";
			// 
			// каскадомToolStripMenuItem
			// 
			this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
			this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.каскадомToolStripMenuItem.Text = "Каскадом";
			this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.cascad_Click);
			// 
			// мозаикойToolStripMenuItem
			// 
			this.мозаикойToolStripMenuItem.Name = "мозаикойToolStripMenuItem";
			this.мозаикойToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.мозаикойToolStripMenuItem.Text = "Мозаикой";
			this.мозаикойToolStripMenuItem.Click += new System.EventHandler(this.mosaic_Click);
			// 
			// окноToolStripMenuItem
			// 
			this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
			this.окноToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.окноToolStripMenuItem.Text = "Окно";
			// 
			// выравнивнаниеToolStripMenuItem
			// 
			this.выравнивнаниеToolStripMenuItem.CheckOnClick = true;
			this.выравнивнаниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
					this.поЛевомуКраюToolStripMenuItem,
					this.поЦентруToolStripMenuItem,
					this.поПравомуКраюToolStripMenuItem});
			this.выравнивнаниеToolStripMenuItem.Name = "выравнивнаниеToolStripMenuItem";
			this.выравнивнаниеToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
			this.выравнивнаниеToolStripMenuItem.Text = "Выравнивнание";
			// 
			// поЛевомуКраюToolStripMenuItem
			// 
			this.поЛевомуКраюToolStripMenuItem.Name = "поЛевомуКраюToolStripMenuItem";
			this.поЛевомуКраюToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.поЛевомуКраюToolStripMenuItem.Text = "По левому краю";
			this.поЛевомуКраюToolStripMenuItem.Click += new System.EventHandler(this.leftEdge_Click);
			// 
			// поЦентруToolStripMenuItem
			// 
			this.поЦентруToolStripMenuItem.CheckOnClick = true;
			this.поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
			this.поЦентруToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.поЦентруToolStripMenuItem.Text = "По центру";
			this.поЦентруToolStripMenuItem.Click += new System.EventHandler(this.center_Click);
			// 
			// поПравомуКраюToolStripMenuItem
			// 
			this.поПравомуКраюToolStripMenuItem.Name = "поПравомуКраюToolStripMenuItem";
			this.поПравомуКраюToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.поПравомуКраюToolStripMenuItem.Text = "По правому краю";
			this.поПравомуКраюToolStripMenuItem.Click += new System.EventHandler(this.rightEdge_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
					this.toolStripLabel1,
					this.toolStripLabel2,
					this.toolStripLabel3,
					this.toolStripSeparator1,
					this.toolStripLabel4,
					this.toolStripLabel5,
					this.toolStripSeparator2,
					this.toolStripLabel6,
					this.toolStripLabel7,
					this.toolStripLabel8});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(600, 25);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
			this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
			this.toolStripLabel1.Text = "Продукт";
			this.toolStripLabel1.Click += new System.EventHandler(this.createProduct_Click);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
			this.toolStripLabel2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(69, 22);
			this.toolStripLabel2.Text = "Гостиница";
			this.toolStripLabel2.Click += new System.EventHandler(this.createHotel_Click);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel3.Image")));
			this.toolStripLabel3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(83, 22);
			this.toolStripLabel3.Text = "Организация";
			this.toolStripLabel3.Click += new System.EventHandler(this.organizationCreate_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel4
			// 
			this.toolStripLabel4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel4.Image")));
			this.toolStripLabel4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel4.Name = "toolStripLabel4";
			this.toolStripLabel4.Size = new System.Drawing.Size(64, 22);
			this.toolStripLabel4.Text = "Каскадом";
			this.toolStripLabel4.Click += new System.EventHandler(this.cascad_Click);
			// 
			// toolStripLabel5
			// 
			this.toolStripLabel5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel5.Image")));
			this.toolStripLabel5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel5.Name = "toolStripLabel5";
			this.toolStripLabel5.Size = new System.Drawing.Size(67, 22);
			this.toolStripLabel5.Text = "Мозаикой";
			this.toolStripLabel5.Click += new System.EventHandler(this.mosaic_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel6
			// 
			this.toolStripLabel6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel6.Image")));
			this.toolStripLabel6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel6.Name = "toolStripLabel6";
			this.toolStripLabel6.Size = new System.Drawing.Size(29, 22);
			this.toolStripLabel6.Text = "<--";
			this.toolStripLabel6.Click += new System.EventHandler(this.leftEdge_Click);
			// 
			// toolStripLabel7
			// 
			this.toolStripLabel7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel7.Image")));
			this.toolStripLabel7.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel7.Name = "toolStripLabel7";
			this.toolStripLabel7.Size = new System.Drawing.Size(27, 22);
			this.toolStripLabel7.Text = "<>";
			this.toolStripLabel7.Click += new System.EventHandler(this.center_Click);
			// 
			// toolStripLabel8
			// 
			this.toolStripLabel8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel8.Image")));
			this.toolStripLabel8.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel8.Name = "toolStripLabel8";
			this.toolStripLabel8.Size = new System.Drawing.Size(29, 22);
			this.toolStripLabel8.Text = "-->";
			this.toolStripLabel8.Click += new System.EventHandler(this.rightEdge_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
					this.toolStripStatusLabel1,
					this.toolStripStatusLabel2,
					this.toolStripStatusLabel3});
			this.statusStrip1.Location = new System.Drawing.Point(0, 344);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
			this.statusStrip1.Size = new System.Drawing.Size(600, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form2";
			this.Text = "Form2";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form2_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem буклетПродуктаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem буклетГостиницыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem буклетОрганизацииToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem мозаикойToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выравнивнаниеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem поЛевомуКраюToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem поЦентруToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem поПравомуКраюToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripLabel4;
		private System.Windows.Forms.ToolStripButton toolStripLabel5;
		private System.Windows.Forms.ToolStripButton toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripLabel2;
		private System.Windows.Forms.ToolStripButton toolStripLabel3;
		private System.Windows.Forms.ToolStripButton toolStripLabel6;
		private System.Windows.Forms.ToolStripButton toolStripLabel7;
		private System.Windows.Forms.ToolStripButton toolStripLabel8;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
	}
}
