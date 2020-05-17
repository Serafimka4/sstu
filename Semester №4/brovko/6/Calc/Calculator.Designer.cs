namespace Calc
{
    partial class Calculator
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
            this.mathTxt = new System.Windows.Forms.TextBox();
            this.sumBtb = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.eqBtn = new System.Windows.Forms.Button();
            this.resTxt = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mathTxt
            // 
            this.mathTxt.Location = new System.Drawing.Point(18, 17);
            this.mathTxt.Name = "mathTxt";
            this.mathTxt.Size = new System.Drawing.Size(321, 20);
            this.mathTxt.TabIndex = 0;
            this.mathTxt.Validating += new System.ComponentModel.CancelEventHandler(this.MathTxt_Validating);
            // 
            // sumBtb
            // 
            this.sumBtb.Location = new System.Drawing.Point(18, 112);
            this.sumBtb.Name = "sumBtb";
            this.sumBtb.Size = new System.Drawing.Size(75, 23);
            this.sumBtb.TabIndex = 1;
            this.sumBtb.Text = "+";
            this.sumBtb.UseVisualStyleBackColor = true;
            this.sumBtb.Click += new System.EventHandler(this.MathBtb_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(104, 112);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(75, 23);
            this.minusBtn.TabIndex = 2;
            this.minusBtn.Text = "−";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.MathBtb_Click);
            // 
            // multBtn
            // 
            this.multBtn.Location = new System.Drawing.Point(185, 112);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(75, 23);
            this.multBtn.TabIndex = 3;
            this.multBtn.Text = "×";
            this.multBtn.UseVisualStyleBackColor = true;
            this.multBtn.Click += new System.EventHandler(this.MathBtb_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(266, 112);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(75, 23);
            this.divBtn.TabIndex = 4;
            this.divBtn.Text = "÷";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.MathBtb_Click);
            // 
            // eqBtn
            // 
            this.eqBtn.Location = new System.Drawing.Point(266, 168);
            this.eqBtn.Name = "eqBtn";
            this.eqBtn.Size = new System.Drawing.Size(75, 23);
            this.eqBtn.TabIndex = 5;
            this.eqBtn.Text = "=";
            this.eqBtn.UseVisualStyleBackColor = true;
            this.eqBtn.Click += new System.EventHandler(this.MathBtb_Click);
            // 
            // resTxt
            // 
            this.resTxt.Location = new System.Drawing.Point(185, 54);
            this.resTxt.Name = "resTxt";
            this.resTxt.ReadOnly = true;
            this.resTxt.Size = new System.Drawing.Size(154, 20);
            this.resTxt.TabIndex = 6;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLbl.Location = new System.Drawing.Point(127, 54);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(52, 17);
            this.resultLbl.TabIndex = 7;
            this.resultLbl.Text = "Result:";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.resTxt);
            this.Controls.Add(this.eqBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.multBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.sumBtb);
            this.Controls.Add(this.mathTxt);
            this.Name = "Calculator";
            this.Size = new System.Drawing.Size(364, 204);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mathTxt;
        private System.Windows.Forms.Button sumBtb;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button eqBtn;
        private System.Windows.Forms.TextBox resTxt;
        private System.Windows.Forms.Label resultLbl;
    }
}
