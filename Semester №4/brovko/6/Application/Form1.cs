using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToCalcBtn_Click(object sender, EventArgs e)
        {
            double nothing = 0;
            if(double.TryParse(textRef1.RichText, out nothing))
            {
                calculator1.Num = nothing;
            }
        }

        private void ToTxtBtn_Click(object sender, EventArgs e)
        {
            textRef1.RichText = calculator1.Num.ToString();
        }
    }
}
