using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace PaintApp
{
    public partial class Form1 : Form
    {
        public Panel Canvas { get; set; }

        public List<Shape> ShapeList { get; set; } = new List<Shape>();

        public Shape ShapeToDraw { get; set; } = null;
        public Shape SelectedShape { get; set; } = null;

        public Color CurrentColor { get; set; } = Color.Black;

        public int CanvasRight { get; set; }
        public int CanvasBottom { get; set; }



        private Point lastLocation = Point.Empty;

        public bool drawing = false;
        public bool drawingMode = false;

        public Form1()
        {
            InitializeComponent();
            
            Canvas = drawBox;

            // 9 değerleri border payı olarak çıkartırlmıştır
            CanvasRight = Canvas.Width - 7;
            CanvasBottom = Canvas.Height - 7;

            // Drawboxu DoubleBuffered yapmak için gerekli olan kod 
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, Canvas, new object[] { true });
            Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            
            Canvas.MouseDown += DrawBox_MouseDown;
            Canvas.MouseUp += DrawBox_MouseUp;
            Canvas.MouseMove += DrawBox_MouseMove;
            Canvas.Paint += DrawBox_Paint;

        }

        private void DrawBox_MouseDown(object sender, MouseEventArgs e)
        {

            if (drawingMode)
            {
                if (SelectedShape != null)
                {
                    SelectedShape.IsSelected = false;
                    SelectedShape = null;
                }

                if (radioEllipse.Checked)
                {
                    ShapeToDraw = new Ellipse(CurrentColor);
                }
                else if (radioRectangle.Checked)
                {
                    ShapeToDraw = new Rectangle(CurrentColor);
                }
                else if (radioTriangle.Checked)
                {
                    ShapeToDraw = new Triangle(CurrentColor);
                }
                else if (radioHexagon.Checked)
                {
                    ShapeToDraw = new Hexagon(CurrentColor);
                }

                if (ShapeToDraw != null)
                {
                    drawing = true;
                    ShapeToDraw.X = e.X;
                    ShapeToDraw.Y = e.Y;
                    drawBox.Invalidate();
                }

            }

            // eğer ekran üzerinde tıklanan nokta bir şekil üzerinde ise o şekli selectedShape olarak tanımlar
            // not eğer tıklanan nokta iki nesninde sınırları içersinde ise üstte olan selectedShape olarak tanımlanır
            else
            {
                //Tıklanan noktanın seçili şekil üzerinde olup olmadığı sorgusu 
                if (SelectedShape != null && SelectedShape.Contains(e.Location) != true)
                {
                    SelectedShape.IsSelected = false;
                    SelectedShape = null;
                    uncheckRadioButton(shapeBox);
                    uncheckRadioButton(colorBox); 
                }
                foreach (Shape shape in ShapeList)
                {
                    if (shape.Contains(e.Location))
                    {
                        // Önceki selectedShapein selected özelliği false yapar ve etrafındaki çerçeve gider
                        if (SelectedShape != null)
                        {
                            SelectedShape.IsSelected = false;
                        }
                        SelectedShape = shape;
                        lastLocation = e.Location;
                    }
                }

                if (SelectedShape != null)
                {
                    SelectedShape.IsMoving = true;
                    SelectedShape.IsSelected = true;
                }

                Canvas.Invalidate();
            }
        }

        private void DrawBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                int maxWidth = CanvasRight - ShapeToDraw.X;
                int maxHeight = CanvasBottom - ShapeToDraw.Y;

                int width = Math.Abs(e.X - ShapeToDraw.X);
                int height = Math.Abs(e.Y - ShapeToDraw.Y);

                if (width > maxWidth)
                {
                    width = maxWidth;
                }
                if (height > maxHeight)
                {
                    height = maxHeight;
                }

                ShapeToDraw.Width = width;
                ShapeToDraw.Height = height;

                Canvas.Invalidate();
            }
            //Seçili nesne var ise ve mouse sağ click basılı tutuluyor ise nesnenin konumu mouse harekti ile değiştilir
            else if (SelectedShape != null && SelectedShape.IsMoving)
            {
                int dx = e.Location.X - lastLocation.X;
                int dy = e.Location.Y - lastLocation.Y;

                SelectedShape.Move(dx, dy, CanvasRight, CanvasBottom);
                
                lastLocation = e.Location;
                Canvas.Invalidate();
            }
        }

        private void DrawBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
                ShapeList.Add(ShapeToDraw);
                drawBox.Invalidate();
            }
            // seçili nesne varsa mouse sağ tık bırakıldığında seçili nesnenin hareket işlemi sonlandırır
            if (SelectedShape != null && SelectedShape.IsMoving)
            {
                SelectedShape.IsMoving = false;
            }
        }

        private void DrawBox_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            //Eğer çizim işlemi yapılıyorsa o anda seçili olan şablona göre şekli çizdiren kısım  
            if (ShapeToDraw != null)
                ShapeToDraw.Draw(g);


            // Çizilen bütün neslerin tutulduğu shapeList nesnesinden shape türünden nesnelerin çizdirilmesini sağlayan döngü ayrcıa seçili şeklin özelliklerini işareteyen yapı
            if (ShapeList.Count != 0)
            {
                foreach (Shape shape in ShapeList)
                {
                    shape.Draw(g);

                    if (shape.IsSelected)
                    {
                        string Type = SelectedShape.Type;

                        switch (Type)
                        {
                            case "Rectangle":
                                radioRectangle.Checked = true;
                                break;
                            case "Ellipse":
                                radioEllipse.Checked = true;
                                break;
                            case "Triangle":
                                radioTriangle.Checked = true;
                                break;
                            case "Hexagon":
                                radioHexagon.Checked = true;
                                break;

                        }

                        foreach (ColorRadioButton Crbtn in colorBox.Controls.OfType<ColorRadioButton>().ToList())
                        {
                            if (SelectedShape.ShapeColor == (Color)Crbtn.BackColor)
                            {
                                Crbtn.Checked = true;
                            }
                        }

                    }
                }
            }
        }

        // Select Mode butonuna tıklandığında select moda geçiş yapılır seçili Şekil ve Renk seçenekleri sıfırlanır ayrıca shapeToDraw nesnei null hale getirelerk çizim yapılmasının önüne geçilir 
        private void btnSelectMode_Click(object sender, EventArgs e)
        {
            drawingMode = false;
            drawing = false;
            ShapeToDraw = null;
            uncheckRadioButton(shapeBox);
            uncheckRadioButton(colorBox);

        }

        // Bir Control nesnesinin içerisinde bütün radiobuttonları Checked = false hale getiren method
        private void uncheckRadioButton(Control control) => control.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);

        //Sayfayı temizleyen method
        private void btnClear_Click(object sender, EventArgs e)
        {
            ShapeList.Clear();
            ShapeToDraw = null;
            uncheckRadioButton(shapeBox);
            uncheckRadioButton(colorBox);
            Canvas.Invalidate();
        }

        //Seçili nesneyi silen method
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (SelectedShape != null)
            {
                ShapeList.Remove(SelectedShape);
                uncheckRadioButton(shapeBox);
                uncheckRadioButton(colorBox);
                drawBox.Invalidate();
            }
        }
        
        //Canvasin içeriğini kaydeder
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Çizimleri bir XmlDocument nesnesine kaydetme
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("shape");
                xmlDoc.AppendChild(root);

                foreach (Shape shape in ShapeList)
                {
                    XmlElement shapeElement = xmlDoc.CreateElement(shape.Type);
                    shape.Save(shapeElement);
                    root.AppendChild(shapeElement);
                }

                xmlDoc.Save(filePath);
            }
        }

        // Seçilen bir doyasadan gelen canvası yükelr 
        private void btnOpen_Click(object sender, EventArgs e)
        {
            ShapeList.Clear();
            ShapeToDraw = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // XmlDocument nesnesinden çizimleri yükleme
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNodeList shapeNodes = xmlDoc.SelectNodes("/shape/*");
                foreach (XmlNode shapeNode in shapeNodes)
                {
                    Shape shape = null;
                    switch (shapeNode.Name)
                    {
                        case "Rectangle":
                            shape = new Rectangle();
                            break;
                        case "Ellipse":
                            shape = new Ellipse();
                            break;
                        case "Triangle":
                            shape = new Triangle();
                            break;
                        case "Hexagon":
                            shape = new Hexagon();
                            break;
                    }
                    shape.Load(shapeNode);
                    ShapeList.Add(shape);
                }

                Canvas.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

       


}
    


