using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public enum MathOperations
    {
        PLUS,
        MINUS,
        MULT,
        DIV,
        NOTHING
    }

    public partial class Calculator: UserControl
    {
        MathOperations operations = new MathOperations();
        double res = 0;

        public Calculator()
        {
            InitializeComponent();
            operations = MathOperations.NOTHING;
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
            Button btn = (Button)sender;
            double result;
            string str = btn.Text;
            double num; 
            double.TryParse(mathTxt.Text, out num);
            switch (str)
            {
                case "+":
                    res += num;
                    result = res;
                    mathTxt.Text = "0";
                    break;
                case "-":
                    res -= num;
                    result = res;
                    mathTxt.Text = "0";
                    break;
                case "*":
                    res *= num;
                    result = res;
                    mathTxt.Text = "0";
                    break;
                case "/":
                    res /= num;
                    result = res;
                    mathTxt.Text = "0";
                    break;
                default:
                    result = res;
                    res = 0;
                    mathTxt.Text = "0";
                    break;
            }
            resTxt.Text = result.ToString();
            mathTxt.Focus();
        }

        private void MathTxt_Validating(object sender, CancelEventArgs e)
        {
            double nothing;
            if(!double.TryParse(mathTxt.Text, out nothing))
            {
                mathTxt.Clear();
            }
        }
    }
}
