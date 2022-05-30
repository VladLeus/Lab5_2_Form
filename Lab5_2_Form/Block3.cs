using System;
using System.Drawing;

namespace Lab5_2_Form
{
    class Block3
    {
        public int x_center;
        public int y_center;
        int radius;
        int n = 0;
        Random r = new Random();
        Graphics g;
        Pen pen;
        int height;
        int width;
        public int x_factor;
        public int y_factor;
        public int x_period;
        public int y_period;
        public int LCM;
        public Block3(Graphics g, int height, int width)
        {
            this.g = g;
            this.height = height;
            this.width = width;
            radius = r.Next(50, 100);
            x_factor = 32;
            y_factor = 32;
            x_period = 32;
            y_period = 16;
        }

        public void Animate()
        {
            g.Clear(Color.White);
            LCM = 2 * determineLCM(x_period, y_period);
            n++;
            DrawSin(n);
            g.RotateTransform(90f);
            DrawCos(n);
            g.RotateTransform(-90f);
            x_center = Convert.ToInt32(x_factor * Math.Sin((n * Math.PI / x_period)));
            y_center = Convert.ToInt32(y_factor * Math.Cos(n * Math.PI / y_period));
            g.DrawLine(new Pen(Color.Black), 0, -height / 2, 0, height / 2);
            g.DrawLine(new Pen(Color.Black), -width / 2, 0, width / 2, 0);
            g.DrawEllipse(new Pen(Color.Red, 2), x_center - radius, y_center - radius, 2 * radius, 2 * radius);
            n %= LCM;
        }
        public int determineLCM(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                int mult = num1 * i;
                if (mult % num2 == 0)
                {
                    return mult;
                }
            }
            return num1 * num2;
        }

        private void DrawCos(int n)
        {

            for (int x = -width / 2; x < width / 2; x++)
            {
                g.FillRectangle(new SolidBrush(Color.Green), x, Convert.ToInt32(y_factor * Math.Cos(x / y_factor + n * Math.PI / y_period)), 1, 1);

            }
        }
        private void DrawSin(int n)
        {

            for (int x = -width / 2; x < width / 2; x++)
            {
                g.FillRectangle(new SolidBrush(Color.Green), x, Convert.ToInt32(x_factor * Math.Sin(x / x_factor + n * Math.PI / x_period)), 1, 1);

            }

        }
    }
}
