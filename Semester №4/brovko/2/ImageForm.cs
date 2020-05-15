using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class ImageForm : Form
    {
        public bool showAllPictures;
        public int imageId;
        private int previousImageSizeNumericUpDown = 0;
       
        public ImageForm()
        {
            InitializeComponent();
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            if (showAllPictures)
            {
                previousButton.Visible = true;
                nextButton.Visible = true;
                timer.Enabled = true;
            }

            pictureBox.Image = imageList.Images[imageId];
        }

        private void ImageSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (previousImageSizeNumericUpDown < (int) imageSizeNumericUpDown.Value)
            {
                pictureBox.Width++;
                pictureBox.Height++;
            }
            else
            {
                pictureBox.Width--;
                pictureBox.Height--;
            }

            previousImageSizeNumericUpDown = (int) imageSizeNumericUpDown.Value;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (imageId >= imageList.Images.Count)
                timer.Enabled = false;

            imageId = (imageId + 1) % 5;
            pictureBox.Image = imageList.Images[imageId];
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            imageId = (imageId + 1) % 5;
            pictureBox.Image = imageList.Images[imageId];
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (--imageId < 0)
                imageId = 0;

            pictureBox.Image = imageList.Images[imageId % 5];
        }
    }
}
