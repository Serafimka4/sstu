namespace TextRefactor
{
    partial class TextRef
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.colourBtn = new System.Windows.Forms.Button();
            this.leftCorBtn = new System.Windows.Forms.Button();
            this.cenCorBtn = new System.Windows.Forms.Button();
            this.rightCorBtn = new System.Windows.Forms.Button();
            this.fontBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(3, 3);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(475, 148);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // colourBtn
            // 
            this.colourBtn.Location = new System.Drawing.Point(126, 210);
            this.colourBtn.Name = "colourBtn";
            this.colourBtn.Size = new System.Drawing.Size(75, 23);
            this.colourBtn.TabIndex = 1;
            this.colourBtn.Text = "Colour";
            this.colourBtn.UseVisualStyleBackColor = true;
            this.colourBtn.Click += new System.EventHandler(this.ColourBtn_Click);
            // 
            // leftCorBtn
            // 
            this.leftCorBtn.Location = new System.Drawing.Point(145, 157);
            this.leftCorBtn.Name = "leftCorBtn";
            this.leftCorBtn.Size = new System.Drawing.Size(29, 23);
            this.leftCorBtn.TabIndex = 2;
            this.leftCorBtn.Text = "<<";
            this.leftCorBtn.UseVisualStyleBackColor = true;
            this.leftCorBtn.Click += new System.EventHandler(this.LeftCorBtn_Click);
            // 
            // cenCorBtn
            // 
            this.cenCorBtn.Location = new System.Drawing.Point(218, 157);
            this.cenCorBtn.Name = "cenCorBtn";
            this.cenCorBtn.Size = new System.Drawing.Size(34, 23);
            this.cenCorBtn.TabIndex = 3;
            this.cenCorBtn.Text = "<->";
            this.cenCorBtn.UseVisualStyleBackColor = true;
            this.cenCorBtn.Click += new System.EventHandler(this.CenCorBtn_Click);
            // 
            // rightCorBtn
            // 
            this.rightCorBtn.Location = new System.Drawing.Point(296, 157);
            this.rightCorBtn.Name = "rightCorBtn";
            this.rightCorBtn.Size = new System.Drawing.Size(29, 23);
            this.rightCorBtn.TabIndex = 4;
            this.rightCorBtn.Text = ">>";
            this.rightCorBtn.UseVisualStyleBackColor = true;
            this.rightCorBtn.Click += new System.EventHandler(this.RightCorBtn_Click);
            // 
            // fontBtn
            // 
            this.fontBtn.Location = new System.Drawing.Point(271, 210);
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(75, 23);
            this.fontBtn.TabIndex = 5;
            this.fontBtn.Text = "Font";
            this.fontBtn.UseVisualStyleBackColor = true;
            this.fontBtn.Click += new System.EventHandler(this.FontBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(145, 262);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(250, 262);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 7;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TextRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fontBtn);
            this.Controls.Add(this.rightCorBtn);
            this.Controls.Add(this.cenCorBtn);
            this.Controls.Add(this.leftCorBtn);
            this.Controls.Add(this.colourBtn);
            this.Controls.Add(this.richTextBox);
            this.Name = "TextRef";
            this.Size = new System.Drawing.Size(481, 293);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button colourBtn;
        private System.Windows.Forms.Button leftCorBtn;
        private System.Windows.Forms.Button cenCorBtn;
        private System.Windows.Forms.Button rightCorBtn;
        private System.Windows.Forms.Button fontBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
