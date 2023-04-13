using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    internal class ShapeRadioButon : RadioButton
    {
        public ShapeRadioButon()
        {
            this.Appearance = Appearance.Button;
            Text = "";
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            
            Form1 parentForm = (Form1)this.FindForm();

            this.Checked = true;

            if (parentForm.selectedShape != null)
            {
                parentForm.selectedShape.IsSelected = false;
                parentForm.selectedShape = null;
            }

            parentForm.drawingMode = true;
            parentForm.Canvas.Invalidate();

        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            if (this.Checked)
            {
                this.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                this.FlatAppearance.BorderColor = Color.White;
            }

        }

    }
}
