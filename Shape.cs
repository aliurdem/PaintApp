using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PaintApp
{
    public abstract class Shape
    {
        public string Type { get; set; }
        public int X { get; set; }
        public int Y{ get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color ShapeColor { get; set; }
        public bool IsMoving { get; set; } = false;
        public bool IsSelected { get; set; } = false;
        

        public Shape() 
        {
        }


        public Shape(Color color)
        {
            X = Y = 0;
            Height = Width = 0;
            ShapeColor = color;
        }

        // Her şeklin sahip olması gereken çizdirme fonksyonu
        public abstract void Draw(Graphics g);

        public bool Contains(Point point)
        {
            return X <= point.X && point.X <= X + Width && Y <= point.Y && point.Y <= Y + Width;
        }
        
        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void Save(XmlElement element)
        {
            element.SetAttribute("Type", Type);
            element.SetAttribute("X", X.ToString());
            element.SetAttribute("Y", Y.ToString());
            element.SetAttribute("Width", Width.ToString());
            element.SetAttribute("Height", Height.ToString());
            element.SetAttribute("Color", new ColorConverter().ConvertToString(ShapeColor));

        }

        public void Load(XmlNode node)
        {
            Type = node.Attributes["Type"].Value;
            X = int.Parse(node.Attributes["X"].Value);
            Y = int.Parse(node.Attributes["Y"].Value);
            Width = int.Parse(node.Attributes["Width"].Value);
            Height = int.Parse(node.Attributes["Height"].Value);

            string colorString = node.Attributes["Color"].Value;
            ShapeColor = (Color)new ColorConverter().ConvertFromString(colorString);

        }


    }

}
