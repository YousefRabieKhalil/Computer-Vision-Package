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
    public partial class MultimodalHistogramForm : Form
    {
        public double ThresholdStart, ThresoldEnd, DefultValue;
        public MultimodalHistogramForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThresholdStart = (double)Start.Value;
            ThresoldEnd = (double)End.Value;
            DefultValue = (double)Dvalue.Value;


            if (ThresholdStart > ThresoldEnd)
            {
                double Temp = ThresholdStart;
                ThresholdStart = ThresoldEnd;
                ThresoldEnd = Temp;
            }
            this.Close();
        }
    }
}
