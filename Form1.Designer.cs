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
            this.drawBox = new System.Windows.Forms.Panel();
            this.fıleBox = new System.Windows.Forms.GroupBox();
            this.shapeBox = new System.Windows.Forms.GroupBox();
            this.colorBox = new System.Windows.Forms.GroupBox();
            this.shapeOperataionBox = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelectMode = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.colorRadioButton11 = new PaintApp.ColorRadioButton();
            this.colorRadioButton5 = new PaintApp.ColorRadioButton();
            this.colorRadioButton9 = new PaintApp.ColorRadioButton();
            this.colorRadioButton1 = new PaintApp.ColorRadioButton();
            this.colorRadioButton8 = new PaintApp.ColorRadioButton();
            this.colorRadioButton6 = new PaintApp.ColorRadioButton();
            this.colorRadioButton3 = new PaintApp.ColorRadioButton();
            this.colorRadioButton4 = new PaintApp.ColorRadioButton();
            this.colorRadioButton7 = new PaintApp.ColorRadioButton();
            this.radioEllipse = new PaintApp.ShapeRadioButon();
            this.radioTriangle = new PaintApp.ShapeRadioButon();
            this.radioRectangle = new PaintApp.ShapeRadioButon();
            this.radioHexagon = new PaintApp.ShapeRadioButon();
            this.fıleBox.SuspendLayout();
            this.shapeBox.SuspendLayout();
            this.colorBox.SuspendLayout();
            this.shapeOperataionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawBox
            // 
            this.drawBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawBox.Location = new System.Drawing.Point(0, 0);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(1407, 894);
            this.drawBox.TabIndex = 7;
            // 
            // fıleBox
            // 
            this.fıleBox.Controls.Add(this.btnOpen);
            this.fıleBox.Controls.Add(this.btnSave);
            this.fıleBox.Location = new System.Drawing.Point(1419, 596);
            this.fıleBox.Name = "fıleBox";
            this.fıleBox.Size = new System.Drawing.Size(208, 93);
            this.fıleBox.TabIndex = 8;
            this.fıleBox.TabStop = false;
            this.fıleBox.Text = "DOSYA İŞLEMLERİ";
            // 
            // shapeBox
            // 
            this.shapeBox.Controls.Add(this.radioEllipse);
            this.shapeBox.Controls.Add(this.radioTriangle);
            this.shapeBox.Controls.Add(this.radioRectangle);
            this.shapeBox.Controls.Add(this.radioHexagon);
            this.shapeBox.Location = new System.Drawing.Point(1419, 10);
            this.shapeBox.Name = "shapeBox";
            this.shapeBox.Size = new System.Drawing.Size(211, 221);
            this.shapeBox.TabIndex = 9;
            this.shapeBox.TabStop = false;
            this.shapeBox.Text = "Çizim Şekli";
            // 
            // colorBox
            // 
            this.colorBox.Controls.Add(this.colorRadioButton11);
            this.colorBox.Controls.Add(this.colorRadioButton5);
            this.colorBox.Controls.Add(this.colorRadioButton9);
            this.colorBox.Controls.Add(this.colorRadioButton1);
            this.colorBox.Controls.Add(this.colorRadioButton8);
            this.colorBox.Controls.Add(this.colorRadioButton6);
            this.colorBox.Controls.Add(this.colorRadioButton3);
            this.colorBox.Controls.Add(this.colorRadioButton4);
            this.colorBox.Controls.Add(this.colorRadioButton7);
            this.colorBox.Location = new System.Drawing.Point(1419, 239);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(211, 237);
            this.colorBox.TabIndex = 17;
            this.colorBox.TabStop = false;
            this.colorBox.Text = "RENK SEÇİMİ";
            // 
            // shapeOperataionBox
            // 
            this.shapeOperataionBox.Controls.Add(this.btnSelectMode);
            this.shapeOperataionBox.Controls.Add(this.btnClear);
            this.shapeOperataionBox.Controls.Add(this.btnDel);
            this.shapeOperataionBox.Location = new System.Drawing.Point(1419, 482);
            this.shapeOperataionBox.Name = "shapeOperataionBox";
            this.shapeOperataionBox.Size = new System.Drawing.Size(211, 108);
            this.shapeOperataionBox.TabIndex = 5;
            this.shapeOperataionBox.TabStop = false;
            this.shapeOperataionBox.Text = "ŞEKİL İŞLEMLERİ";
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = global::PaintApp.Properties.Resources.Documents_icon__1__Small;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(74, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(63, 61);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::PaintApp.Properties.Resources.floppy_drive_3_12_icon_SMALL;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(6, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 61);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectMode
            // 
            this.btnSelectMode.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectMode.BackgroundImage = global::PaintApp.Properties.Resources.Hands_One_Finger_icon_Small;
            this.btnSelectMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelectMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelectMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMode.Location = new System.Drawing.Point(6, 32);
            this.btnSelectMode.Name = "btnSelectMode";
            this.btnSelectMode.Size = new System.Drawing.Size(62, 64);
            this.btnSelectMode.TabIndex = 2;
            this.btnSelectMode.UseVisualStyleBackColor = false;
            this.btnSelectMode.Click += new System.EventHandler(this.btnSelectMode_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = global::PaintApp.Properties.Resources.page_edit_icon;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(143, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 64);
            this.btnClear.TabIndex = 3;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackgroundImage = global::PaintApp.Properties.Resources.trash_icon__1__Small;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(75, 32);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(62, 64);
            this.btnDel.TabIndex = 4;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // colorRadioButton11
            // 
            this.colorRadioButton11.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton11.BackColor = System.Drawing.Color.Red;
            this.colorRadioButton11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.colorRadioButton11.FlatAppearance.BorderSize = 2;
            this.colorRadioButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorRadioButton11.Location = new System.Drawing.Point(6, 29);
            this.colorRadioButton11.Name = "colorRadioButton11";
            this.colorRadioButton11.Size = new System.Drawing.Size(59, 58);
            this.colorRadioButton11.TabIndex = 1;
            this.colorRadioButton11.TabStop = true;
            this.colorRadioButton11.UseVisualStyleBackColor = false;
            // 
            // colorRadioButton5
            // 
            this.colorRadioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton5.BackColor = System.Drawing.Color.Black;
            this.colorRadioButton5.Checked = true;
            this.colorRadioButton5.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.colorRadioButton5.FlatAppearance.BorderSize = 2;
            this.colorRadioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorRadioButton5.Location = new System.Drawing.Point(71, 91);
            this.colorRadioButton5.Name = "colorRadioButton5";
            this.colorRadioButton5.Size = new System.Drawing.Size(62, 56);
            this.colorRadioButton5.TabIndex = 12;
            this.colorRadioButton5.TabStop = true;
            this.colorRadioButton5.UseVisualStyleBackColor = false;
            // 
            // colorRadioButton9
            // 
            this.colorRadioButton9.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton9.BackColor = System.Drawing.Color.White;
            this.colorRadioButton9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.colorRadioButton9.FlatAppearance.BorderSize = 2;
            this.colorRadioButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorRadioButton9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorRadioButton9.Location = new System.Drawing.Point(137, 153);
            this.colorRadioButton9.Name = "colorRadioButton9";
            this.colorRadioButton9.Size = new System.Drawing.Size(62, 56);
            this.colorRadioButton9.TabIndex = 16;
            this.colorRadioButton9.TabStop = true;
            this.colorRadioButton9.UseVisualStyleBackColor = false;
            // 
            // colorRadioButton1
            // 
            this.colorRadioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorRadioButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.colorRadioButton1.FlatAppearance.BorderSize = 2;
            this.colorRadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorRadioButton1.Location = new System.Drawing.Point(3, 91);
            this.colorRadioButton1.Name = "colorRadioButton1";
            this.colorRadioButton1.Size = new System.Drawing.Size(62, 56);
            this.colorRadioButton1.TabIndex = 11;
            this.colorRadioButton1.TabStop = true;
            this.colorRadioButton1.UseVisualStyleBackColor = false;
            // 
            // colorRadioButton8
            // 
            this.colorRadioButton8.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colorRadioButton8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.colorRadioButton8.FlatAppearance.BorderSize = 2;
            this.colorRadioButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorRadioButton8.Location = new System.Drawing.Point(71, 153);
            this.colorRadioButton8.Name = "colorRadioButton8";
            this.colorRadioButton8.Size = new System.Drawing.Size(62, 56);
            this.colorRadioButton8.TabIndex = 15;
            this.colorRadioButton8.TabStop = true;
            this.colorRadioButton8.UseVisualStyleBackColor = false;
            // 
            // colorRadioButton6
            // 
            this.colorRadioButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton6.BackColor = System.Drawing.Color.Yellow;
            this.colorRadioButton6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.colorRadioButton6.FlatAppearance.BorderSize = 2;
            this.colorRadioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorRadioButton6.Location = new System.Drawing.Point(137, 91);
            this.colorRadioButton6.Name = "colorRadioButton6";
            this.colorRadioButton6.Size = new System.Drawing.Size(62, 56);
            this.colorRadioButton6.TabIndex = 13;
            this.colorRadioButton6.TabStop = true;
            this.colorRadioButton6.UseVisualStyleBackColor = false;
            // 
            // colorRadioButton3
            // 
            this.colorRadioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton3.BackColor = System.Drawing.Color.Blue;
            this.colorRadioButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.colorRadioButton3.FlatAppearance.BorderSize = 2;
            this.colorRadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorRadioButton3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.colorRadioButton3.Location = new System.Drawing.Point(71, 29);
            this.colorRadioButton3.Name = "colorRadioButton3";
            this.colorRadioButton3.Size = new System.Drawing.Size(62, 56);
            this.colorRadioButton3.TabIndex = 5;
            this.colorRadioButton3.TabStop = true;
            this.colorRadioButton3.UseVisualStyleBackColor = false;
            // 
            // colorRadioButton4
            // 
            this.colorRadioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton4.BackColor = System.Drawing.Color.Green;
            this.colorRadioButton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.colorRadioButton4.FlatAppearance.BorderSize = 2;
            this.colorRadioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorRadioButton4.Location = new System.Drawing.Point(137, 29);
            this.colorRadioButton4.Name = "colorRadioButton4";
            this.colorRadioButton4.Size = new System.Drawing.Size(62, 56);
            this.colorRadioButton4.TabIndex = 10;
            this.colorRadioButton4.TabStop = true;
            this.colorRadioButton4.UseVisualStyleBackColor = false;
            // 
            // colorRadioButton7
            // 
            this.colorRadioButton7.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorRadioButton7.BackColor = System.Drawing.Color.Purple;
            this.colorRadioButton7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.colorRadioButton7.FlatAppearance.BorderSize = 2;
            this.colorRadioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorRadioButton7.Location = new System.Drawing.Point(3, 153);
            this.colorRadioButton7.Name = "colorRadioButton7";
            this.colorRadioButton7.Size = new System.Drawing.Size(62, 56);
            this.colorRadioButton7.TabIndex = 14;
            this.colorRadioButton7.TabStop = true;
            this.colorRadioButton7.UseVisualStyleBackColor = false;
            // 
            // radioEllipse
            // 
            this.radioEllipse.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioEllipse.BackgroundImage = global::PaintApp.Properties.Resources.Purple_Circle_Flat_icon;
            this.radioEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioEllipse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioEllipse.FlatAppearance.BorderSize = 2;
            this.radioEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioEllipse.Location = new System.Drawing.Point(106, 116);
            this.radioEllipse.Name = "radioEllipse";
            this.radioEllipse.Size = new System.Drawing.Size(96, 92);
            this.radioEllipse.TabIndex = 1;
            this.radioEllipse.TabStop = true;
            this.radioEllipse.UseVisualStyleBackColor = true;
            // 
            // radioTriangle
            // 
            this.radioTriangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTriangle.BackgroundImage = global::PaintApp.Properties.Resources.Red_Triangle_Flat_icon_Medium;
            this.radioTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioTriangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioTriangle.FlatAppearance.BorderSize = 2;
            this.radioTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTriangle.Location = new System.Drawing.Point(6, 116);
            this.radioTriangle.Name = "radioTriangle";
            this.radioTriangle.Size = new System.Drawing.Size(96, 92);
            this.radioTriangle.TabIndex = 2;
            this.radioTriangle.TabStop = true;
            this.radioTriangle.UseVisualStyleBackColor = true;
            // 
            // radioRectangle
            // 
            this.radioRectangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioRectangle.BackgroundImage = global::PaintApp.Properties.Resources.Rectangle_tool_icon_Orange;
            this.radioRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioRectangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioRectangle.FlatAppearance.BorderSize = 2;
            this.radioRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioRectangle.Location = new System.Drawing.Point(6, 23);
            this.radioRectangle.Name = "radioRectangle";
            this.radioRectangle.Size = new System.Drawing.Size(96, 87);
            this.radioRectangle.TabIndex = 0;
            this.radioRectangle.TabStop = true;
            this.radioRectangle.UseVisualStyleBackColor = true;
            // 
            // radioHexagon
            // 
            this.radioHexagon.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioHexagon.BackgroundImage = global::PaintApp.Properties.Resources.hexagon_icon_Blue;
            this.radioHexagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioHexagon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioHexagon.FlatAppearance.BorderSize = 2;
            this.radioHexagon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioHexagon.Location = new System.Drawing.Point(106, 23);
            this.radioHexagon.Name = "radioHexagon";
            this.radioHexagon.Size = new System.Drawing.Size(96, 87);
            this.radioHexagon.TabIndex = 3;
            this.radioHexagon.TabStop = true;
            this.radioHexagon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 895);
            this.Controls.Add(this.fıleBox);
            this.Controls.Add(this.shapeOperataionBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.shapeBox);
            this.Controls.Add(this.drawBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.fıleBox.ResumeLayout(false);
            this.shapeBox.ResumeLayout(false);
            this.colorBox.ResumeLayout(false);
            this.shapeOperataionBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectMode;
        private ColorRadioButton colorRadioButton3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel drawBox;
        private System.Windows.Forms.GroupBox fıleBox;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private ShapeRadioButon radioEllipse;
        private ShapeRadioButon radioRectangle;
        private ShapeRadioButon radioTriangle;
        private ShapeRadioButon radioHexagon;
        private ColorRadioButton colorRadioButton9;
        private ColorRadioButton colorRadioButton8;
        private ColorRadioButton colorRadioButton7;
        private ColorRadioButton colorRadioButton6;
        private ColorRadioButton colorRadioButton5;
        private ColorRadioButton colorRadioButton1;
        private ColorRadioButton colorRadioButton4;
        private ColorRadioButton colorRadioButton11;
        private System.Windows.Forms.GroupBox shapeBox;
        private System.Windows.Forms.GroupBox colorBox;
        private System.Windows.Forms.GroupBox shapeOperataionBox;
    }
}

