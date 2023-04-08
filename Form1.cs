using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        public int sayi = 0;

        public Color currentColor = Color.Black;

        Shape shapeToDraw = null;
        List<Shape> shapeList = new List<Shape>();

        public bool drawing = false;
        public Form1()
        {
            DoubleBuffered = true;
            InitializeComponent();
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            Paint += Form1_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioCircle.Checked)
            {
                shapeToDraw = new Circle(currentColor);
            }
            else if (radioSquare.Checked)
            {
                shapeToDraw = new Square(currentColor);
            }

            if (shapeToDraw != null)
            {
                drawing = true;
                shapeToDraw.X = e.X;
                shapeToDraw.Y = e.Y;
                Invalidate();
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                shapeToDraw.Width = e.X - shapeToDraw.X;
                shapeToDraw.Height = e.Y - shapeToDraw.Y;
                Invalidate();
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
                shapeList.Add(shapeToDraw);
                Invalidate();
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Eğer çizim işlemi yapılıyorsa o anda seçili olna şablona göre şekli çizdiren kısım  
            if (drawing == true)
                shapeToDraw.Draw(g);

            // Çizilen bütün neslerin tutulduğu shapeList nesnesinden shape türünden nesnelerin çizdirilmesini sağlayan döngü
            if (shapeList.Count != 0)
            {
                foreach (Shape shape in shapeList)
                {
                    shape.Draw(g);
                }
            }



            sayi++;
            Text = sayi.ToString();
        }


        // Select Mode butonuna tıklandığında select moda geçiş yapılır seçili Şekil ve Renk seçenekleri sıfırlanır ayrıca shapeToDraw nesnei null hale getirelerk çizim yapılmasının önüne geçilir 
        private void btnSelectMode_Click(object sender, EventArgs e)
        {
            shapeToDraw = null;
            uncheckRadioButton(groupBox1);
            uncheckRadioButton(groupBox2);

        }

        // Bir Control nesnesinin içerisinde bütün radiobuttonları Checked = false hale getiren method
        private void uncheckRadioButton(Control control) => control.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);

        //Sayfayı temizleyen method
        private void btnClear_Click(object sender, EventArgs e)
        {
            shapeList.Clear();
            Invalidate();
        }
    }
}
