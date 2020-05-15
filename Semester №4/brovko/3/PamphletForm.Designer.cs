using System.Windows.Forms;

namespace Lab_3
{
    partial class PamphletForm
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
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PamphletForm));
            this.printDialog1 = new PrintDialog();
            this.printPreviewDialog1 = new PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.fontDialog = new FontDialog();
            this.openFileDialog = new OpenFileDialog();
            this.colorDialog = new ColorDialog();
            this.panel = new Panel();
            this.btnOpen = new Button();
            this.btnExit = new Button();
            this.btnFont = new Button();
            this.btnColor = new Button();
            this.btnPrint = new Button();
            this.lblHead = new Label();
            this.lblName = new Label();
            this.lblAdress = new Label();
            this.lblTitle = new Label();
            this.lblNumber = new Label();
            this.lblPerson = new Label();
            this.lblDate = new Label();
            this.nameTextBox = new TextBox();
            this.addressTextBox = new TextBox();
            this.titleTextBox = new TextBox();
            this.phoneNumberTextBox = new TextBox();
            this.contactPersonTextBox = new TextBox();
            this.dateTextBox = new TextBox();
            this.richTextBox = new RichTextBox();
            this.errorProvider = new ErrorProvider(this.components);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // panel
            // 
            this.panel.BorderStyle = BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.btnOpen);
            this.panel.Controls.Add(this.btnExit);
            this.panel.Controls.Add(this.btnFont);
            this.panel.Controls.Add(this.btnColor);
            this.panel.Controls.Add(this.btnPrint);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(52, 289);
            this.panel.Margin = new Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(497, 69);
            this.panel.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(43, 26);
            this.btnOpen.Margin = new Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(56, 19);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(135, 26);
            this.btnExit.Margin = new Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(226, 26);
            this.btnFont.Margin = new Padding(2);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(56, 19);
            this.btnFont.TabIndex = 3;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(319, 26);
            this.btnColor.Margin = new Padding(2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(56, 19);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(407, 26);
            this.btnPrint.Margin = new Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(56, 19);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHead.Location = new System.Drawing.Point(184, 20);
            this.lblHead.Margin = new Padding(2, 0, 2, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(248, 24);
            this.lblHead.TabIndex = 6;
            this.lblHead.Text = "Create Your Own Pamphlets";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 74);
            this.lblName.Margin = new Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name of the organisation";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(16, 110);
            this.lblAdress.Margin = new Padding(2, 0, 2, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(129, 13);
            this.lblAdress.TabIndex = 8;
            this.lblAdress.Text = "Adress of the organisation";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 150);
            this.lblTitle.Margin = new Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(310, 76);
            this.lblNumber.Margin = new Padding(2, 0, 2, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(84, 13);
            this.lblNumber.TabIndex = 10;
            this.lblNumber.Text = "Contact Number";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(310, 112);
            this.lblPerson.Margin = new Padding(2, 0, 2, 0);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(92, 13);
            this.lblPerson.TabIndex = 11;
            this.lblPerson.Text = "Person to Contact";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(310, 150);
            this.lblDate.Margin = new Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(166, 74);
            this.nameTextBox.Margin = new Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(101, 20);
            this.nameTextBox.TabIndex = 13;
            this.nameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(166, 110);
            this.addressTextBox.Margin = new Padding(2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(101, 20);
            this.addressTextBox.TabIndex = 14;
            this.addressTextBox.Leave += new System.EventHandler(this.AddressTextBox_Leave);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(166, 148);
            this.titleTextBox.Margin = new Padding(2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(101, 20);
            this.titleTextBox.TabIndex = 15;
            this.titleTextBox.Leave += new System.EventHandler(this.TitleTextBox_Leave);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(446, 71);
            this.phoneNumberTextBox.Margin = new Padding(2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(103, 20);
            this.phoneNumberTextBox.TabIndex = 16;
            this.phoneNumberTextBox.Leave += new System.EventHandler(this.PhoneNumberTextBox_Leave);
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.Location = new System.Drawing.Point(447, 112);
            this.contactPersonTextBox.Margin = new Padding(2);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(103, 20);
            this.contactPersonTextBox.TabIndex = 17;
            this.contactPersonTextBox.Leave += new System.EventHandler(this.ContactPersonTextBox_Leave);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(447, 148);
            this.dateTextBox.Margin = new Padding(2);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(103, 20);
            this.dateTextBox.TabIndex = 18;
            this.dateTextBox.Leave += new System.EventHandler(this.DateTextBox_Leave);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(52, 193);
            this.richTextBox.Margin = new Padding(2);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(498, 82);
            this.richTextBox.TabIndex = 19;
            this.richTextBox.Text = "";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 369);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.contactPersonTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.panel);
            this.Margin = new Padding(2);
            this.Name = "PamphletForm";
            this.Text = "PamphletForm";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private FontDialog fontDialog;
        private OpenFileDialog openFileDialog;
        private ColorDialog colorDialog;
        private Panel panel;
        private Button btnOpen;
        private Button btnFont;
        private Button btnColor;
        private Button btnPrint;
        private Label lblName;
        private Label lblAdress;
        private Label lblTitle;
        private Label lblNumber;
        private Label lblPerson;
        private Label lblDate;
        private TextBox addressTextBox;
        private TextBox titleTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox contactPersonTextBox;
        private TextBox dateTextBox;
        private RichTextBox richTextBox;
        private ErrorProvider errorProvider;
        public TextBox nameTextBox;
        public Label lblHead;
        protected Button btnExit;
    }
}

