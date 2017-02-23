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
            this.Pic_One = new System.Windows.Forms.PictureBox();
            this.ImagePath_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pixel_View_CheckBox = new System.Windows.Forms.CheckBox();
            this.ResetPre_Image = new System.Windows.Forms.Button();
            this.Prevoius_Images = new System.Windows.Forms.ListBox();
            this.LoadImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltersList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_One)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pic_One
            // 
            this.Pic_One.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_One.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_One.Location = new System.Drawing.Point(12, 53);
            this.Pic_One.Name = "Pic_One";
            this.Pic_One.Size = new System.Drawing.Size(624, 447);
            this.Pic_One.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pic_One.TabIndex = 0;
            this.Pic_One.TabStop = false;
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
            this.ResetPre_Image.Size = new System.Drawing.Size(117, 23);
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
            this.Prevoius_Images.Size = new System.Drawing.Size(117, 147);
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
            // ComputerVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImagePath_txt);
            this.Controls.Add(this.Pic_One);
            this.Name = "ComputerVision";
            this.Text = "Computer Vision";
            this.Load += new System.EventHandler(this.ComputerVision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_One)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_One;
        private System.Windows.Forms.TextBox ImagePath_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetPre_Image;
        private System.Windows.Forms.ListBox Prevoius_Images;
        private System.Windows.Forms.CheckBox Pixel_View_CheckBox;
        private System.Windows.Forms.ComboBox FiltersList;
    }
}

