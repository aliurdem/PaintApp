using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    internal class ShapeRadioButton : RadioButton
    {
        public ShapeRadioButton()
        {
            this.Text = "";
        }

        protected override void OnClick(EventArgs e)
        {

            base.OnClick(e);

            // ColorButton sınfının kendine has özelliği dahil olduğu paint sınıfından bir form nesnesinin currentColor özelliğini değiştirir kendi background coloru ile değiştirir
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.currentColor = this.BackColor;
            }
        }

        public void Shine() { 
            this.FlatAppearance.BorderSize = 2;
            this.FlatAppearance.BorderColor = Color.Red;
        }
        public void Dark() {
            this.FlatAppearance.BorderSize = 2;
            this.FlatAppearance.BorderColor = Color.Red;
        }
    }
}
