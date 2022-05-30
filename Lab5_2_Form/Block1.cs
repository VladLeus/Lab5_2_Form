using System.Drawing;

namespace Lab5_2_Form
{
    class Block1
    {
        Graphics g;
        Pen pen;
        int h;
        int w;
        public Block1(Graphics g, Pen pen)
        {
            this.g = g;
            this.pen = pen;
        }

        public void Draw()
        {
            g.Clear(Color.White);
            Point[] parallelogram =
            {
                new Point(100, 100), new Point(160, 100), new Point(210, 100), new Point(220, 110), new Point(240, 130), new Point(250, 140), new Point(190, 140),
                new Point(140, 140), new Point(130, 130), new Point(110, 110), new Point(100, 100)
            };
            Point[] trapezoid =
            {
                new Point(280, 100), new Point(310, 100), new Point(320, 110), new Point(350, 140), new Point(360, 150),
                new Point(310, 150), new Point(280, 150), new Point(280, 100)
            };
            SolidBrush paral = new SolidBrush(Color.BlueViolet);
            SolidBrush rectan = new SolidBrush(Color.Crimson);
            Rectangle r = new Rectangle(10, 25, 120, 60);
            Rectangle rec = new Rectangle(340, 220, 120, 60);
            g.FillPolygon(paral, parallelogram);
            g.DrawPolygon(pen, trapezoid);
            g.DrawEllipse(pen, r);
            g.FillPie(rectan, rec, 0, 243);
        }
    }
}
