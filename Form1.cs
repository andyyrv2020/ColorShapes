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

        Thread th1;
        Thread th2;

        private void button1_Click(object sender, EventArgs e)
        {
            th1 = new Thread(threadred);
            th1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            th2 = new Thread(threadblue);
            th2.Start();
        }

        public void threadred()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Red, 4),
                    new Rectangle(new Random().Next(0, this.Width),
                    new Random().Next(0, this.Height), 20, 20));

                Thread.Sleep(100);
            }
            MessageBox.Show("Completed Red!");
        }

        public void threadblue()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Red, 4),
                    new Rectangle(new Random().Next(0, this.Width),
                    new Random().Next(0, this.Height), 20, 20));

                Thread.Sleep(100);
            }
            MessageBox.Show("Completed Blue!");
        }
    }
}
