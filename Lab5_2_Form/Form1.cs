using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2_Form
{
    public partial class Form1 : Form
    {
        public Pen pen = new Pen(Color.Black, 1);
        public Graphics g;
        public Bitmap bitmap;
        Stopwatch swTimeSinceStart;
        int frameSinceStart;
        Block1 block1;
        Block2 block2;
        Block3 block3;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            g = Graphics.FromImage(bitmap);
            swTimeSinceStart = new Stopwatch();
            block1 = new Block1(g, pen);
            block2 = new Block2(g, pen);
            block3 = new Block3(g, Canvas.Height, Canvas.Width);
        }

        private void Block1_Click(object sender, EventArgs e)
        {
            Canvas.Image = bitmap;
            block1.Draw();
        }

        private void Block2_Click(object sender, EventArgs e)
        {
            Canvas.Image = bitmap;
            block2.Draw();
        }

        private void Block3_Click(object sender, EventArgs e)
        {
            swTimeSinceStart.Restart();
            timer1.Interval = Convert.ToInt32(Math.Round(1000 / FPSnumeric.Value));
            frameSinceStart = 0;
            swTimeSinceStart.Start();
            timer1.Start();
        }

        private void Block4_Click(object sender, EventArgs e)
        {
            g = Canvas.CreateGraphics();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Canvas.Image = bitmap;
            frameSinceStart++;
            double tms = swTimeSinceStart.ElapsedMilliseconds;
            label2.Text = $"time interval {timer1.Interval}\n{tms}, {frameSinceStart} frames ({Math.Round((frameSinceStart * 1000 / tms), 2)}) fps";
            label3.Text = $"LCM {block3.LCM}\nx_center {block3.x_center}\ny_center {block3.y_center}\nx_factor {block3.x_factor}\ny_factor {block3.y_factor}";
            block3.Animate();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            block3.x_factor = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            block3.y_factor = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            block3.x_period = (int)numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            block3.y_period = (int)numericUpDown4.Value;
        }
    }
}
