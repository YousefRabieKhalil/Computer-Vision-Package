using HelperFunctionality;
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
    public partial class GammaFilterForm : MetroFramework.Forms.MetroForm
    {
        Vector3d GammaRGB;
        public List<object> FormAttribute;
        public GammaFilterForm()
        {
            InitializeComponent();
            FormAttribute = new List<object>();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            GammaRGB = new Vector3d((double)Num_Red.Value, (double)Num_Green.Value, (double)Num_Blue.Value);
            FormAttribute.Add(GammaRGB);
            this.Close();
        }
    }
}
