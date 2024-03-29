﻿using System.Drawing;

namespace Lab_8
{
    public class Line : Figure
    {
        public Line(Pen pen, int x1, int x2, int x3, int x4)
        {
            Pen = pen;
            X1 = x1;
            X2 = x2;
            X3 = x3;
            X4 = x4;
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawLine(Pen, X1, X2, X3, X4);
        }
    }
}
