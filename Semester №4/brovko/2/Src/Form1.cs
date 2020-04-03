using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                groupBox2.Visible = true;
            else
                groupBox2.Visible = false;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e){}

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 imageForm = new Form2();
            imageForm.showAllPictures = this.checkBox3.Checked;
            imageForm.imageNumber = comboBox1.SelectedIndex != -1 ? comboBox1.SelectedIndex : 0;

            imageForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
