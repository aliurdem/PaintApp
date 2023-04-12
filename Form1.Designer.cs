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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelectMode = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.drawBox = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorRadioButton2 = new PaintApp.ColorRadioButton();
            this.colorRadioButton3 = new PaintApp.ColorRadioButton();
            this.radioTriangle = new PaintApp.ShapeRadioButon();
            this.radioHexagon = new PaintApp.ShapeRadioButon();
            this.radioCircle = new PaintApp.ShapeRadioButon();
            this.radioSquare = new PaintApp.ShapeRadioButon();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioTriangle);
            this.groupBox1.Controls.Add(this.radioHexagon);
            this.groupBox1.Controls.Add(this.radioCircle);
            this.groupBox1.Controls.Add(this.radioSquare);
            this.groupBox1.Location = new System.Drawing.Point(498, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSelectMode);
            this.groupBox2.Location = new System.Drawing.Point(498, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(6, 78);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(5, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.colorRadioButton2);
            this.groupBox4.Controls.Add(this.colorRadioButton3);
            this.groupBox4.Location = new System.Drawing.Point(498, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(153, 151);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // drawBox
            // 
            this.drawBox.Location = new System.Drawing.Point(1, 41);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(477, 481);
            this.drawBox.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Location = new System.Drawing.Point(505, 450);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(81, 83);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(5, 51);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(63, 26);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // colorRadioButton2
            // 
            this.colorRadioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colorRadioButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.colorRadioButton2.FlatAppearance.BorderSize = 2;
            this.colorRadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorRadioButton2.Location = new System.Drawing.Point(1, 19);
            this.colorRadioButton2.Name = "colorRadioButton2";
            this.colorRadioButton2.Size = new System.Drawing.Size(59, 40);
            this.colorRadioButton2.TabIndex = 8;
            this.colorRadioButton2.TabStop = true;
            this.colorRadioButton2.Text = "colorRadioButton2";
            this.colorRadioButton2.UseVisualStyleBackColor = false;
            // 
            // colorRadioButton3
            // 
            this.colorRadioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton3.BackColor = System.Drawing.Color.Olive;
            this.colorRadioButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.colorRadioButton3.FlatAppearance.BorderSize = 2;
            this.colorRadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorRadioButton3.Location = new System.Drawing.Point(66, 19);
            this.colorRadioButton3.Name = "colorRadioButton3";
            this.colorRadioButton3.Size = new System.Drawing.Size(50, 40);
            this.colorRadioButton3.TabIndex = 5;
            this.colorRadioButton3.TabStop = true;
            this.colorRadioButton3.UseVisualStyleBackColor = false;
            // 
            // radioTriangle
            // 
            this.radioTriangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTriangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioTriangle.FlatAppearance.BorderSize = 2;
            this.radioTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTriangle.Location = new System.Drawing.Point(87, 89);
            this.radioTriangle.Name = "radioTriangle";
            this.radioTriangle.Size = new System.Drawing.Size(71, 64);
            this.radioTriangle.TabIndex = 2;
            this.radioTriangle.TabStop = true;
            this.radioTriangle.Text = "radioTriangle";
            this.radioTriangle.UseVisualStyleBackColor = true;
            // 
            // radioHexagon
            // 
            this.radioHexagon.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioHexagon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioHexagon.FlatAppearance.BorderSize = 2;
            this.radioHexagon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioHexagon.Location = new System.Drawing.Point(82, 19);
            this.radioHexagon.Name = "radioHexagon";
            this.radioHexagon.Size = new System.Drawing.Size(71, 64);
            this.radioHexagon.TabIndex = 3;
            this.radioHexagon.TabStop = true;
            this.radioHexagon.Text = "radioHexagon";
            this.radioHexagon.UseVisualStyleBackColor = true;
            // 
            // radioCircle
            // 
            this.radioCircle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioCircle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioCircle.FlatAppearance.BorderSize = 2;
            this.radioCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioCircle.Location = new System.Drawing.Point(7, 89);
            this.radioCircle.Name = "radioCircle";
            this.radioCircle.Size = new System.Drawing.Size(71, 64);
            this.radioCircle.TabIndex = 1;
            this.radioCircle.TabStop = true;
            this.radioCircle.Text = "radioCircle";
            this.radioCircle.UseVisualStyleBackColor = true;
            // 
            // radioSquare
            // 
            this.radioSquare.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSquare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioSquare.FlatAppearance.BorderSize = 2;
            this.radioSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioSquare.Location = new System.Drawing.Point(5, 19);
            this.radioSquare.Name = "radioSquare";
            this.radioSquare.Size = new System.Drawing.Size(71, 64);
            this.radioSquare.TabIndex = 0;
            this.radioSquare.TabStop = true;
            this.radioSquare.Text = "radioSquare";
            this.radioSquare.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.drawBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectMode;
        private System.Windows.Forms.GroupBox groupBox4;
        private ColorRadioButton colorRadioButton3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel drawBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private ColorRadioButton colorRadioButton2;
        private ShapeRadioButon radioCircle;
        private ShapeRadioButon radioSquare;
        private ShapeRadioButon radioTriangle;
        private ShapeRadioButon radioHexagon;
    }
}

