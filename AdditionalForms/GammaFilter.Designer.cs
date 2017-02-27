namespace AdditionalForms
{
    partial class GammaFilterForm
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
            this.btn_Done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Num_Red = new System.Windows.Forms.NumericUpDown();
            this.Num_Green = new System.Windows.Forms.NumericUpDown();
            this.Num_Blue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(401, 155);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(75, 23);
            this.btn_Done.TabIndex = 0;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red Gamma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green Gamma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blue Gamma";
            // 
            // Num_Red
            // 
            this.Num_Red.DecimalPlaces = 2;
            this.Num_Red.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Num_Red.Location = new System.Drawing.Point(95, 94);
            this.Num_Red.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Num_Red.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.Num_Red.Name = "Num_Red";
            this.Num_Red.Size = new System.Drawing.Size(46, 20);
            this.Num_Red.TabIndex = 4;
            this.Num_Red.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // Num_Green
            // 
            this.Num_Green.DecimalPlaces = 2;
            this.Num_Green.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Num_Green.Location = new System.Drawing.Point(247, 93);
            this.Num_Green.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Num_Green.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.Num_Green.Name = "Num_Green";
            this.Num_Green.Size = new System.Drawing.Size(46, 20);
            this.Num_Green.TabIndex = 5;
            this.Num_Green.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // Num_Blue
            // 
            this.Num_Blue.DecimalPlaces = 2;
            this.Num_Blue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Num_Blue.Location = new System.Drawing.Point(399, 93);
            this.Num_Blue.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Num_Blue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.Num_Blue.Name = "Num_Blue";
            this.Num_Blue.Size = new System.Drawing.Size(46, 20);
            this.Num_Blue.TabIndex = 6;
            this.Num_Blue.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Note That : The input values range between 0.2 to 5";
            // 
            // GammaFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 204);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Num_Blue);
            this.Controls.Add(this.Num_Green);
            this.Controls.Add(this.Num_Red);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Done);
            this.Name = "GammaFilterForm";
            this.Text = "Gamma Filter";
            ((System.ComponentModel.ISupportInitialize)(this.Num_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Num_Red;
        private System.Windows.Forms.NumericUpDown Num_Green;
        private System.Windows.Forms.NumericUpDown Num_Blue;
        private System.Windows.Forms.Label label4;
    }
}