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
            Point[] triangleUp = {new Point(170, 10), new Point(170, 30), new Point(150, 30)};
            Point[] triangleUp1 = {new Point(170, 70), new Point(170, 90), new Point(150, 70)};
            Point[] triangleUp2 = {new Point(220, 10), new Point(240, 30), new Point(220, 30), new Point(220, 10)};
            Point[] triangleUp3 = {new Point(220, 70), new Point(240, 70), new Point(220, 90), new Point(220, 70)};
            Point[] crosshairUp =
            {
                new Point(150, 40), new Point(180, 40), new Point(180, 10), new Point(210, 10), new Point(210, 40),
                new Point(240, 40), new Point(240, 60), new Point(210, 60), new Point(210, 90), new Point(180, 90),
                new Point(180, 60), new Point(150, 60)
            };
            Point[] triangledown = { new Point(170, 210), new Point(170, 230), new Point(150, 230)};
            Point[] triangledown1 = { new Point(170, 270), new Point(170, 290), new Point(150, 270)};
            Point[] triangledown2 = { new Point(220, 210), new Point(240, 230), new Point(220, 230)};
            Point[] triangledown3 = { new Point(220, 270), new Point(240, 270), new Point(220, 290)};
            Point[] crosshairDown =
            {
                new Point(150, 240), new Point(180, 240), new Point(180, 210), new Point(210, 210), new Point(210, 240),
                new Point(240, 240), new Point(240, 260), new Point(210, 260), new Point(210, 290), new Point(180, 290),
                new Point(180, 260), new Point(150, 260)
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
            Point[] triangemid = { new Point(10, 130), new Point(30, 150), new Point(10, 170) };
            Point[] triangemid1 = { new Point(60, 130), new Point(40, 150), new Point(60, 170) };
            Point[] triangemid2 = { new Point(70, 130), new Point(90, 150), new Point(70, 170) };
            Point[] triangemid3 = { new Point(120, 130), new Point(100, 150), new Point(120, 170) };
            Point[] triangemid4 = { new Point(130, 130), new Point(150, 150), new Point(130, 170) };
            Point[] triangemid5 = { new Point(180, 130), new Point(160, 150), new Point(180, 170) };
            Point[] triangemid6 = { new Point(190, 130), new Point(210, 150), new Point(190, 170) };
            Point[] triangemid7 = { new Point(240, 130), new Point(220, 150), new Point(240, 170) };
            Point[] triangemid8 = { new Point(250, 130), new Point(270, 150), new Point(250, 170) };
            Point[] triangemid9 = { new Point(300, 130), new Point(280, 150), new Point(300, 170) };
            Point[] triangemid10 = { new Point(310, 130), new Point(330, 150), new Point(310, 170) };
            Point[] triangemid11 = { new Point(360, 130), new Point(340, 150), new Point(360, 170) };
            Point[] triangemid12 = { new Point(370, 130), new Point(390, 150), new Point(370, 170) };
            SolidBrush crosshair = new SolidBrush(Color.Red);
            SolidBrush triangle = new SolidBrush(Color.Black);
            SolidBrush triangleMid = new SolidBrush(Color.Gold);
            g.FillPolygon(triangle, triangleUp);
            g.FillPolygon(triangle, triangleUp1);
            g.FillPolygon(triangle, triangleUp2);
            g.FillPolygon(triangle, triangleUp3);
            g.FillPolygon(crosshair, crosshairUp);
            g.DrawLines(pen, lineUp);
            g.DrawLines(pen, lineDown);
            g.FillPolygon(triangleMid, triangemid);
            g.FillPolygon(triangleMid, triangemid1);
            g.FillPolygon(triangleMid, triangemid2);
            g.FillPolygon(triangleMid, triangemid3);
            g.FillPolygon(triangleMid, triangemid4);
            g.FillPolygon(triangleMid, triangemid5);
            g.FillPolygon(triangleMid, triangemid6);
            g.FillPolygon(triangleMid, triangemid7);
            g.FillPolygon(triangleMid, triangemid8);
            g.FillPolygon(triangleMid, triangemid9);
            g.FillPolygon(triangleMid, triangemid10);
            g.FillPolygon(triangleMid, triangemid11);
            g.FillPolygon(triangleMid, triangemid12);
            g.FillPolygon(triangle, triangledown);
            g.FillPolygon(triangle, triangledown1);
            g.FillPolygon(triangle, triangledown2);
            g.FillPolygon(triangle, triangledown3);
            g.FillPolygon(crosshair, crosshairDown);
        }
    }
}
