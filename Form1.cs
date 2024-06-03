using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ColorShapes
{
    public partial class ColorShapes : Form
    {
        public ColorShapes()
        {
            InitializeComponent();
        }

        Thread rectangleThread;
        Thread triangleThread;
        Thread circleThread;

        Random random;
        private Random rnd = new Random();

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            rectangleThread = new Thread(threadRectangle);
            rectangleThread.Start();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            BackColor = randomColor;
        }

        public void threadRectangle()
        {
            for (int i = 0; i < 100; i++)
            {
                int x = rnd.Next(0, 250);
                int y = rnd.Next(0, 300);
                int width = rnd.Next(10, 100); 
                int height = rnd.Next(10, 100); 
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                Pen randomPen = new Pen(new SolidBrush(randomColor), 3);
                this.CreateGraphics().DrawRectangle(randomPen, x, y, width, height);
                Thread.Sleep(1000);
            }
            MessageBox.Show("Completed Rectangle!");
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            triangleThread = new Thread(threadTriangle);
            triangleThread.Start();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            BackColor = randomColor;
        }

        public void threadTriangle()
        {
            for (int i = 0; i < 100; i++)
            {
                int x1 = rnd.Next(0, 250);
                int y1 = rnd.Next(0, 300);
                int x2 = x1 + rnd.Next(10, 100);
                int y2 = y1 + rnd.Next(10, 100); 
                int x3 = x1 + rnd.Next(10, 100);
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                Pen randomPen = new Pen(new SolidBrush(randomColor), 3);
                Point[] TrianglePoints =
                {
                    new Point(x1, y1),
                    new Point(x2, y2),
                    new Point(x3, y1)
                };
                this.CreateGraphics().DrawPolygon(randomPen, TrianglePoints);
                Thread.Sleep(1000);
            }
            MessageBox.Show("Completed Triangle!");
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            circleThread = new Thread(threadCircle);
            circleThread.Start();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            BackColor = randomColor;
        }

        public void threadCircle()
        {
            for (int i = 0; i < 100; i++)
            {
                int x = rnd.Next(0, 250);
                int y = rnd.Next(0, 300);
                int diameter = rnd.Next(10, 100); 
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                Pen randomPen = new Pen(new SolidBrush(randomColor), 3);
                this.CreateGraphics().DrawEllipse(randomPen, x, y, diameter, diameter);
                Thread.Sleep(1000);
            }
            MessageBox.Show("Completed Circle!");
        }

        private void ColorShapes_Load(object sender, EventArgs e)
        {
            random = new Random();
        }
    }
}
