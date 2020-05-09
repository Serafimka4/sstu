using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WFLab8_1
{
    class Ellipse : Figure
    {
        public Ellipse(Pen pen, int x1, int x2, int x3, int x4)
        {
            Pen = pen;
            if (x1 > x3)
            {
                int t = x1;
                x1 = x3;
                x3 = t;
            }
            if (x2 > x4)
            {
                int t = x2;
                x2 = x4;
                x4 = t;
            }
            X1 = x1;
            X2 = x2;
            X3 = x3;
            X4 = x4;
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(Pen, X1, X2, X3 - X1, X4 - X2);
        }
    }
}
