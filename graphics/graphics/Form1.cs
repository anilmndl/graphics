using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // uncomment specific line as necessary

            Graphics graphics = e.Graphics;

            // points
            Point pointA = new Point(100, 50);
            Point pointB = new Point(200, 50);
            Point pointC = new Point(200, 100);
            Point pointD = new Point(100, 100);

            // array of points
            Point[] points = { pointA, pointB, pointC, pointD };

            // this is same as line 31
            //Point[] points = new Point[2];
            //points[0] = pointA;
            //points[1] = pointB;
            //points[2] = pointC;
            //points[3] = pointD;


            // pens
            Pen greenPen = new Pen(Color.Green);
            Pen thickGreenPen = new Pen(Color.Green, 5);
            Pen redPen = new Pen(Color.Red);


            // brushes
            SolidBrush orangeSolidBrush = new SolidBrush(Color.Orange);
            Brush imageBrush = new TextureBrush(Image.FromFile("../../pattern.jpg"));

            // font
            Font timesNewRoman = new Font("Times New Roman", 14);
            Font timesNewRomanBig = new Font("Times New Roman", 48);


            graphics.DrawLine(redPen, pointA, pointB);
            graphics.DrawLine(thickGreenPen, pointB, pointC);
            graphics.DrawLine(greenPen, pointC, pointD);
            graphics.DrawLine(redPen, pointD, pointA);

            graphics.DrawLines(redPen, points);
            graphics.DrawPolygon(redPen, points);

            Rectangle rectangle = new Rectangle(150, 100, 150, 75);
            Rectangle square = new Rectangle(100, 50, 150, 150);

            graphics.DrawRectangle(greenPen, rectangle);
            graphics.DrawRectangle(redPen, square);

            graphics.DrawEllipse(thickGreenPen, rectangle);
            graphics.DrawEllipse(greenPen, square);



            graphics.FillRectangle(imageBrush, rectangle);
            graphics.FillPolygon(imageBrush, points);

            graphics.DrawString("I.S.U", timesNewRomanBig, orangeSolidBrush, pointA);


            graphics.DrawArc(greenPen, square, -90, 180);
        }
    }
}
