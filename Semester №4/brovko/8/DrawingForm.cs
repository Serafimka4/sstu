using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_8
{
    public enum Figures
    {
        Move,
        Resize,
        Line,
        Rectangle,
        Ellipse
    }
    public partial class DrawingForm : Form
    {
        List<Figure> figures;
        int X1, X2, X3, X4;
        Figures currentFigure = new Figures();
        Pen currentPen;
        Figure f;
        Figure selectedFigure;
        Figure selection;
        int c = -1;


        private void LineToolStripBtn_Click(object sender, EventArgs e)
        {
            currentFigure = Figures.Line;
        }

        private void RectangleToolStripBtn_Click(object sender, EventArgs e)
        {
            currentFigure = Figures.Rectangle;
        }

        private void EllipseToolStripBtn_Click(object sender, EventArgs e)
        {
            currentFigure = Figures.Ellipse;
        }

        private void DrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && currentFigure != Figures.Move && currentFigure != Figures.Resize)
            {
                X3 = e.X;
                X4 = e.Y;

                switch (currentFigure)
                {
                    case Figures.Ellipse:
                        f = new Ellipse(new Pen(currentPen.Color, currentPen.Width), X1, X2, X3, X4);
                        break;
                    case Figures.Rectangle:
                        f = new Rectangle(new Pen(currentPen.Color, currentPen.Width), X1, X2, X3, X4);
                        break;
                    case Figures.Line:
                        f = new Line(new Pen(currentPen.Color, currentPen.Width), X1, X2, X3, X4);
                        break;
                }
            }

            if (currentFigure == Figures.Move && c != -1 && e.Button == MouseButtons.Left)
            {
                int width = figures[c].X3 - figures[c].X1;
                int height = figures[c].X4 - figures[c].X2;
                
                figures[c].X1 = e.X;
                figures[c].X2 = e.Y;
                figures[c].X3 = e.X + width;
                figures[c].X4 = e.Y + height;
                
                Invalidate();
            }

            if (currentFigure == Figures.Resize && c != -1 && e.Button == MouseButtons.Left)
            {
                figures[c].X1 = e.X;
                figures[c].X2 = e.Y;
                
                Invalidate();
            }
        }

        private void DrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentFigure != Figures.Resize && currentFigure != Figures.Move)
                figures.Add(f);

            Invalidate();
        }

        private void ColorToolStripBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            if (currentFigure != Figures.Move && c == -1 && currentFigure != Figures.Resize)
            {
                currentPen.Color = colorDialog1.Color;
            }
            else
            {
                figures[c].Pen.Color = colorDialog1.Color;
                Invalidate();
            }
        }

        private void SizeToolStripTxt_TextChanged(object sender, EventArgs e)
        {
            float size = currentPen.Width;
            
            if (float.TryParse(sizeToolStripTxt.Text, out size) && size > 0)
            {
                if (currentFigure != Figures.Move && c == -1 && currentFigure != Figures.Resize)
                {
                    currentPen.Width = size;
                }
                else if ((currentFigure == Figures.Move || currentFigure == Figures.Resize) && c != -1)
                {
                    figures[c].Pen.Width = size;
                    Invalidate();
                }
            }

            if (size < 1)
                sizeToolStripTxt.Text = "1";
        }

        private void MoveToolStripBtn_Click(object sender, EventArgs e)
        {
            currentFigure = Figures.Move;
        }

        private void ResizeToolStripBtn_Click(object sender, EventArgs e)
        {
            currentFigure = Figures.Resize;
        }

        private void DeleteToolStripBtn_Click(object sender, EventArgs e)
        {
            if (c != -1)
            {
                figures.RemoveAt(c);
                c = -1;
                selectedFigure = null;
                selection = null;
                Invalidate();
            }
        }

        private void DrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            int count = 0;
            int k = 0;
            
            if (currentFigure != Figures.Move && currentFigure != Figures.Resize)
            { 
                X1 = e.X;
                X2 = e.Y;
            }
            else
            {
                foreach(Figure f in figures)
                {
                    k++;

                    Pen p = new Pen(Color.Black, 1f)
                    {
                        DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
                    };

                    int x1 = f.X1;
                    int x2 = f.X2;
                    int x3 = f.X3;
                    int x4 = f.X4;

                    if (x1 > x3)
                    {
                        int temp = x1;
                        x1 = x3;
                        x3 = temp;
                    }

                    if (x2 > x4)
                    {
                        int temp = x2;
                        x2 = x4;
                        x4 = temp;
                    }

                    Rectangle r = new Rectangle(p, x1, x2, x3, x4);

                    if (e.X > r.X1 && e.X < r.X3 && e.Y > r.X2 && e.Y < r.X4)
                    {
                        c = k - 1;
                        count++;
                        selectedFigure = f;
                        selection = r;
                        Invalidate();
                        sizeToolStripTxt.Text = f.Pen.Width.ToString();
                    }
                }

                if (count == 0)
                {
                    selection = null;
                    selectedFigure = null;
                    c = -1;
                    sizeToolStripTxt.Text = currentPen.Width.ToString();
                }
            }
        }

        private void DrawingForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach(Figure f in figures)
                f.Draw(g);
            
            if (selection != null)
                selection.Draw(g);
        }

        public DrawingForm()
        {
            InitializeComponent();

            figures = new List<Figure>();
            currentPen = new Pen(Color.Black);
            f = new Line(currentPen, 0, 0, 0, 0);
        }
    }
}
