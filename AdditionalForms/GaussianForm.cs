using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalForms
{
    public partial class GaussianForm : Form
    {

        public int KernelSize;
        public double Segma;
        public GaussianForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Segma = (double)this.numericUpDown2.Value;
            KernelSize = (int)this.numericUpDown1.Value;
            this.Close();
        }
    }
}
