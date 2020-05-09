using System;
using System.Windows.Forms;

namespace Lab_1
{
	public class StudentEntryForm : Form
	{
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label Title;
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();

			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.saveButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.Title = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.saveButton.Location = new System.Drawing.Point(50, 380);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(100, 30);
			this.saveButton.TabIndex = 0;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(182, 380);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 30);
			this.button2.TabIndex = 1;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(319, 380);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(100, 30);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label1.Location = new System.Drawing.Point(54, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name";
			this.label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label2.Location = new System.Drawing.Point(54, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "Address";
			this.label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.label3.Location = new System.Drawing.Point(54, 210);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 26);
			this.label3.TabIndex = 5;
			this.label3.Text = "Phone Number";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.label4.Location = new System.Drawing.Point(54, 264);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 26);
			this.label4.TabIndex = 6;
			this.label4.Text = "Degree Opted";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.label5.Location = new System.Drawing.Point(54, 322);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 26);
			this.label5.TabIndex = 7;
			this.label5.Text = "Majors Opted";
			this.label5.Click += new System.EventHandler(this.Label5_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(230, 210);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(158, 22);
			this.textBox1.TabIndex = 8;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(230, 160);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(158, 22);
			this.textBox2.TabIndex = 9;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(230, 101);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(158, 22);
			this.textBox3.TabIndex = 10;
			this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Items.AddRange(new object[] {
					"BE",
					"MS",
					"BTech",
					"MTech",
					"BSc",
					"MSc",
					"BA ",
					"MA",
					"Bcom",
					"Mcom",
					"BCA",
					"MCA"});
			this.listBox1.Location = new System.Drawing.Point(230, 264);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(158, 36);
			this.listBox1.TabIndex = 11;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
					"Mathematics ",
					"Physics",
					"Chemistry",
					"Biology",
					"Accounts"});
			this.checkedListBox1.Location = new System.Drawing.Point(230, 322);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(158, 38);
			this.checkedListBox1.TabIndex = 12;
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.Title.Location = new System.Drawing.Point(82, 28);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(310, 39);
			this.Title.TabIndex = 13;
			this.Title.Text = "Student Enrty Form";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 434);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.saveButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		public StudentEntryForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void TextBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void Label2_Click(object sender, EventArgs e)
		{

		}

		private void Label5_Click(object sender, EventArgs e)
		{

		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < 4)
			{
				checkedListBox1.Items.Clear();
				checkedListBox1.Items.AddRange(new String[] {
						"Computer Science",
						"Mechanical",
						"Electrical",
						"Electrical and Electronics",
						"Electronics and Communication",
						"Civil"
						});
			}

			if (listBox1.SelectedIndex >= 0)
			{
				listBox1.Visible = false;
				label4.Text = "Degree opted: " + listBox1.Text;
			}

		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			String result = "Name: " + textBox3.Text + "\n";

			result += "Address: " + textBox2.Text + "\n";
			result += "Phone number: " + textBox1.Text + "\n";
			result += "Degree opted: " + listBox1.Text + "\n";
			result += "Majors Opted: ";

			foreach (var item in checkedListBox1.CheckedItems)
				result += item.ToString() + ", ";

			result = result.Substring(0, result.Length - 1) + ".";

			MessageBox.Show(result);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();

			label4.Text = "Degree Opted";

			listBox1.ClearSelected();
			listBox1.Visible = true;

			checkedListBox1.Items.Clear();
			this.checkedListBox1.Items.AddRange(new object[] {
					"Mathematics ",
					"Physics",
					"Chemistry",
					"Biology",
					"Accounts"
					});
		}
	}
}