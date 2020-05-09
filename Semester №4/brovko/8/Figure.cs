using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WFLab8_1
{
    public abstract class Figure
    {
        public int X1, X2, X3, X4;
        public Pen Pen;
        public Brush brush;

        public abstract void Draw(Graphics gr);
    }
}
