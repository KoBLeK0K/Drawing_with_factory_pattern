using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6Drawing
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
            
        }
        public int getHeight()
        {
            return drawingSpace.Height;
        }

        public int getWidth()
        {
            return drawingSpace.Width;
        }
        public void anglesOfMult_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
            
        }
        public void xAxis_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }

            
    }
        public void yAxis_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        public void SizeOfFigure_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Construct_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "" && xAxis.Text != "" && yAxis.Text != "" && SizeOfFigure.Text != "")
            {
                
                ShapeFactory factory = new ShapeFactory();
                Shape shapePolygon = ShapeFactory.GetShape(comboBox1.Text);

                drawingSpace.Image = shapePolygon.Draw(SizeOfFigure.Text, xAxis.Text, yAxis.Text, anglesOfMult.Text);
                label7.Text = shapePolygon.Descriptor();
                
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Многоугольник")
            {
                anglesOfMult.Enabled = true;
                
            }
            else
            {
                anglesOfMult.Clear();
                anglesOfMult.Enabled = false;
            }
        }

        private void anglesOfMult_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(anglesOfMult.Text) <= 4 )
            {
                Construct.Enabled = false;
                MessageBox.Show("Количество углов многоугольника не может быть меньше 5", "НЕВОЗМОЖНО ПОСТРОИТЬ");
                
            }
            else 
            {
                Construct.Enabled = true;
            }

        }
    }

    public class ShapeFactory
    {
        public static Shape GetShape(string figure)
        {
            switch (figure)
            {
                case "Многоугольник":
                    return new Pentagon();
                case "Квадрат":
                    return new Rectangle();
                case "Треугольник":
                    return new Triangle();
                default: return new Ellipse();
            }

        }
    }
    public abstract class Shape
    {
        public int x1;
        public int y1;

        public SolidBrush pen;
        public Pen myPen;

        public Shape()
        {
            x1 = 0;
            y1 = 0;
            pen = new SolidBrush(Color.White);
            myPen = new Pen(Color.Blue);
        }
        abstract public Image Draw(string size, string xDot, string yDot, string MultiAngles);
        abstract public string Descriptor();
    }

    class Ellipse : Shape
    {
        
        public override Image Draw(string size, string xDot, string yDot, string MultiAngles)
        {
            Form1 form1 = new Form1();

            int shapeSize = Convert.ToInt32(size);
            int x2 = Convert.ToInt32(xDot);
            int y2 = Convert.ToInt32(yDot);

            Bitmap pictureBox = new (form1.getWidth(), form1.getHeight());
            Graphics graph = Graphics.FromImage(pictureBox);
            graph.FillRectangle(pen, form1.ClientRectangle);
            graph.DrawEllipse(myPen, x1+x2 - shapeSize/2, y1+y2 - shapeSize/2, shapeSize, shapeSize);
            return pictureBox;
        }
        public override string Descriptor()
        {
            return "Circle";
        }
    }


    class Triangle : Shape
    {

        public override Image Draw(string size, string xDot, string yDot, string MultiAngles)
        {
            Form1 form1 = new Form1();

            int shapeSize = Convert.ToInt32(size);
            int x2 = Convert.ToInt32(xDot);
            int y2 = Convert.ToInt32(yDot);

            Bitmap pictureBox = new Bitmap(form1.getWidth(), form1.getHeight());
            Graphics graph = Graphics.FromImage(pictureBox);
            graph.FillRectangle(pen, form1.ClientRectangle);

            PointF p1 = new PointF(1*shapeSize + x2, 1+ y2 - shapeSize/2);
            PointF p2 = new PointF(2+ x2 - shapeSize/2, 2*shapeSize+ y2);
            PointF p3 = new PointF(2+ x2 - shapeSize/2, 1+ y2-shapeSize/2);
            PointF[] curvePoints =
            {
                p1,p2,p3
            };
            graph.DrawPolygon(myPen, curvePoints);
            return pictureBox;
        }
        public override string Descriptor()
        {
            return "Triangle";
        }
    }

    class Rectangle : Shape
    {

        public override Image Draw(string size, string xDot, string yDot, string MultiAngles)
        {
            Form1 form1 = new Form1();
            int shapeSize = Convert.ToInt32(size);
            int x2 = Convert.ToInt32(xDot);
            int y2 = Convert.ToInt32(yDot);
            Bitmap pictureBox = new Bitmap(form1.getWidth(), form1.getHeight());
            Graphics graph = Graphics.FromImage(pictureBox);
            graph.FillRectangle(pen, form1.ClientRectangle);
            graph.DrawRectangle(myPen, x1+x2 - shapeSize/2, y1+y2 - shapeSize/2, shapeSize, shapeSize);
            return pictureBox;
        }
        public override string Descriptor()
        {
            return "Rectangle";
        }
    }

    class Pentagon : Shape
    {
        public override Image Draw(string size, string xDot, string yDot, string MultiAngles)
        {

            Form1 form1 = new Form1();

            int shapeSize = Convert.ToInt32(size);
            int x2 = Convert.ToInt32(xDot);
            int y2 = Convert.ToInt32(yDot);
            int sumDots = Convert.ToInt32(MultiAngles);

            List<Point> points = new List<Point>();
            points.Clear();

            double R = shapeSize / (2 * Math.Sin(Math.PI / sumDots));

            for(double angle = 0f; angle <= 2*Math.PI; angle+=Math.PI*2/sumDots)
            {
                int x = (int)(R * Math.Cos(angle));
                int y = (int)(R * Math.Sin(angle));
                points.Add(new Point((int)R + x + x2 - shapeSize, (int)R + y + y2-shapeSize));
            }

            Bitmap pictureBox = new Bitmap(form1.getWidth(), form1.getHeight());
            Graphics graph = Graphics.FromImage(pictureBox);
            graph.FillRectangle(pen, form1.ClientRectangle);
            graph.DrawPolygon(myPen, points.ToArray());
            return pictureBox;
        }
        public override string Descriptor()
        {
            return "Graph";
        }
    }
}
