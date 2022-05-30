using System.Drawing;
using System;

namespace Lab5_2_Form
{
    class Block4
    {
         Graphics g;
         Pen pen;

         public Block4(Graphics g, Pen pen)
         {
             this.g = g;
             this.pen = pen;
         }

         public void DrawEleph()
         {
            g.Clear(Color.White);
            Point[] elephStand =
            {
                 new Point(120, 100), new Point(140, 80), new Point(160, 80), new Point(170, 90), new Point(210, 90),
                 new Point(230, 110), new Point(230, 120), new Point(240, 130), new Point(240, 150),
                 new Point(230, 140), new Point(230, 190), new Point(220, 200), new Point(220, 230),
                 new Point(190, 230), new Point(190, 200), new Point(140, 200), new Point(140, 230),
                 new Point(110, 230), new Point(110, 200), new Point(90, 200), new Point(80, 190), new Point(50, 190),
                 new Point(30, 170),
                 new Point(30, 130), new Point(50, 110), new Point(60, 120), new Point(50, 130), new Point(50, 160),
                 new Point(60, 170), new Point(70, 170), new Point(80, 160), new Point(80, 130), new Point(110, 100),
                 new Point(120, 100), new Point(130, 110), new Point(130, 140), new Point(140, 150),
                 new Point(150, 150), new Point(170, 130), new Point(170, 90)
            };
             SolidBrush eye = new SolidBrush(Color.Black);
             Rectangle elephEye = new Rectangle(90, 150, 5, 5);
             g.DrawLines(pen,elephStand);
             g.FillEllipse(eye, elephEye);
         }
         public void DrawEleph1()
         {
             g.Clear(Color.White);
             Point[] elephRun =
             {
                 new Point(90, 120), new Point(90, 90), new Point(100, 80), new Point(120, 80), new Point(140, 100),
                 new Point(150, 90), new Point(210, 90),
                 new Point(230, 110), new Point(230, 120), new Point(240, 130), new Point(240, 150),
                 new Point(230, 140), new Point(230, 190), new Point(220, 200), new Point(250, 230),
                 new Point(220, 230), new Point(190, 200), new Point(140, 200), new Point(110, 230),
                 new Point(80, 230), new Point(110, 200), new Point(90, 200), new Point(80, 190), new Point(50, 190),
                 new Point(30, 170),
                 new Point(30, 130), new Point(50, 110), new Point(60, 120), new Point(50, 130), new Point(50, 160),
                 new Point(60, 170), new Point(70, 170), new Point(80, 160), new Point(80, 130), new Point(90, 120),
                 new Point(90, 130), new Point(110, 150), new Point(120, 150), new Point(130, 140),
                 new Point(130, 110), new Point(140, 100)
             };
             SolidBrush eye = new SolidBrush(Color.Black);
             Rectangle elephEye = new Rectangle(90, 150, 5, 5);
            g.DrawLines(pen, elephRun);
            g.FillEllipse(eye, elephEye);
        }
    }
}
