using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        private String fileName;
        private bool[] checks = new bool[6];
        protected Image image;
        public String documentContents;
        Regex regex = new Regex("[0-9]{2}.[0-9]{2}.[0-9]{4}");
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < checks.Length; i++)
            {
                checks[i] = false;
            }
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                errorProvider1.SetError(txtName, "");
                checks[0] = true;
            }
            else
            {
                errorProvider1.SetError(txtName, "error!");
            }
            enablePanel();
        }

        private void TxtAdress_Leave(object sender, EventArgs e)
        {
            if (txtAdress.Text.Length > 0)
            {
                errorProvider1.SetError(txtAdress, "");
                checks[1] = true;
            }
            else
            {
                errorProvider1.SetError(txtAdress, "error!");
            }
            enablePanel();
        }

        private void TxtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length > 0)
            {
                errorProvider1.SetError(txtTitle, "");
                checks[2] = true;
            }
            else
            {
                errorProvider1.SetError(txtTitle, "error!");
            }
            enablePanel();
        }

        private void TxtPerson_Leave(object sender, EventArgs e)
        {
            if (txtPerson.Text.Length > 0)
            {
                errorProvider1.SetError(txtPerson, "");
                checks[4] = true;
            }
            else
            {
                errorProvider1.SetError(txtPerson, "error!");
            }
            enablePanel();
        }

        private void TxtPhone_Leave(object sender, EventArgs e)
        {
            int Num;
            if (int.TryParse(txtNumber.Text, out Num))
            {
                errorProvider1.SetError(txtNumber, "");
                checks[3] = true;

            }
            else errorProvider1.SetError(txtNumber, "error!");
            enablePanel();
        }

        private void TxtDate_Leave(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            if (DateTime.TryParse(txtDate.Text, out date))
            {
                errorProvider1.SetError(txtDate, "");
                checks[5] = true;
            }
            else
            {
                txtDate.Text = DateTime.Now.ToShortDateString();
                checks[5] = true;
            }
            string str = "";
            for (int i = 0; i < checks.Length; i++)
            {
                str += i.ToString() + checks[i].ToString() + ", ";
            }
            enablePanel();
        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) this.richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.BMP;*JPG;*.GIF)|*.BMP;*JPG;*.GIF|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                image = Image.FromFile(fileName);
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) this.richTextBox1.Font = fontDialog1.Font;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(image, new Point(0, richTextBox1.Font.Height));
        }

        private void btnPrint_Click(object sender, EventArgs e)
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
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, new SolidBrush(richTextBox1.ForeColor), new Point(0, 0));
            if (openFileDialog1.FileName != "openFileDialog1")
            {
                e.Graphics.DrawImage(image, new Point(0, richTextBox1.Font.Height + 30));
            }
            else
            {
                e.Graphics.DrawImage(Image.FromFile("screevvfa74633nshot.png"), new Point(0, richTextBox1.Font.Height + 30));
            }
        }

        private void enablePanel()
        {
            int ch = 0;
            for (int i = 0; i < checks.Length; i++)
            {
                if (checks[i] == true) ch++;
            }
            if (ch == checks.Length) panel1.Enabled = true;
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, new SolidBrush(richTextBox1.ForeColor), new Point(0, 0));
        }
    }
}
