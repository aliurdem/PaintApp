using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PaintApp
{

    internal class Hexagon : Shape
    {
        private Point[] hexagonPoints = new Point[6];

        public Hexagon()
        {
            Type = "Hexagon";
        }
        public Hexagon(Color color) : base(color)
        {
            Type = "Hexagon";
        }
        public override void Draw(Graphics g)
        {
            hexagonPoints[0] = new Point(X + Width / 4, Y);
            hexagonPoints[1] = new Point(X + Width * 3 / 4, Y);
            hexagonPoints[2] = new Point(X + Width, Y + Height / 2);
            hexagonPoints[3] = new Point(X + Width * 3 / 4, Y + Height);
            hexagonPoints[4] = new Point(X + Width / 4, Y + Height);
            hexagonPoints[5] = new Point(X, Y + Height / 2);

            SolidBrush brush = new SolidBrush(ShapeColor);
            g.FillPolygon(brush, hexagonPoints);

            if (this.IsSelected)
            {
                int frameX = X ;
                int frameY = Y ;
                int frameWidth = Width ;
                int frameHeight = Height ;

                SolidBrush selectedBrush = new SolidBrush(Color.FromArgb(50, Color.Green)); // 50% şeffaflıkta mavi renk 
                g.FillRectangle(selectedBrush, frameX-5, frameY-5, frameWidth+10, frameHeight+10);
            }
        }

        public override bool Contains(Point point)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(hexagonPoints);

            bool result = path.IsVisible(point);

            path.Dispose();
            return result;
        }
    }
}
