using System;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToCalcBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textRef1.RichText, out double d))
                calculator1.Num = d;
        }

        private void ToTxtBtn_Click(object sender, EventArgs e)
        {
            textRef1.RichText = calculator1.Num.ToString();
        }
    }
}
