namespace AdditionalForms
{
    partial class StrucutureElemntChoose
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
            this.SideLentxtB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DrawGridBTN = new System.Windows.Forms.Button();
            this.Tpes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SideLentxtB
            // 
            this.SideLentxtB.Location = new System.Drawing.Point(169, 6);
            this.SideLentxtB.Name = "SideLentxtB";
            this.SideLentxtB.Size = new System.Drawing.Size(100, 20);
            this.SideLentxtB.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Structure Element Side Length";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DrawGridBTN
            // 
            this.DrawGridBTN.Location = new System.Drawing.Point(275, 6);
            this.DrawGridBTN.Name = "DrawGridBTN";
            this.DrawGridBTN.Size = new System.Drawing.Size(93, 47);
            this.DrawGridBTN.TabIndex = 3;
            this.DrawGridBTN.Text = "Draw Grid";
            this.DrawGridBTN.UseVisualStyleBackColor = true;
            this.DrawGridBTN.Click += new System.EventHandler(this.DrawGridBTN_Click);
            // 
            // Tpes
            // 
            this.Tpes.FormattingEnabled = true;
            this.Tpes.Items.AddRange(new object[] {
            "Squer"});
            this.Tpes.Location = new System.Drawing.Point(148, 32);
            this.Tpes.Name = "Tpes";
            this.Tpes.Size = new System.Drawing.Size(121, 21);
            this.Tpes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Structure Element Type\r\n";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(15, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 250);
            this.panel1.TabIndex = 6;
            // 
            // StrucutureElemntChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tpes);
            this.Controls.Add(this.DrawGridBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SideLentxtB);
            this.Name = "StrucutureElemntChoose";
            this.Text = "Structure Element Choose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SideLentxtB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DrawGridBTN;
        private System.Windows.Forms.ComboBox Tpes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}