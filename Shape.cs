using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal abstract class Shape
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private Color shapeColor;

        public Shape(Color color)
        {
            X = Y = 0;
            Width = Height = 0;
            shapeColor = color;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public Color ShapeColor { get => shapeColor; set => shapeColor = value; }

        // Her şeklin sahip olması gereken çizdirme fonksyonu
        public abstract void Draw(Graphics g);
    }
}
