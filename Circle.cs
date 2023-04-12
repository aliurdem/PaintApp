﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PaintApp
{
    internal class Circle : Shape

    {
        public Circle() 
        {
            Type = "Ellipse";

        }

        public Circle(Color color) : base(color)
        {
            Type = "Ellipse";

        }

        public override void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(ShapeColor);

            g.FillEllipse(brush, X, Y, Width,Height);
            if (this.IsSelected)
            {
                SolidBrush selectedBrush = new SolidBrush(Color.FromArgb(50, Color.Red)); // 50% şeffaflıkta mavi renk fırça
                g.FillRectangle(selectedBrush, X - 5, Y - 5, Width + 10, Height + 10);
            }
        }
       




    }
}
