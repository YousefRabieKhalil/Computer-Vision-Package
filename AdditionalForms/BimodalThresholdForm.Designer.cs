namespace AdditionalForms
{
    partial class BimodalThresholdForm
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
            this.Done = new System.Windows.Forms.Button();
            this.T0 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.T0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T1)).BeginInit();
            this.SuspendLayout();
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(256, 90);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 0;
            this.Done.Text = "button1";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // T0
            // 
            this.T0.Location = new System.Drawing.Point(59, 42);
            this.T0.Name = "T0";
            this.T0.Size = new System.Drawing.Size(70, 20);
            this.T0.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "intial T0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "T1";
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(189, 44);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(70, 20);
            this.T1.TabIndex = 3;
            // 
            // BimodalThresholdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 125);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T0);
            this.Controls.Add(this.Done);
            this.Name = "BimodalThresholdForm";
            this.Text = "BimodalThresholdForm";
            ((System.ComponentModel.ISupportInitialize)(this.T0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.NumericUpDown T0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown T1;
    }
}