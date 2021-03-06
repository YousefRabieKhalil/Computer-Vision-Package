﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlingClasses;
using System.Drawing;
using HelperFunctionality;

namespace Computer_Vision_Package.Filters
{
    class X_Sobel : Filter
    {
        Image MainImage;
        Bitmap ImageBitMap;
        Vector3[,] RGBvalues; // RGB Values After Padding
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

        int Newheight;
        int NewWidth;
        public override void ApplayFilter(_Image ApplayImage)
        {
            // The filter Side Size
            const int KernalSize = 3;
            // init The main Matrix of The Filter

            //FilterMatrix = new double[KernalSize, KernalSize] { { 1.0f / 9.0f, 1.0f / 9.0f, 1.0f / 9.0f , 1.0f / 9.0f  ,1.0f / 9.0f},
            //                                  { 1.0f / 9.0f, 1.0f / 9.0f, 1.0f / 9.0f , 1.0f / 9.0f  ,1.0f / 9.0f}
            //                                , { 1.0f / 9.0f, 1.0f / 9.0f, 1.0f / 9.0f , 1.0f / 9.0f  ,1.0f / 9.0f} ,
            //                                { 1.0f / 9.0f, 1.0f / 9.0f, 1.0f / 9.0f , 1.0f / 9.0f  ,1.0f / 9.0f},
            //                                { 1.0f / 9.0f, 1.0f / 9.0f, 1.0f / 9.0f , 1.0f / 9.0f  ,1.0f / 9.0f}
            //                                };

            MainImage = ApplayImage.GetMainImage();
            ImageBitMap = new Bitmap(MainImage);

            // Applying Padding
            RGBvalues = HelperFunctions.Padding(ImageBitMap, KernalSize, out NewWidth, out Newheight);
            // Applay Convolution
            HelperFunctions.Convolution(ImageBitMap, KernalSize, xSobel, RGBvalues, NewWidth, Newheight);
            // Set The Filterd Image To the MainImage
            ApplayImage.SetFilterdBitMap(ref ImageBitMap);
        }

        public override bool HasAditionalForm()
        {
            return false;
        }

        public override void ShowFilterForm()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "X-Sobel";
        }
    }
}
