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
    public partial class Form2 : Form
    {
        public bool showAllPictures;
        public int imageNumber;
        private int sizeValue = 0;
       

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (showAllPictures)
            {
                button2.Visible = true;
                button3.Visible = true;
                pictureBox1.Image = imageList1.Images[imageNumber];
                timer1.Enabled = true;

                return;
            }

            pictureBox1.Image = imageList1.Images[imageNumber];

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int currentValue = (int) numericUpDown1.Value;
            if (sizeValue < currentValue)
            {
                pictureBox1.Width += currentValue;
                pictureBox1.Height += currentValue;
            } else
            {
                pictureBox1.Width -= currentValue;
                pictureBox1.Height -= currentValue;
            }

            sizeValue = currentValue;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (imageNumber >= imageList1.Images.Count)
                timer1.Enabled = false;

            pictureBox1.Image = imageList1.Images[imageNumber % 5];
            imageNumber++;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ++imageNumber;
            pictureBox1.Image = imageList1.Images[imageNumber % 5];
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            --imageNumber;
            pictureBox1.Image = imageList1.Images[imageNumber % 5];
        }
    }
}
