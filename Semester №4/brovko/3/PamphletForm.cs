using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class PamphletForm : Form
    {
        private String fileName;
        protected Image image;
        public String documentContents;

        public PamphletForm()
        {
            InitializeComponent();
        }

        private bool PhoneNumberIsCorrect()
        {
            Regex phoneNumberRegex = new Regex("\\+\\d{11,11}");
            return phoneNumberRegex.IsMatch(phoneNumberTextBox.Text);
        }

        private bool AddressIsCorrect()
        {
            return addressTextBox.Text.Length > 0;
        }

        private bool NameIsCorrect()
        {
            return nameTextBox.Text.Length > 0;
        }

        private bool ContactPersonIsCorrect()
        {
            return contactPersonTextBox.Text.Length > 0;
        }
        private bool TitleIsCorrect()
        {
            return titleTextBox.Text.Length > 0;
        }

        private bool DateIsCorrect()
        {
            return DateTime.TryParse(dateTextBox.Text, out _);
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (NameIsCorrect())
                errorProvider.SetError(nameTextBox, String.Empty);
            else
                errorProvider.SetError(nameTextBox, "Name is incorrect.");

            EnablePanel();
        }

        private void AddressTextBox_Leave(object sender, EventArgs e)
        {
            if (AddressIsCorrect())
                errorProvider.SetError(addressTextBox, String.Empty);
            else
                errorProvider.SetError(addressTextBox, "Address is incorrect.");

            EnablePanel();
        }

        private void TitleTextBox_Leave(object sender, EventArgs e)
        {
            if (TitleIsCorrect())
                errorProvider.SetError(titleTextBox, String.Empty);
            else
                errorProvider.SetError(titleTextBox, "Title is incorrect.");

            EnablePanel();
        }

        private void ContactPersonTextBox_Leave(object sender, EventArgs e)
        {
            if (ContactPersonIsCorrect())
                errorProvider.SetError(contactPersonTextBox, String.Empty);
            else
                errorProvider.SetError(contactPersonTextBox, "Contact person info is incorrect.");

            EnablePanel();
        }

        private void PhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (PhoneNumberIsCorrect())
                errorProvider.SetError(phoneNumberTextBox, String.Empty);
            else
                errorProvider.SetError(phoneNumberTextBox, "Phone number is incorrect.");

            EnablePanel();
        }

        private void DateTextBox_Leave(object sender, EventArgs e)
        {
            dateTextBox.Text = DateTime.Now.ToShortDateString();
            EnablePanel();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                this.richTextBox.ForeColor = colorDialog.Color;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files(*.BMP;*JPG;*.GIF)|*.BMP;*JPG;*.GIF|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                image = Image.FromFile(fileName);
            }
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
                this.richTextBox.Font = fontDialog.Font;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(image, new Point(0, richTextBox.Font.Height));
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printDialog = new PrintPreviewDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += PrintDocument_PrintPage;
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
                printDialog.Close();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox.Text, richTextBox.Font, new SolidBrush(richTextBox.ForeColor), new Point(0, 0));

            if (openFileDialog.FileName != "openFileDialog")
                e.Graphics.DrawImage(image, new Point(0, richTextBox.Font.Height + 30));
            else
                e.Graphics.DrawImage(Image.FromFile("screevvfa74633nshot.png"), new Point(0, richTextBox.Font.Height + 30));
        }

        private void EnablePanel()
        {
            if (NameIsCorrect()
                && AddressIsCorrect()
                && TitleIsCorrect()
                && ContactPersonIsCorrect()
                && PhoneNumberIsCorrect()
                && DateIsCorrect())
            {
                panel.Enabled = true;
            }
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox.Text, richTextBox.Font, new SolidBrush(richTextBox.ForeColor), new Point(0, 0));
        }
    }
}