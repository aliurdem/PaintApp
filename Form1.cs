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
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        public Panel Canvas;
        public List<Shape> shapeList = new List<Shape>();

        public Shape currentTemplate;
        public Color currentColor = Color.Black;
        public Shape shapeToDraw = null;
        public Shape selectedShape = null;
        public int canvasRight;
        public int canvasBottom;
        public RadioButton rbtnShapeToShine;
        public RadioButton rbtnColorToShie;


        private Point lastLocation = Point.Empty;

        public bool drawing = false;
        public bool movingShape = false;
        public bool drawingMode = false;
        public Form1()
        {
            
            
            InitializeComponent();

            Canvas = drawBox;
            // 9 değerleri border payı olarak çıkartırlmıştır
            canvasRight = Canvas.Width - 7;
            canvasBottom = Canvas.Height - 7;

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

            if (drawingMode) {
                if (selectedShape != null) {
                    selectedShape.IsSelected = false;
                    selectedShape = null;
                }

                if (radioEllipse.Checked)
                {
                    shapeToDraw = new Ellipse(currentColor);
                }
                else if (radioRectangle.Checked)
                {
                    shapeToDraw = new Rectangle(currentColor);
                }
                else if (radioTriangle.Checked)
                {
                    shapeToDraw = new Triangle(currentColor);
                }
                else if (radioHexagon.Checked)
                {
                    shapeToDraw = new Hexagon(currentColor);
                }

                if (shapeToDraw != null)
                {
                    drawing = true;
                    shapeToDraw.X = e.X;
                    shapeToDraw.Y = e.Y;
                    drawBox.Invalidate();
                }

            }

            // eğer ekran üzerinde tıklanan nokta bir şekil üzerinde ise o şekli selectedShape olarak tanımlar
            // not eğer tıklanan nokta iki nesninde sınırları içersinde ise üstte olan selectedShape olarak tanımlanır
            else
            {
                //Tıklanan noktanın seçili şekil üzerinde olup olmadığı sorgusu 
                if (selectedShape != null && selectedShape.Contains(e.Location) != true)
                {
                    selectedShape.IsSelected = false;
                    selectedShape = null;
                   
                }
                foreach (Shape shape in shapeList)
                {
                    if (shape.Contains(e.Location))
                    {
                        // Önceki selectedShapein selected özelliği false yapar ve etrafındaki çerçeve gider
                        if (selectedShape != null)
                        {
                            selectedShape.IsSelected = false;
                        }
                        selectedShape = shape;
                        lastLocation = e.Location;
                    }
                }
                if (selectedShape != null)
                {
                    selectedShape.IsMoving = true;
                    selectedShape.IsSelected = true;
                }

                Canvas.Invalidate();
            }
        }

        private void DrawBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                int maxWidth = canvasRight - shapeToDraw.X;
                int maxHeight = canvasBottom - shapeToDraw.Y;

                int width = Math.Abs(e.X - shapeToDraw.X);
                int height = Math.Abs(e.Y - shapeToDraw.Y);
                
                if (width > maxWidth)
                {
                    width = maxWidth;
                }
                if (height > maxHeight)
                {
                    height = maxHeight;
                }

                shapeToDraw.Width = width;
                shapeToDraw.Height = height;

                Canvas.Invalidate();
            }
            //Seçili nesne var ise ve mouse sağ click basılı tutuluyor ise nesnenin konumu mouse harekti ile değiştilir
            else if (selectedShape != null && selectedShape.IsMoving)
            {
                int dx = e.Location.X - lastLocation.X;
                int dy = e.Location.Y - lastLocation.Y;

                // Şeklin yeni koordinatlarını hesaplama
                int newX = selectedShape.X + dx;
                int newY = selectedShape.Y + dy;

                // Şeklin sınırlarını kontrol etme ve yeni konuma taşıma
                checkBorders(selectedShape, newX, newY);

                lastLocation = e.Location;
                Canvas.Invalidate();
            }
        }

        private void DrawBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
                shapeList.Add(shapeToDraw);
                drawBox.Invalidate();
            }
            // seçili nesne varsa mouse sağ tık bırakıldığında seçili nesnenin hareket işlemi sonlandırır
            if (selectedShape != null && selectedShape.IsMoving)
            {
                selectedShape.IsMoving = false;
            }
        }

        private void DrawBox_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            //Eğer çizim işlemi yapılıyorsa o anda seçili olan şablona göre şekli çizdiren kısım  
            if (shapeToDraw != null)
                shapeToDraw.Draw(g);

           
            // Çizilen bütün neslerin tutulduğu shapeList nesnesinden shape türünden nesnelerin çizdirilmesini sağlayan döngü
            if (shapeList.Count != 0)
            {
                foreach (Shape shape in shapeList)
                {
                    shape.Draw(g);
                    
                    if (shape.IsSelected) {
                        string Type = selectedShape.Type;

                        foreach (ColorRadioButton Crbtn in colorBox.Controls.OfType<ColorRadioButton>().ToList())
                        {
                            if (selectedShape.ShapeColor == (Color)Crbtn.BackColor)
                            {
                                Crbtn.Checked = true;

                            }
                        }

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
                        
                    }
                }
            }
        }

        // Select Mode butonuna tıklandığında select moda geçiş yapılır seçili Şekil ve Renk seçenekleri sıfırlanır ayrıca shapeToDraw nesnei null hale getirelerk çizim yapılmasının önüne geçilir 
        private void btnSelectMode_Click(object sender, EventArgs e)
        {
            drawingMode = false;
            drawing = false;
            shapeToDraw = null;
            uncheckRadioButton(shapeBox);
            uncheckRadioButton(colorBox);

        }

        // Bir Control nesnesinin içerisinde bütün radiobuttonları Checked = false hale getiren method
        private void uncheckRadioButton(Control control) => control.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);

        //Sayfayı temizleyen method
        private void btnClear_Click(object sender, EventArgs e)
        {
            shapeList.Clear();
            shapeToDraw = null;
            uncheckRadioButton(shapeBox);
            uncheckRadioButton(colorBox);
            Canvas.Invalidate();
        }

        //Seçili nesneyi silen method
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                shapeList.Remove(selectedShape);
                uncheckRadioButton(shapeBox);
                uncheckRadioButton(colorBox);
                drawBox.Invalidate();
            }
        }

        //Şekle yeni atacan sınırları kontrol eden ve uygun konuma taşıyan method
        private void checkBorders(Shape shape, int newX, int newY)
        {
            //Sınırları Kontrol etme 
            int maxX = canvasRight - selectedShape.Width;
            int maxY = canvasBottom - selectedShape.Height;

            //Yeni konum belirleme
            newX = Math.Max(5, Math.Min(newX, maxX));
            newY = Math.Max(5, Math.Min(newY, maxY));

            //Yeni konuma taşıma
            selectedShape.X = newX;
            selectedShape.Y = newY;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Çizimleri bir XmlDocument nesnesine kaydetme
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("drawings");
                xmlDoc.AppendChild(root);

                foreach (Shape shape in shapeList)
                {
                    XmlElement shapeElement = xmlDoc.CreateElement(shape.Type);
                    shape.Save(shapeElement);
                    root.AppendChild(shapeElement);
                }

                xmlDoc.Save(filePath);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            shapeList.Clear();
            shapeToDraw = null; 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // XmlDocument nesnesinden çizimleri yükleme
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNodeList shapeNodes = xmlDoc.SelectNodes("/drawings/*");
                foreach (XmlNode shapeNode in shapeNodes)
                {
                    Shape shape = null;
                    switch (shapeNode.Name)
                    {
                        case "Rectangle":
                            shape = new Rectangle(currentColor);
                            break;
                        case "Ellipse":
                            shape = new Ellipse(currentColor);
                            break;
                        case "Triangle":
                            shape = new Triangle(currentColor);
                            break;
                        case "Hexagon":
                            shape = new Hexagon(currentColor);
                            break;
                    }
                    shape.Load(shapeNode);
                    shapeList.Add(shape);
                }

                Canvas.Invalidate();
            }
        }

    }


}
    


