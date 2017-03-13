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
    public partial class ContrastStreaching : Form
    {
        public double BitPerPixel;
        public ContrastStreaching()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BitPerPixel = (double)numericUpDown1.Value;
            this.Close();
        }
    }
}
