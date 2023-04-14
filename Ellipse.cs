using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PaintApp
{
    internal class Ellipse : Shape

    {
        public Ellipse() 
        {
            Type = "Ellipse";
        }

        public Ellipse(Color color) : base(color)
        {
            Type = "Ellipse";

        }

        public override void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(ShapeColor);

            g.FillEllipse(brush, X, Y, Width,Height);
            if (this.IsSelected)
            {
                SolidBrush selectedBrush = new SolidBrush(Color.FromArgb(50, Color.Green)); // 50% şeffaflıkta yeşil renk çerçeve
                g.FillRectangle(selectedBrush, X - 5, Y - 5, Width + 10, Height + 10);
            }
        }

        public override bool Contains(Point point)
        {
            float a = Width / 2;
            float b = Height / 2;
            float x = point.X - (X + Width / 2);
            float y = point.Y - (Y + Height / 2);
            float value = (float)(Math.Pow(x, 2) / Math.Pow(a, 2) + Math.Pow(y, 2) / Math.Pow(b, 2));
            return value <= 1;
        }





    }
}
