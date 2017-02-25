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
            this.ImagePath_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FiltersList = new System.Windows.Forms.ComboBox();
            this.Pixel_View_CheckBox = new System.Windows.Forms.CheckBox();
            this.ResetPre_Image = new System.Windows.Forms.Button();
            this.Prevoius_Images = new System.Windows.Forms.ListBox();
            this.LoadImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Selected_ImagePosition = new System.Windows.Forms.Label();
            this.Selected_AppliedFilter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Selected_ImageSize = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImagePath_txt
            // 
            this.ImagePath_txt.Location = new System.Drawing.Point(12, 27);
            this.ImagePath_txt.Name = "ImagePath_txt";
            this.ImagePath_txt.Size = new System.Drawing.Size(822, 20);
            this.ImagePath_txt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.FiltersList);
            this.groupBox1.Controls.Add(this.Pixel_View_CheckBox);
            this.groupBox1.Controls.Add(this.ResetPre_Image);
            this.groupBox1.Controls.Add(this.Prevoius_Images);
            this.groupBox1.Location = new System.Drawing.Point(642, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 447);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // FiltersList
            // 
            this.FiltersList.FormattingEnabled = true;
            this.FiltersList.Location = new System.Drawing.Point(6, 65);
            this.FiltersList.Name = "FiltersList";
            this.FiltersList.Size = new System.Drawing.Size(261, 21);
            this.FiltersList.TabIndex = 3;
            this.FiltersList.Text = "List Of Filters";
            this.FiltersList.SelectedIndexChanged += new System.EventHandler(this.FiltersList_SelectedIndexChanged);
            // 
            // Pixel_View_CheckBox
            // 
            this.Pixel_View_CheckBox.AutoSize = true;
            this.Pixel_View_CheckBox.Location = new System.Drawing.Point(6, 32);
            this.Pixel_View_CheckBox.Name = "Pixel_View_CheckBox";
            this.Pixel_View_CheckBox.Size = new System.Drawing.Size(120, 17);
            this.Pixel_View_CheckBox.TabIndex = 2;
            this.Pixel_View_CheckBox.Text = "show Image In Pixel";
            this.Pixel_View_CheckBox.UseVisualStyleBackColor = true;
            this.Pixel_View_CheckBox.CheckedChanged += new System.EventHandler(this.Pixel_View_CheckBox_CheckedChanged);
            // 
            // ResetPre_Image
            // 
            this.ResetPre_Image.Location = new System.Drawing.Point(6, 418);
            this.ResetPre_Image.Name = "ResetPre_Image";
            this.ResetPre_Image.Size = new System.Drawing.Size(101, 23);
            this.ResetPre_Image.TabIndex = 1;
            this.ResetPre_Image.Text = "Reset List";
            this.ResetPre_Image.UseVisualStyleBackColor = true;
            this.ResetPre_Image.Click += new System.EventHandler(this.ResetPre_Image_Click);
            // 
            // Prevoius_Images
            // 
            this.Prevoius_Images.FormattingEnabled = true;
            this.Prevoius_Images.Location = new System.Drawing.Point(6, 265);
            this.Prevoius_Images.Name = "Prevoius_Images";
            this.Prevoius_Images.Size = new System.Drawing.Size(101, 147);
            this.Prevoius_Images.TabIndex = 0;
            // 
            // LoadImage
            // 
            this.LoadImage.Location = new System.Drawing.Point(840, 24);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(75, 23);
            this.LoadImage.TabIndex = 3;
            this.LoadImage.Text = "Load image";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Image Path:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(15, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 447);
            this.panel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Selected_ImageSize);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Selected_AppliedFilter);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Selected_ImagePosition);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(113, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 166);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Image";
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
            // Selected_ImagePosition
            // 
            this.Selected_ImagePosition.AutoSize = true;
            this.Selected_ImagePosition.Location = new System.Drawing.Point(56, 28);
            this.Selected_ImagePosition.Name = "Selected_ImagePosition";
            this.Selected_ImagePosition.Size = new System.Drawing.Size(73, 13);
            this.Selected_ImagePosition.TabIndex = 1;
            this.Selected_ImagePosition.Text = "ImagePosition";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Size :";
            // 
            // Selected_ImageSize
            // 
            this.Selected_ImageSize.AutoSize = true;
            this.Selected_ImageSize.Location = new System.Drawing.Point(38, 81);
            this.Selected_ImageSize.Name = "Selected_ImageSize";
            this.Selected_ImageSize.Size = new System.Drawing.Size(59, 13);
            this.Selected_ImageSize.TabIndex = 5;
            this.Selected_ImageSize.Text = "Image Size";
            // 
            // ComputerVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImagePath_txt);
            this.Name = "ComputerVision";
            this.Text = "Computer Vision";
            this.Load += new System.EventHandler(this.ComputerVision_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ImagePath_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetPre_Image;
        private System.Windows.Forms.ListBox Prevoius_Images;
        private System.Windows.Forms.CheckBox Pixel_View_CheckBox;
        private System.Windows.Forms.ComboBox FiltersList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Selected_ImagePosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Selected_AppliedFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Selected_ImageSize;
        private System.Windows.Forms.Label label5;
    }
}

