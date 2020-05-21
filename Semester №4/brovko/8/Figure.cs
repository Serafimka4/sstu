using System.Drawing;

namespace Lab_8
{
    public abstract class Figure
    {
        public int X1, X2, X3, X4;
        public Pen Pen;
        public Brush brush;

        public abstract void Draw(Graphics gr);
    }
}
