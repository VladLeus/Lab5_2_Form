using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2_Form
{
    class Block2
    {
        Graphics g;
        Pen pen;
        public Block2(Graphics g, Pen pen)
        {
            this.g = g;
            this.pen = pen;
        }

        public void Draw()
        {
            g.Clear(Color.White);
            Point[] triangleUp = {new Point(170, 10), new Point(170, 30), new Point(150, 30), new Point(170, 10)};
            Point[] triangleUp1 = {new Point(170, 70), new Point(170, 90), new Point(150, 70), new Point(170, 70)};
            Point[] triangleUp2 = {new Point(220, 10), new Point(240, 30), new Point(220, 30), new Point(220, 10)};
            Point[] triangleUp3 = {new Point(220, 70), new Point(240, 70), new Point(220, 90), new Point(220, 70)};
            Point[] crosshairUp =
            {
                new Point(150, 40), new Point(180, 40), new Point(180, 10), new Point(210, 10), new Point(210, 40),
                new Point(240, 40), new Point(240, 60), new Point(210, 60), new Point(210, 90), new Point(180, 90),
                new Point(180, 60), new Point(150, 60), new Point(150, 40)
            };
            Point[] triangledown = { new Point(170, 210), new Point(170, 230), new Point(150, 230), new Point(170, 210) };
            Point[] triangledown1 = { new Point(170, 270), new Point(170, 290), new Point(150, 270), new Point(170, 270) };
            Point[] triangledown2 = { new Point(220, 210), new Point(240, 230), new Point(220, 230), new Point(220, 210) };
            Point[] triangledown3 = { new Point(220, 270), new Point(240, 270), new Point(220, 290), new Point(220, 270) };
            Point[] crosshairDown =
            {
                new Point(150, 240), new Point(180, 240), new Point(180, 210), new Point(210, 210), new Point(210, 240),
                new Point(240, 240), new Point(240, 260), new Point(210, 260), new Point(210, 290), new Point(180, 290),
                new Point(180, 260), new Point(150, 260), new Point(150, 240)
            };
            Point[] lineUp =
            {
                new Point(10, 100), new Point(40, 130), new Point(70, 100), new Point(100, 130), new Point(130, 100),
                new Point(160, 130), new Point(190, 100), new Point(220, 130), new Point(250, 100), new Point(280, 130),
                new Point(310, 100), new Point(340, 130), new Point(370, 100), new Point(400, 130)
            };
            Point[] lineDown =
            {
                new Point(10, 200), new Point(40, 170), new Point(70, 200), new Point(100, 170), new Point(130, 200),
                new Point(160, 170), new Point(190, 200), new Point(220, 170), new Point(250, 200), new Point(280, 170),
                new Point(310, 200), new Point(340, 170), new Point(370, 200), new Point(400, 170)
            };
            g.DrawPolygon(pen, triangleUp);
            g.DrawPolygon(pen, triangleUp1);
            g.DrawPolygon(pen, triangleUp2);
            g.DrawPolygon(pen, triangleUp3);
            g.DrawPolygon(pen, crosshairUp);
            g.DrawLines(pen, lineUp);
            g.DrawLines(pen, lineDown);
            g.DrawPolygon(pen, triangledown);
            g.DrawPolygon(pen, triangledown1);
            g.DrawPolygon(pen, triangledown2);
            g.DrawPolygon(pen, triangledown3);
            g.DrawPolygon(pen, crosshairDown);
        }
    }
}
