using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextRefactor
{
    public partial class TextRef: UserControl
    {
        public TextRef()
        {
            InitializeComponent();
        }

        public string RichText
        {
            get
            {
                return richTextBox.SelectedText;
            }
            set
            {
                richTextBox.SelectedText = value;
            }
        }

        private void LeftCorBtn_Click(object sender, EventArgs e)
        {
            richTextBox.Focus();
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CenCorBtn_Click(object sender, EventArgs e)
        {
            richTextBox.Focus();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RightCorBtn_Click(object sender, EventArgs e)
        {
            richTextBox.Focus();
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void ColourBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if(richTextBox.SelectedText.Length > 0)
            {
                richTextBox.SelectionColor = colorDialog1.Color;
            }
            else
            {
                richTextBox.ForeColor = colorDialog1.Color;
            }
        }

        private void FontBtn_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            if (richTextBox.SelectedText.Length > 0)
            {
                richTextBox.SelectionFont = fontDialog1.Font;
            }
            else
            {
                richTextBox.Font = fontDialog1.Font;
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "*.rtf";
            openFileDialog1.Filter = "RTF Files|*.rtf";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.Rtf = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.Filter = "RTF Files|*.rtf";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox.Rtf);
            }
        }
    }
}
