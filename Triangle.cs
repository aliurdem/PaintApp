using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PaintApp
{
    internal class Triangle : Shape
    {
        private Point[] trianglePoints = new Point[3];

        public Triangle()
        {
            Type = "Rectangle";
        }

        public Triangle(Color color) : base(color)
        {
            Type = "Triangle";
        }

        public override void Draw(Graphics g)
        {
            
            trianglePoints[0] = new Point(X, Y + Height);
            trianglePoints[1] = new Point(X + Width, Y + Height);
            trianglePoints[2] = new Point(X + (int)(Width / 2), Y);
           
            SolidBrush brush = new SolidBrush(ShapeColor);
            g.FillPolygon(brush, trianglePoints);

            if (this.IsSelected)
            {
                SolidBrush selectedBrush = new SolidBrush(Color.FromArgb(50, Color.Green)); // 50% şeffaflıkta mavi renk 
                g.FillRectangle(selectedBrush, X - 5, Y - 5, Width + 10, Height + 10);
            }

        }

        

      
    }
}
