using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Vision_Package
{
    public partial class ComputerVision : Form
    {
        _Image ImageControl;
        public ComputerVision()
        {
            InitializeComponent();
        }

        public void StartPackage()
        {
            ImageControl = new _Image();
            var assemblyTypes = Assembly.GetAssembly(typeof(Filter)).GetTypes();
          
            var FiltersType = assemblyTypes.Where(x => !x.IsAbstract && x.IsSubclassOf(typeof(Filter)));

            foreach (var filter in FiltersType)
            {
                this.FiltersList.Items.Add((Filter)Activator.CreateInstance(filter, null));
            }
        }
        private void LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Please Choose Image To Applay Filters";
            OFD.Filter = "Images|*.png;*.jpg;*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                ImagePath_txt.Text = OFD.FileName;
                ImageControl.SetImageLocation(OFD.FileName , true);

                Pic_One.Image = ImageControl.GetMainImage();

                Prevoius_Images.Items.Add(OFD.FileName);
            }
            else
            {
                MessageBox.Show("Select A Vaild Image" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            
        }

        private void ComputerVision_Load(object sender, EventArgs e)
        {
            // Intialize
            StartPackage();
        }
        private void ResetPre_Image_Click(object sender, EventArgs e)
        {
            Prevoius_Images.Items.Clear();
        }

        private void Pixel_View_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Pixel_View_CheckBox.Checked == true)
            {
                Pic_One.Image = null;
                Pic_One.Refresh();
                ImageControl.ShowImageAsPixels(Pic_One);
            }
            else
            {
                Pic_One.Image = ImageControl.GetMainImage();
            }
        }

        private void FiltersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter selectedAlgorithm = this.FiltersList.SelectedItem as Filter;
            selectedAlgorithm.ApplayFilter(ImageControl);

            ImageControl.ShowFilterdImageAsPixels(Pic_One);

        }
    }
}
