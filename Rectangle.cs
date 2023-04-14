using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace PaintApp
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            Type = "Rectangle";
        }
        
        public Rectangle(Color color) : base(color)
        {
            Type = "Rectangle";
        }

        public override void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(ShapeColor);
            g.FillRectangle(brush, X, Y, Width, Height);

            if (this.IsSelected) {
                SolidBrush selectedBrush = new SolidBrush(Color.FromArgb(50, Color.Green)); // 50% şeffaflıkta yeşil renk çerçeve
                g.FillRectangle(selectedBrush, X-5, Y-5, Width+10, Height+10);
            }
        }

        public override bool Contains(Point point)
        {
            return point.X >= X && point.X <= X + Width
                && point.Y >= Y && point.Y <= Y + Height;
        }
    }
}
