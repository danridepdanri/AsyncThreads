using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace lab24Task1
{
    public partial class Form1 : Form
    {
        private Thread thread1;
        private Thread thread2;
        private Thread thread3;

        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(DrawRect));
            thread2 = new Thread(new ThreadStart(DrawEllipse));
            thread3 = new Thread(new ThreadStart(RndNum));
        }

        private void DrawRect()
        {
            try
            {
                Random rnd = new Random();
                while (true)
                {
                    Thread.Sleep(40);
                    Invoke(new Action(() =>
                    {
                        Graphics g = panel1.CreateGraphics();
                        g.DrawRectangle(Pens.Pink, 0, 0, rnd.Next(this.Width), rnd.Next(this.Height));
                        g.Dispose();
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DrawEllipse()
        {
            try
            {
                Random rnd = new Random();
                while (true)
                {
                    Thread.Sleep(40);
                    Invoke(new Action(() =>
                    {
                        Graphics g = panel2.CreateGraphics();
                        g.DrawEllipse(Pens.Pink, 0, 0, rnd.Next(this.Width), rnd.Next(this.Height));
                        g.Dispose();
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RndNum()
        {
            try
            {
                Random rnd = new Random();
                for (int i = 0; i < 500; i++)
                {
                    Invoke(new Action(() =>
                    {
                        richTextBox1.Text += rnd.Next().ToString();
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thread2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thread3.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            thread2.Suspend();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            thread3.Suspend();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
            thread2.Suspend();
            thread3.Suspend();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }
    }
}