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
    public partial class Form1 : Form
    {
        public Form1()
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
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Red, 4),
                    new Rectangle(random.Next(0, this.Width),
                    new Random().Next(0, this.Height), 20, 20));

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

                int width = random.Next(0, 550);
                int height = random.Next(0, 350);
                Thread.Sleep(300);

                Graphics triangleGraphs = this.CreateGraphics();
                Pen pen = new Pen(Brushes.PaleGoldenrod);
                int sizeHeight = height + random.Next(50, 50);
                int sizeWidth = width + random.Next(50, 50);
                Point[] TrianglePoints =
                {
                    new Point(Math.Max(0, width - random.Next(50, 50)), height),
                    new Point(sizeWidth, sizeHeight),
                    new Point(width, height)
                };
                triangleGraphs.DrawPolygon(pen, TrianglePoints);
            }
        }

        private void circleButton_Click(object sender, EventArgs e)
        {

        }
        public void threadCircle()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Blue, 4),
                    new Rectangle(random.Next(0, this.Width),
                    new Random().Next(0, this.Height), 20, 20));

                Thread.Sleep(100);
            }
            MessageBox.Show("Completed Circle!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();   
        }


    }
}
