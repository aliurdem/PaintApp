namespace PaintApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCircle = new System.Windows.Forms.RadioButton();
            this.radioSquare = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectMode = new System.Windows.Forms.Button();
            this.colorRadioButton1 = new PaintApp.ColorRadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.colorRadioButton2 = new PaintApp.ColorRadioButton();
            this.colorRadioButton3 = new PaintApp.ColorRadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCircle);
            this.groupBox1.Controls.Add(this.radioSquare);
            this.groupBox1.Location = new System.Drawing.Point(640, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioCircle
            // 
            this.radioCircle.AutoSize = true;
            this.radioCircle.Location = new System.Drawing.Point(6, 42);
            this.radioCircle.Name = "radioCircle";
            this.radioCircle.Size = new System.Drawing.Size(51, 17);
            this.radioCircle.TabIndex = 1;
            this.radioCircle.TabStop = true;
            this.radioCircle.Text = "Circle";
            this.radioCircle.UseVisualStyleBackColor = true;
            // 
            // radioSquare
            // 
            this.radioSquare.AutoSize = true;
            this.radioSquare.Location = new System.Drawing.Point(6, 19);
            this.radioSquare.Name = "radioSquare";
            this.radioSquare.Size = new System.Drawing.Size(59, 17);
            this.radioSquare.TabIndex = 0;
            this.radioSquare.TabStop = true;
            this.radioSquare.Text = "Square";
            this.radioSquare.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSelectMode);
            this.groupBox2.Location = new System.Drawing.Point(641, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnSelectMode
            // 
            this.btnSelectMode.Location = new System.Drawing.Point(6, 19);
            this.btnSelectMode.Name = "btnSelectMode";
            this.btnSelectMode.Size = new System.Drawing.Size(75, 23);
            this.btnSelectMode.TabIndex = 2;
            this.btnSelectMode.Text = "Select";
            this.btnSelectMode.UseVisualStyleBackColor = true;
            this.btnSelectMode.Click += new System.EventHandler(this.btnSelectMode_Click);
            // 
            // colorRadioButton1
            // 
            this.colorRadioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton1.AutoSize = true;
            this.colorRadioButton1.BackColor = System.Drawing.Color.Purple;
            this.colorRadioButton1.Location = new System.Drawing.Point(0, 28);
            this.colorRadioButton1.Name = "colorRadioButton1";
            this.colorRadioButton1.Size = new System.Drawing.Size(105, 23);
            this.colorRadioButton1.TabIndex = 3;
            this.colorRadioButton1.TabStop = true;
            this.colorRadioButton1.Text = "colorRadioButton1";
            this.colorRadioButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.colorRadioButton3);
            this.groupBox4.Controls.Add(this.colorRadioButton2);
            this.groupBox4.Controls.Add(this.colorRadioButton1);
            this.groupBox4.Location = new System.Drawing.Point(640, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 139);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // colorRadioButton2
            // 
            this.colorRadioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton2.AutoSize = true;
            this.colorRadioButton2.BackColor = System.Drawing.Color.Cyan;
            this.colorRadioButton2.Location = new System.Drawing.Point(0, 57);
            this.colorRadioButton2.Name = "colorRadioButton2";
            this.colorRadioButton2.Size = new System.Drawing.Size(105, 23);
            this.colorRadioButton2.TabIndex = 4;
            this.colorRadioButton2.TabStop = true;
            this.colorRadioButton2.Text = "colorRadioButton2";
            this.colorRadioButton2.UseVisualStyleBackColor = false;
            // 
            // colorRadioButton3
            // 
            this.colorRadioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton3.AutoSize = true;
            this.colorRadioButton3.BackColor = System.Drawing.Color.Olive;
            this.colorRadioButton3.Location = new System.Drawing.Point(6, 94);
            this.colorRadioButton3.Name = "colorRadioButton3";
            this.colorRadioButton3.Size = new System.Drawing.Size(105, 23);
            this.colorRadioButton3.TabIndex = 5;
            this.colorRadioButton3.TabStop = true;
            this.colorRadioButton3.Text = "colorRadioButton3";
            this.colorRadioButton3.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCircle;
        private System.Windows.Forms.RadioButton radioSquare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectMode;
        private ColorRadioButton colorRadioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private ColorRadioButton colorRadioButton3;
        private ColorRadioButton colorRadioButton2;
        private System.Windows.Forms.Button btnClear;
    }
}

