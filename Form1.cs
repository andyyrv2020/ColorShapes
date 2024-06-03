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

        

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            rectangleThread = new Thread(threadRectangle);
            rectangleThread.Start();
        }
        public void threadRectangle()
        {
            for (int i = 0; i < 100; i++)
            {
                int width = random.Next(0, 250);
                int height = random.Next(0, 300);
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Red, 3), width, height, 50, 50);
                Thread.Sleep(100);
            }
            MessageBox.Show("Completed Rectangle!");
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            rectangleThread = new Thread(threadTriangle);
            rectangleThread.Start();
        }
        public void threadTriangle()
        {
            for (int i = 0; i < 100; i++)
            {

                int width = random.Next(0, 250);
                int height = random.Next(0, 300);
                Graphics triangleGraphs = this.CreateGraphics();
                Pen pen = new Pen(Brushes.Purple, 3);
                int sizeHeight = height + random.Next(50, 50);
                int sizeWidth = width + random.Next(50, 50);
                Point[] TrianglePoints =
                {
                    new Point(Math.Max(0, width - random.Next(50, 50)), height),
                    new Point(sizeWidth, sizeHeight),
                    new Point(width, height)
                };
                triangleGraphs.DrawPolygon(pen, TrianglePoints);
                Thread.Sleep(100);
            }
            MessageBox.Show("Completed Triangle!");

        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            circleThread = new Thread(threadCircle);
            circleThread.Start();
        }
        public void threadCircle()
        {
            for (int i = 0; i < 100; i++)
            {
                int width = random.Next(0, 250);
                int height = random.Next(0, 300);
                    this.CreateGraphics().DrawEllipse(
                        new Pen(Brushes.HotPink, 3), width, height, 50, 50);
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
