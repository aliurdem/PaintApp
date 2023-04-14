using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public class ColorRadioButton : RadioButton
    {
        public ColorRadioButton()
        {
            this.Appearance = Appearance.Button;
            Text = "";
        }

        //ColorRadioButton sınıfın kendi has OnClick özelliği üzerine tıklandığında ait olduğu Form1 türünden formun currentColor özelliğini raadioButtonıun arka plan rengili ile değiştirir 
        //ve eğer formun seçili bir nesnesi varsa üzerine tıklandığında rengin nesnesini arkaplan rengi yapar
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.CurrentColor = this.BackColor;
                if (parentForm.SelectedShape != null) 
                {
                    parentForm.SelectedShape.ShapeColor = this.BackColor;
                    parentForm.Canvas.Invalidate();
                }
            }
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            if (this.Checked)
            {
                this.FlatAppearance.BorderColor = Color.DarkGray;
            }
            else {
                this.FlatAppearance.BorderColor = Color.White;   
            }
           
        }
    }
    }

