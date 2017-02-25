using ControlingClasses;
using HelperFunctionality;
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

        Point MouseDownLocation;
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
            MouseDownLocation = new Point();
        }
        private void LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Please Choose Image To Applay Filters";
            OFD.Filter = "Images|*.png;*.jpg;*.jpeg";
            button1.PerformClick();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                ImagePath_txt.Text = OFD.FileName;
                ImageControl.SetImageLocation(OFD.FileName , true);
                // Adding The Picture Box To The panel 
                PictureBox WantToAdded = CreateNewPictureBox();
                WantToAdded.Image = ImageControl.GetMainImage();
                ///////////
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

        }

        private void FiltersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter selectedAlgorithm = this.FiltersList.SelectedItem as Filter;
            selectedAlgorithm.ApplayFilter(ImageControl);

            PictureBox WantToAdd = CreateNewPictureBox();
            WantToAdd.Name = selectedAlgorithm.ToString();
            WantToAdd.Image = ImageControl.GetFilterdImageBitMap();
        }
        public PictureBox CreateNewPictureBox()
        {
            PictureBox NewPic = new PictureBox();
            NewPic.Size = new Size(ImageControl.ImageWidth, ImageControl.ImageHeight);
            NewPic.Location = new Point(100, 100);
            NewPic.BorderStyle = BorderStyle.FixedSingle;
            NewPic.MouseDown += pictureBox1_MouseDown;
            NewPic.MouseMove += pictureBox1_MouseMove;
            NewPic.Name = "NO";
            panel1.Controls.Add(NewPic);

            return NewPic;
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
                Selected_AppliedFilter.Text = (sender as PictureBox).Name;
                Selected_ImageSize.Text = (sender as PictureBox).Size.ToString();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox1 = sender as PictureBox;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox1.Left = e.X + pictureBox1.Left - MouseDownLocation.X;
                pictureBox1.Top = e.Y + pictureBox1.Top - MouseDownLocation.Y;

                Selected_ImagePosition.Text = (sender as PictureBox).Location.ToString();
                panel1.Invalidate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = panel1.CreateGraphics();
            for (int i = 1; i < panel1.Controls.Count; i++)
            {
                Line L = new Line(panel1.Controls[0].Location, panel1.Controls[i].Location);
                L.DrawLine(G);

                PointF TextLocation = new PointF((panel1.Controls[i].Location.X + panel1.Controls[0].Location.X ) / 2 ,
                    (panel1.Controls[i].Location.Y + panel1.Controls[0].Location.Y) / 2
                    );

                using (SolidBrush br = new SolidBrush(Color.Red))
                {
                    e.Graphics.DrawString(panel1.Controls[i].Name, this.Font, br, TextLocation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Invalidate();

            ImageControl = new _Image();
        }
    }
}
