
using ControlingClasses;
using HelperFunctionality;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Vision_Package
{
    class Sobel : Filter
    {
        Image MainImage;
        Bitmap ImageBitMap;
        Vector3[,] RGBvalues; // RGB Values After Padding
        double[,] FilterMatrix;
        int Newheight;
        int NewWidth;

        public override void ApplayFilter(_Image ApplayImage)
        {
            // The Side Size of The Filter
            const int KernalSize = 3;
            // The Matrix of The Filter
            FilterMatrix = new double[KernalSize, KernalSize] { { 1.0f, 0.0f, -1.0f }, { 2.0f, 0.0f, -2.0f }, { 1.0f, 0.0f, -1.0f } };

            MainImage = ApplayImage.GetMainImage();
            ImageBitMap = new Bitmap(MainImage);

            // Applying Padding
            RGBvalues = HelperFunctions.Padding(ImageBitMap, KernalSize, out NewWidth, out Newheight);
            // Applay Convolution
            HelperFunctions.Convolution(ImageBitMap, KernalSize, FilterMatrix, RGBvalues, NewWidth, Newheight);
            // Set The Filterd Image To the MainImage
            ApplayImage.SetFilterdBitMap(ref ImageBitMap);

        }

        public override string ToString()
        {
            return "Soble Opreator";
        }
    }
}
