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
        Block1 block1;
        Block2 block2;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            g = Graphics.FromImage(bitmap);
            block1 = new Block1(g, pen);
            block2 = new Block2(g, pen);
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
            g = Canvas.CreateGraphics();
        }

        private void Block4_Click(object sender, EventArgs e)
        {
            g = Canvas.CreateGraphics();
        }

    }
}
