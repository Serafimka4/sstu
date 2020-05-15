namespace Lab_2
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.animalsByNameComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameOfAnimalLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.byCountryCheckBox = new System.Windows.Forms.CheckBox();
            this.byNameCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabel.Location = new System.Drawing.Point(80, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(334, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "The Animal Kingdom";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allCheckBox);
            this.groupBox1.Controls.Add(this.byCountryCheckBox);
            this.groupBox1.Controls.Add(this.byNameCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(31, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(387, 117);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(100, 30);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // animalsByNameComboBox
            // 
            this.animalsByNameComboBox.FormattingEnabled = true;
            this.animalsByNameComboBox.Items.AddRange(new object[] {
            "Crane",
            "Elephant",
            "Squirrel",
            "Lion",
            "Fox"});
            this.animalsByNameComboBox.Location = new System.Drawing.Point(181, 42);
            this.animalsByNameComboBox.Name = "animalsByNameComboBox";
            this.animalsByNameComboBox.Size = new System.Drawing.Size(243, 24);
            this.animalsByNameComboBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameOfAnimalLabel);
            this.groupBox2.Controls.Add(this.animalsByNameComboBox);
            this.groupBox2.Location = new System.Drawing.Point(31, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // nameOfAnimalLabel
            // 
            this.nameOfAnimalLabel.AutoSize = true;
            this.nameOfAnimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nameOfAnimalLabel.Location = new System.Drawing.Point(13, 45);
            this.nameOfAnimalLabel.Name = "nameOfAnimalLabel";
            this.nameOfAnimalLabel.Size = new System.Drawing.Size(131, 17);
            this.nameOfAnimalLabel.TabIndex = 4;
            this.nameOfAnimalLabel.Text = "Name of the Animal";
            // 
            // previousButton
            // 
            this.exitButton.Location = new System.Drawing.Point(387, 321);
            this.exitButton.Name = "previousButton";
            this.exitButton.Size = new System.Drawing.Size(100, 30);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.Location = new System.Drawing.Point(250, 26);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(45, 21);
            this.allCheckBox.TabIndex = 2;
            this.allCheckBox.Text = "All";
            this.allCheckBox.UseVisualStyleBackColor = true;
            // 
            // byCountryCheckBox
            // 
            this.byCountryCheckBox.AutoSize = true;
            this.byCountryCheckBox.Location = new System.Drawing.Point(127, 26);
            this.byCountryCheckBox.Name = "byCountryCheckBox";
            this.byCountryCheckBox.Size = new System.Drawing.Size(99, 21);
            this.byCountryCheckBox.TabIndex = 1;
            this.byCountryCheckBox.Text = "By Country";
            this.byCountryCheckBox.UseVisualStyleBackColor = true;
            // 
            // byNameCheckBox
            // 
            this.byNameCheckBox.AutoSize = true;
            this.byNameCheckBox.Location = new System.Drawing.Point(16, 26);
            this.byNameCheckBox.Name = "byNameCheckBox";
            this.byNameCheckBox.Size = new System.Drawing.Size(87, 21);
            this.byNameCheckBox.TabIndex = 0;
            this.byNameCheckBox.Text = "By Name";
            this.byNameCheckBox.UseVisualStyleBackColor = true;
            this.byNameCheckBox.CheckedChanged += new System.EventHandler(this.ByNameCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 363);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.ComboBox animalsByNameComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label nameOfAnimalLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox allCheckBox;
        private System.Windows.Forms.CheckBox byCountryCheckBox;
        private System.Windows.Forms.CheckBox byNameCheckBox;
    }
}

