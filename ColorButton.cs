using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    internal class ColorButton : Button
    {
        public ColorButton()
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
    }
}
