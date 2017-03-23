using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlingClasses;
using HelperFunctionality;
using System.Drawing;
using AdditionalForms;

namespace Computer_Vision_Package.Filters
{
    class GaussianFilter : Filter
    {

        public double[,] Arr;
        int NewWidth, NewHeight;
        public int KernalSize = 7;
        Image MainImage;
        Bitmap ImageBitMap;
        Vector3[,] RGBvalues; // RGB Values After Padding
        public double Sigma = 0;
        public override void ApplayFilter(_Image ApplayImage)
        {
            Arr = new double[ApplayImage.ImageHeight, ApplayImage.ImageWidth];
            double[,] FilterMatrix = HelperFunctions.BuildGaussianMatrix(KernalSize, Sigma);

            MainImage = ApplayImage.GetMainImage();

            if (MainImage == null)
                ImageBitMap = ApplayImage.GetFilterdImageBitMap();
            else
                ImageBitMap = new Bitmap(MainImage);

            // Applying Padding
            RGBvalues = HelperFunctions.Padding(ImageBitMap, KernalSize, out NewWidth, out NewHeight);
            // Applay Convolution
            HelperFunctions.Convolution(ImageBitMap, KernalSize, FilterMatrix, RGBvalues, NewWidth, NewHeight);
            // Set The Filterd Image To the MainImage
            ApplayImage.SetFilterdBitMap(ref ImageBitMap);
        }

        public override bool HasAditionalForm()
        {
            return true;

        }

        public override void ShowFilterForm()
        {
            GaussianForm NewForm = new GaussianForm();
            NewForm.ShowDialog();
            this.Sigma = NewForm.Segma;
            this.KernalSize = NewForm.KernelSize;
        }

        public override string ToString()
        {
            return "Gaussian Filter";
        }
    }
}
