using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Lab_1
{
	public class StudentEntryForm : Form
	{
		private Button saveButton;
		private Button resetButton;
		private Button exitButton;
		private Label titleLabel;
		private Label nameLabel;
		private Label addressLabel;
		private Label phoneNumberLabel;
		private Label degreeOptedLabel;
		private Label majorsOptedLabel;
		private TextBox phoneNumberTextBox;
		private TextBox addressTextBox;
		private TextBox nameTextBox;
		private ListBox degreeOptedListBox;
		private CheckedListBox checkedDegreeOptedListBox;
		private IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();

			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.saveButton = new Button();
			this.resetButton = new Button();
			this.exitButton = new Button();
			this.nameLabel = new Label();
			this.addressLabel = new Label();
			this.phoneNumberLabel = new Label();
			this.degreeOptedLabel = new Label();
			this.majorsOptedLabel = new Label();
			this.phoneNumberTextBox = new TextBox();
			this.addressTextBox = new TextBox();
			this.nameTextBox = new TextBox();
			this.degreeOptedListBox = new ListBox();
			this.checkedDegreeOptedListBox = new CheckedListBox();
			this.titleLabel = new Label();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(50, 380);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(100, 30);
			this.saveButton.TabIndex = 0;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(182, 380);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(100, 30);
			this.resetButton.TabIndex = 1;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(319, 380);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(100, 30);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.nameLabel.Location = new System.Drawing.Point(54, 94);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(81, 29);
			this.nameLabel.TabIndex = 3;
			this.nameLabel.Text = "Name";
			// 
			// addressLabel
			// 
			this.addressLabel.AutoSize = true;
			this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.addressLabel.Location = new System.Drawing.Point(54, 152);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(106, 29);
			this.addressLabel.TabIndex = 4;
			this.addressLabel.Text = "Address";
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.phoneNumberLabel.Location = new System.Drawing.Point(54, 210);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(159, 26);
			this.phoneNumberLabel.TabIndex = 5;
			this.phoneNumberLabel.Text = "Phone Number";
			// 
			// degreeOptedLabel
			// 
			this.degreeOptedLabel.AutoSize = true;
			this.degreeOptedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.degreeOptedLabel.Location = new System.Drawing.Point(54, 264);
			this.degreeOptedLabel.Name = "degreeOptedLabel";
			this.degreeOptedLabel.Size = new System.Drawing.Size(148, 26);
			this.degreeOptedLabel.TabIndex = 6;
			this.degreeOptedLabel.Text = "Degree Opted";
			// 
			// majorsOptedLabel
			// 
			this.majorsOptedLabel.AutoSize = true;
			this.majorsOptedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.majorsOptedLabel.Location = new System.Drawing.Point(54, 322);
			this.majorsOptedLabel.Name = "majorsOptedLabel";
			this.majorsOptedLabel.Size = new System.Drawing.Size(142, 26);
			this.majorsOptedLabel.TabIndex = 7;
			this.majorsOptedLabel.Text = "Majors Opted";
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Location = new System.Drawing.Point(230, 210);
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(158, 22);
			this.phoneNumberTextBox.TabIndex = 8;
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(230, 160);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(158, 22);
			this.addressTextBox.TabIndex = 9;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(230, 101);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(158, 22);
			this.nameTextBox.TabIndex = 10;
			// 
			// degreeOptedListBox
			// 
			this.degreeOptedListBox.FormattingEnabled = true;
			this.degreeOptedListBox.ItemHeight = 16;
			this.degreeOptedListBox.Items.AddRange(new object[] {
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
				"MCA"
			});
			this.degreeOptedListBox.Location = new System.Drawing.Point(230, 264);
			this.degreeOptedListBox.Name = "degreeOptedListBox";
			this.degreeOptedListBox.Size = new System.Drawing.Size(158, 36);
			this.degreeOptedListBox.TabIndex = 11;
			this.degreeOptedListBox.SelectedIndexChanged += new System.EventHandler(this.DegreeOptedListBox_SelectedIndexChanged);
			// 
			// checkedDegreeOptedListBox
			// 
			this.checkedDegreeOptedListBox.FormattingEnabled = true;
			this.checkedDegreeOptedListBox.Items.AddRange(new object[] {
				"Mathematics ",
				"Physics",
				"Chemistry",
				"Biology",
				"Accounts"});
			this.checkedDegreeOptedListBox.Location = new System.Drawing.Point(230, 322);
			this.checkedDegreeOptedListBox.Name = "checkedDegreeOptedListBox";
			this.checkedDegreeOptedListBox.Size = new System.Drawing.Size(158, 38);
			this.checkedDegreeOptedListBox.TabIndex = 12;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.titleLabel.Location = new System.Drawing.Point(82, 28);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(310, 39);
			this.titleLabel.TabIndex = 13;
			this.titleLabel.Text = "Student Enrty Form";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 434);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.checkedDegreeOptedListBox);
			this.Controls.Add(this.degreeOptedListBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.phoneNumberTextBox);
			this.Controls.Add(this.majorsOptedLabel);
			this.Controls.Add(this.degreeOptedLabel);
			this.Controls.Add(this.phoneNumberLabel);
			this.Controls.Add(this.addressLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.saveButton);
			this.Name = "StudentEntryForm";
			this.Text = "StudentEntryForm";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		public StudentEntryForm()
		{
			InitializeComponent();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void DegreeOptedListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (degreeOptedListBox.SelectedIndex >= 0 && degreeOptedListBox.SelectedIndex < 4)
			{
				checkedDegreeOptedListBox.Items.Clear();
				checkedDegreeOptedListBox.Items.AddRange(new String[] {
					"Computer Science",
					"Mechanical",
					"Electrical",
					"Electrical and Electronics",
					"Electronics and Communication",
					"Civil"
				});
			}

			if (degreeOptedListBox.SelectedIndex >= 0)
			{
				degreeOptedListBox.Visible = false;
				degreeOptedLabel.Text = "Degree opted: " + degreeOptedListBox.Text;
			}

		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			string result;

			result  = "Name: " + nameTextBox.Text;
			result += "\nAddress: " + addressTextBox.Text;
			result += "\nPhone number: " + phoneNumberTextBox.Text;
			result += "\nDegree opted: " + degreeOptedListBox.Text;
			result += "\nMajors Opted: ";

			foreach (var i in checkedDegreeOptedListBox.CheckedItems)
				result += i.ToString() + ", ";

			result = result.Substring(0, result.Length - 1) + ".";

			MessageBox.Show(result);
		}

		private void ResetButton_Click(object sender, EventArgs e)
		{
			phoneNumberTextBox.Clear();
			addressTextBox.Clear();
			nameTextBox.Clear();

			degreeOptedLabel.Text = "Degree Opted";

			degreeOptedListBox.ClearSelected();
			degreeOptedListBox.Visible = true;

			checkedDegreeOptedListBox.Items.Clear();
			this.checkedDegreeOptedListBox.Items.AddRange(new object[] {
				"Mathematics ",
				"Physics",
				"Chemistry",
				"Biology",
				"Accounts"
			});
		}
	}
}