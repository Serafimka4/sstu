namespace Lab_6
{
    partial class MainForm
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
            this.toCalcBtn = new System.Windows.Forms.Button();
            this.toTxtBtn = new System.Windows.Forms.Button();
            this.textRef1 = new TextRefactor.TextRef();
            this.calculator1 = new Calc.Calculator();
            this.SuspendLayout();
            // 
            // toCalcBtn
            // 
            this.toCalcBtn.Location = new System.Drawing.Point(271, 328);
            this.toCalcBtn.Name = "toCalcBtn";
            this.toCalcBtn.Size = new System.Drawing.Size(89, 23);
            this.toCalcBtn.TabIndex = 2;
            this.toCalcBtn.Text = "To Calculator";
            this.toCalcBtn.UseVisualStyleBackColor = true;
            this.toCalcBtn.Click += new System.EventHandler(this.ToCalcBtn_Click);
            // 
            // toTxtBtn
            // 
            this.toTxtBtn.Location = new System.Drawing.Point(432, 328);
            this.toTxtBtn.Name = "toTxtBtn";
            this.toTxtBtn.Size = new System.Drawing.Size(75, 23);
            this.toTxtBtn.TabIndex = 3;
            this.toTxtBtn.Text = "To Text";
            this.toTxtBtn.UseVisualStyleBackColor = true;
            this.toTxtBtn.Click += new System.EventHandler(this.ToTxtBtn_Click);
            // 
            // textRef1
            // 
            this.textRef1.Location = new System.Drawing.Point(406, 12);
            this.textRef1.Name = "textRef1";
            this.textRef1.RichText = "";
            this.textRef1.Size = new System.Drawing.Size(481, 293);
            this.textRef1.TabIndex = 1;
            // 
            // calculator1
            // 
            this.calculator1.Location = new System.Drawing.Point(1, 12);
            this.calculator1.Name = "calculator1";
            this.calculator1.Num = 0D;
            this.calculator1.Size = new System.Drawing.Size(359, 218);
            this.calculator1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 374);
            this.Controls.Add(this.toTxtBtn);
            this.Controls.Add(this.toCalcBtn);
            this.Controls.Add(this.textRef1);
            this.Controls.Add(this.calculator1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Calc.Calculator calculator1;
        private TextRefactor.TextRef textRef1;
        private System.Windows.Forms.Button toCalcBtn;
        private System.Windows.Forms.Button toTxtBtn;
    }
}

