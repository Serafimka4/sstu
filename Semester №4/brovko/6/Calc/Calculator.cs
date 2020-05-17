using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calculator: UserControl
    {
        double res = 0;

        public Calculator()
        {
            InitializeComponent();
            mathTxt.Text = res.ToString();
            resTxt.Text = "0";
        }

        public double Num
        {
            get
            {
                return Convert.ToDouble(resTxt.Text);
            }
            set
            {
                mathTxt.Text = value.ToString();
            }
        }

        private void MathBtb_Click(object sender, EventArgs e)
        {
            double result;
            
            double.TryParse(mathTxt.Text, out double n);
            
            switch (((Button) sender).Text)
            {
                case "+":
                    res += n;
                    result = res;
                    break;

                case "-":
                    res -= n;
                    result = res;
                    break;

                case "*":
                    res *= n;
                    result = res;
                    break;

                case "/":
                    res /= n;
                    result = res;
                    break;

                default:
                    result = res;
                    res = 0;
                    break;
            }

            mathTxt.Text = "0";
            resTxt.Text = result.ToString();
            mathTxt.Focus();
        }

        private void MathTxt_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(mathTxt.Text, out _))
                mathTxt.Clear();
        }
    }
}
