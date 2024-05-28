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
            MessageBox.Show("Completed Red!");
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            blueThread = new Thread(threadBlue);
            blueThread.Start();
        }
        public void threadBlue()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Blue, 4),
                    new Rectangle(random.Next(0, this.Width),
                    new Random().Next(0, this.Height), 20, 20));

                Thread.Sleep(100);
            }
            MessageBox.Show("Completed Blue!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();   
        }
    }
}
