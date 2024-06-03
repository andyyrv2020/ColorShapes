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
                int width = rnd.Next(0, 250);
                int height = rnd.Next(0, 300);
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                Pen randomPen = new Pen(new SolidBrush(randomColor), 3);
                    this.CreateGraphics().DrawRectangle(randomPen, width, height, 50, 50);
                Thread.Sleep(100);
            }
            MessageBox.Show("Completed Rectangle!");
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            rectangleThread = new Thread(threadTriangle);
            rectangleThread.Start();

            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            BackColor = randomColor;
        }
        public void threadTriangle()
        {
            for (int i = 0; i < 100; i++)
            {

                int width = random.Next(0, 250);
                int height = random.Next(0, 300);
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                Pen randomPen = new Pen(new SolidBrush(randomColor), 3);
                Graphics triangleGraphs = this.CreateGraphics();
                int sizeHeight = height + rnd.Next(50, 50);
                int sizeWidth = width + rnd.Next(10, 10);
                Point[] TrianglePoints =
                {
                new Point(Math.Max(0, width - rnd.Next(50, 50)), height),
                new Point(sizeWidth, sizeHeight),
                new Point(width, height)
            };
                triangleGraphs.DrawPolygon(randomPen, TrianglePoints);
                Thread.Sleep(1500);
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
                int width = rnd.Next(0, 250);
                int height = rnd.Next(0, 300);
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                Pen randomPen = new Pen(new SolidBrush(randomColor), 3);
                this.CreateGraphics().DrawEllipse(randomPen, width, height, 50, 50);
                Thread.Sleep(100);
            }
            MessageBox.Show("Completed Circle!");
        }

        private void ColorShapes_Load(object sender, EventArgs e)
        {
            random = new Random();   
        }


    }
}
