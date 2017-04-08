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
    public partial class BimodalThresholdForm : Form
    {
        public double Value0;
        public double Value1;
        public BimodalThresholdForm()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Value0 =(double)T0.Value;
            Value1 = (double)T1.Value;
            this.Close();
        }
    }
}
