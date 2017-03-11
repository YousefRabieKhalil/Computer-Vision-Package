
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
        int Newheight;
        int NewWidth;
        private static double[,] xSobel
        {
            get
            {
                return new double[,]
                {
            { -1, 0, 1 },
            { -2, 0, 2 },
            { -1, 0, 1 }
                };
            }
        }

        //Sobel operator kernel for vertical pixel changes
        private static double[,] ySobel
        {
            get
            {
                return new double[,]
                {
            {  1,  2,  1 },
            {  0,  0,  0 },
            { -1, -2, -1 }
                };
            }
        }
        public override void ApplayFilter(_Image ApplayImage)
        {
            // The Side Size of The Filter
            const int KernalSize = 3;
            // The Matrix of The Filter

            MainImage = ApplayImage.GetMainImage();
            ImageBitMap = new Bitmap(MainImage);

            // Applying Padding
            RGBvalues = HelperFunctions.Padding(ImageBitMap, KernalSize, out NewWidth, out Newheight);
            // Applay Convolution for X And y Sobel
            HelperFunctions.Convolution(ImageBitMap, KernalSize, ySobel , xSobel, RGBvalues, NewWidth, Newheight);
            // Set The Filterd Image To the MainImage
            ApplayImage.SetFilterdBitMap(ref ImageBitMap);

        }

        public override string ToString()
        {
            return "Soble Opreator";
        }

        public override bool HasAditionalForm()
        {
            return false;
        }

        public override void ShowFilterForm()
        {
            // it's not Have Any form 
            throw new NotImplementedException();
        }
    }
}
