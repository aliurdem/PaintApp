using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal class Square : Shape
    {
        public Square(Color color) : base(color)
        {
        }

        public override void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(ShapeColor);
            g.FillRectangle(brush, X, Y, Width, Width);

        }
    }
}
