using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLab8_1
{
    //перечисление фигур для рисования
    public enum CurrFig
    {
        Move,
        Resize,
        Line,
        Rectangle,
        Ellipse
    }
    public partial class Form1 : Form
    {
        //Лист отображаемых фигур
        List<Figure> figures;
        //вместо Х2 и Х4 должны были быть Y1 и Y2
        int X1, X2, X3, X4;
        //выбранная фигура для рисования
        CurrFig currFig = new CurrFig();
        //Текущее перо
        Pen pen;
        //текущая добавляемая фигура 
        Figure f;
        //выбранная фигура
        Figure selectedFigure;
        //фигура выбора
        Figure selection;
        //текущее положение курсора в листе фигур
        int c = -1;


        private void LineToolStripBtn_Click(object sender, EventArgs e)
        {
            currFig = CurrFig.Line;
        }

        private void RectangleToolStripBtn_Click(object sender, EventArgs e)
        {
            currFig = CurrFig.Rectangle;
        }

        private void EllipseToolStripBtn_Click(object sender, EventArgs e)
        {
            currFig = CurrFig.Ellipse;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && currFig != CurrFig.Move && currFig != CurrFig.Resize)
            {
                X3 = e.X;
                X4 = e.Y;
                switch (currFig)
                {
                    case CurrFig.Ellipse:
                        f = new Ellipse(new Pen(pen.Color, pen.Width), X1, X2, X3, X4);
                        break;
                    case CurrFig.Rectangle:
                        f = new Rectangle(new Pen(pen.Color, pen.Width), X1, X2, X3, X4);
                        break;
                    case CurrFig.Line:
                        f = new Line(new Pen(pen.Color, pen.Width), X1, X2, X3, X4);
                        break;
                }
            }
            if(currFig == CurrFig.Move && c != -1 && e.Button == MouseButtons.Left)
            {
                int width = figures[c].X3 - figures[c].X1;
                int height = figures[c].X4 - figures[c].X2;
                figures[c].X1 = e.X;
                figures[c].X2 = e.Y;
                figures[c].X3 = e.X + width;
                figures[c].X4 = e.Y + height;
                Invalidate();
            }
            if(currFig == CurrFig.Resize && c != -1 && e.Button == MouseButtons.Left)
            {
                figures[c].X1 = e.X;
                figures[c].X2 = e.Y;
                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(currFig != CurrFig.Resize && currFig != CurrFig.Move) figures.Add(f);

            Invalidate();
        }

        private void ColorToolStripBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if(currFig != CurrFig.Move && c == -1 && currFig != CurrFig.Resize) pen.Color = colorDialog1.Color;
            else
            {
                figures[c].Pen.Color = colorDialog1.Color;
                Invalidate();
            }
        }

        private void SizeToolStripTxt_TextChanged(object sender, EventArgs e)
        {
            float size = pen.Width;
            if(float.TryParse(sizeToolStripTxt.Text, out size) && size > 0)
            {
                if(currFig != CurrFig.Move && c == -1 && currFig != CurrFig.Resize) pen.Width = size;
                else if((currFig == CurrFig.Move || currFig == CurrFig.Resize) && c != -1)
                {
                    
                    figures[c].Pen.Width = size;
                    Invalidate();
                }
            }
            if (size < 1) sizeToolStripTxt.Text = "1";
        }

        private void MoveToolStripBtn_Click(object sender, EventArgs e)
        {
            currFig = CurrFig.Move;
        }

        private void ResizeToolStripBtn_Click(object sender, EventArgs e)
        {
            currFig = CurrFig.Resize;
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //счетчик количества выбранных фигур
            int count = 0;
            //счетчик цикла
            int k = 0;
            
            if(currFig != CurrFig.Move && currFig != CurrFig.Resize)
            { 
                X1 = e.X;
                X2 = e.Y;
            }
            else
            {
                foreach(Figure f in figures)
                {
                    k++;
                    Pen p = new Pen(Color.Black, 1f);
                    p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    int x1 = f.X1, x2 = f.X2, x3 = f.X3, x4 = f.X4;
                    if (x1 > x3)
                    {
                        int t = x1;
                        x1 = x3;
                        x3 = t;
                    }
                    if(x2 > x4)
                    {
                        int t = x2;
                        x2 = x4;
                        x4 = t;
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
                    sizeToolStripTxt.Text = pen.Width.ToString();
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            foreach(Figure f in figures)
            {
                f.Draw(gr);
            }
            if (selection != null)
            {
                selection.Draw(gr);
            }
        }

        public Form1()
        {
            InitializeComponent();
            figures = new List<Figure>();
            pen = new Pen(Color.Black);
            f = new Line(pen, 0, 0, 0, 0);
        }
    }
}
