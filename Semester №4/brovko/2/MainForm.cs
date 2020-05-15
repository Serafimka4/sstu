using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ByNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = byNameCheckBox.Checked;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ImageForm imageForm = new ImageForm
            {
                showAllPictures = this.allCheckBox.Checked,
                imageId = animalsByNameComboBox.SelectedIndex != -1 ? animalsByNameComboBox.SelectedIndex : 0
            };

            imageForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
