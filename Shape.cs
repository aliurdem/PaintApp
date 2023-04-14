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

        // Parametre olarak alınan noktanın şekil üzerinde olup olmadığını belirleyen method
        public abstract bool Contains(Point point);
        
        //Şeklin belirtilen sınırlar içersinde hareketıini sağlar 
        public void Move(int dx, int dy,int borderRight,int borderBottom)
        {
            // Şeklin yeni koordinatlarını hesaplama
            int newX = this.X + dx;
            int newY = this.Y + dy;

            //Sınırları Kontrol etme 
            int maxX = borderRight - this.Width;
            int maxY = borderBottom - this.Height;

            //Yeni konum belirleme
            newX = Math.Max(5, Math.Min(newX, maxX));
            newY = Math.Max(5, Math.Min(newY, maxY));

            //Yeni konuma taşıma
            this.X = newX;
            this.Y = newY;
            
        }


        // Şeklin özelliklerini bir Xml elementine atar
        public void Save(XmlElement element)
        {
            element.SetAttribute("Type", Type);
            element.SetAttribute("X", X.ToString());
            element.SetAttribute("Y", Y.ToString());
            element.SetAttribute("Width", Width.ToString());
            element.SetAttribute("Height", Height.ToString());
            element.SetAttribute("Color", new ColorConverter().ConvertToString(ShapeColor));

        }

        // şekle xml elemanından gelen özellirkleri set eder 
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
