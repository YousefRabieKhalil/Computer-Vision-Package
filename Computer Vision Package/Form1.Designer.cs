namespace Computer_Vision_Package
{
    partial class ComputerVision
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerVision));
            this.ImagePath_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.detec_combo = new System.Windows.Forms.ComboBox();
            this.Enhance_Combo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetPre_Image = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedImage = new System.Windows.Forms.GroupBox();
            this.MaxGrayScale = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MinGrayScale = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Selected_ImageSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Selected_AppliedFilter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Selected_ImagePosition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadImage = new System.Windows.Forms.Button();
            this.Prevoius_Images = new System.Windows.Forms.ListBox();
            this.FiltersList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SelectedImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImagePath_txt
            // 
            this.ImagePath_txt.Location = new System.Drawing.Point(9, 43);
            this.ImagePath_txt.Name = "ImagePath_txt";
            this.ImagePath_txt.Size = new System.Drawing.Size(261, 20);
            this.ImagePath_txt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.detec_combo);
            this.groupBox1.Controls.Add(this.Enhance_Combo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ResetPre_Image);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SelectedImage);
            this.groupBox1.Controls.Add(this.LoadImage);
            this.groupBox1.Controls.Add(this.ImagePath_txt);
            this.groupBox1.Controls.Add(this.Prevoius_Images);
            this.groupBox1.Controls.Add(this.FiltersList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(637, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 549);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // detec_combo
            // 
            this.detec_combo.FormattingEnabled = true;
            this.detec_combo.Location = new System.Drawing.Point(9, 152);
            this.detec_combo.Name = "detec_combo";
            this.detec_combo.Size = new System.Drawing.Size(261, 21);
            this.detec_combo.TabIndex = 7;
            this.detec_combo.Text = "Object Detection Algorithm";
            this.detec_combo.SelectedIndexChanged += new System.EventHandler(this.detec_combo_SelectedIndexChanged);
            // 
            // Enhance_Combo
            // 
            this.Enhance_Combo.FormattingEnabled = true;
            this.Enhance_Combo.Location = new System.Drawing.Point(8, 125);
            this.Enhance_Combo.Name = "Enhance_Combo";
            this.Enhance_Combo.Size = new System.Drawing.Size(261, 21);
            this.Enhance_Combo.TabIndex = 6;
            this.Enhance_Combo.Text = "Enhancement Algorithms";
            this.Enhance_Combo.SelectedIndexChanged += new System.EventHandler(this.Enhance_Combo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetPre_Image
            // 
            this.ResetPre_Image.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResetPre_Image.Location = new System.Drawing.Point(3, 297);
            this.ResetPre_Image.Name = "ResetPre_Image";
            this.ResetPre_Image.Size = new System.Drawing.Size(270, 23);
            this.ResetPre_Image.TabIndex = 1;
            this.ResetPre_Image.Text = "Resize List";
            this.ResetPre_Image.UseVisualStyleBackColor = true;
            this.ResetPre_Image.Click += new System.EventHandler(this.ResetPre_Image_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Image Path:";
            // 
            // SelectedImage
            // 
            this.SelectedImage.Controls.Add(this.MaxGrayScale);
            this.SelectedImage.Controls.Add(this.label8);
            this.SelectedImage.Controls.Add(this.MinGrayScale);
            this.SelectedImage.Controls.Add(this.label6);
            this.SelectedImage.Controls.Add(this.Selected_ImageSize);
            this.SelectedImage.Controls.Add(this.label5);
            this.SelectedImage.Controls.Add(this.Selected_AppliedFilter);
            this.SelectedImage.Controls.Add(this.label4);
            this.SelectedImage.Controls.Add(this.Selected_ImagePosition);
            this.SelectedImage.Controls.Add(this.label2);
            this.SelectedImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedImage.Location = new System.Drawing.Point(3, 320);
            this.SelectedImage.Name = "SelectedImage";
            this.SelectedImage.Size = new System.Drawing.Size(270, 131);
            this.SelectedImage.TabIndex = 4;
            this.SelectedImage.TabStop = false;
            this.SelectedImage.Text = "Selected Image";
            // 
            // MaxGrayScale
            // 
            this.MaxGrayScale.AutoSize = true;
            this.MaxGrayScale.Location = new System.Drawing.Point(236, 106);
            this.MaxGrayScale.Name = "MaxGrayScale";
            this.MaxGrayScale.Size = new System.Drawing.Size(27, 13);
            this.MaxGrayScale.TabIndex = 9;
            this.MaxGrayScale.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Max(GrayScale) :";
            // 
            // MinGrayScale
            // 
            this.MinGrayScale.AutoSize = true;
            this.MinGrayScale.Location = new System.Drawing.Point(97, 106);
            this.MinGrayScale.Name = "MinGrayScale";
            this.MinGrayScale.Size = new System.Drawing.Size(24, 13);
            this.MinGrayScale.TabIndex = 7;
            this.MinGrayScale.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Min(GrayScale) :";
            // 
            // Selected_ImageSize
            // 
            this.Selected_ImageSize.AutoSize = true;
            this.Selected_ImageSize.Location = new System.Drawing.Point(38, 78);
            this.Selected_ImageSize.Name = "Selected_ImageSize";
            this.Selected_ImageSize.Size = new System.Drawing.Size(59, 13);
            this.Selected_ImageSize.TabIndex = 5;
            this.Selected_ImageSize.Text = "Image Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Size :";
            // 
            // Selected_AppliedFilter
            // 
            this.Selected_AppliedFilter.AutoSize = true;
            this.Selected_AppliedFilter.Location = new System.Drawing.Point(75, 52);
            this.Selected_AppliedFilter.Name = "Selected_AppliedFilter";
            this.Selected_AppliedFilter.Size = new System.Drawing.Size(23, 13);
            this.Selected_AppliedFilter.TabIndex = 3;
            this.Selected_AppliedFilter.Text = "NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "AppliedFilter :";
            // 
            // Selected_ImagePosition
            // 
            this.Selected_ImagePosition.AutoSize = true;
            this.Selected_ImagePosition.Location = new System.Drawing.Point(56, 28);
            this.Selected_ImagePosition.Name = "Selected_ImagePosition";
            this.Selected_ImagePosition.Size = new System.Drawing.Size(73, 13);
            this.Selected_ImagePosition.TabIndex = 1;
            this.Selected_ImagePosition.Text = "ImagePosition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Position :";
            // 
            // LoadImage
            // 
            this.LoadImage.Location = new System.Drawing.Point(194, 69);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(75, 23);
            this.LoadImage.TabIndex = 3;
            this.LoadImage.Text = "Load image";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // Prevoius_Images
            // 
            this.Prevoius_Images.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Prevoius_Images.FormattingEnabled = true;
            this.Prevoius_Images.Location = new System.Drawing.Point(3, 451);
            this.Prevoius_Images.Name = "Prevoius_Images";
            this.Prevoius_Images.Size = new System.Drawing.Size(270, 95);
            this.Prevoius_Images.TabIndex = 0;
            this.Prevoius_Images.SelectedIndexChanged += new System.EventHandler(this.Prevoius_Images_SelectedIndexChanged);
            // 
            // FiltersList
            // 
            this.FiltersList.FormattingEnabled = true;
            this.FiltersList.Location = new System.Drawing.Point(9, 98);
            this.FiltersList.Name = "FiltersList";
            this.FiltersList.Size = new System.Drawing.Size(261, 21);
            this.FiltersList.TabIndex = 3;
            this.FiltersList.Text = "List Of Filters";
            this.FiltersList.SelectedIndexChanged += new System.EventHandler(this.FiltersList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 549);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Show HistoGram for Multible Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ComputerVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComputerVision";
            this.Text = "Computer Vision";
            this.Load += new System.EventHandler(this.ComputerVision_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SelectedImage.ResumeLayout(false);
            this.SelectedImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ImagePath_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltersList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox SelectedImage;
        private System.Windows.Forms.Label Selected_ImagePosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Selected_AppliedFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Selected_ImageSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ResetPre_Image;
        private System.Windows.Forms.ListBox Prevoius_Images;
        private System.Windows.Forms.ComboBox Enhance_Combo;
        private System.Windows.Forms.Label MaxGrayScale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MinGrayScale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox detec_combo;
        private System.Windows.Forms.Button button2;
    }
}

