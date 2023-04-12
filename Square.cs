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
    public class Square : Shape
    {
        public Square()
        {
            Type = "Rectangle";
        }
        

        public Square(Color color) : base(color)
        {
            Type = "Rectangle";
        }

        public override void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(ShapeColor);
            g.FillRectangle(brush, X, Y, Width, Height);
            if (this.IsSelected) {
                SolidBrush selectedBrush = new SolidBrush(Color.FromArgb(50, Color.Red)); // 50% şeffaflıkta mavi renk fırça
                g.FillRectangle(selectedBrush, X-5, Y-5, Width+10, Height+10);
            }

        }

       


    }
}
