using ControlingClasses;
using HelperFunctionality;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Vision_Package.Filters
{
    public class MeanFilter : Filter
    {
        Image MainImage;
        Bitmap ImageBitMap;
        Vector3[,] RGBvalues; // RGB Values After Padding
        double[,] FilterMatrix;
        int Newheight;
        int NewWidth;

        public override void ApplayFilter(_Image ApplayImage)
        {
            // The filter Side Size
            const int KernalSize = 3;
            // init The main Matrix of The Filter
            FilterMatrix = new double[KernalSize, KernalSize] { { 1.0f / 9.0f, 1.0f / 9.0f, 1.0f / 9.0f },
                                              { 1.0f / 9.0f, 1.0f / 9.0f, 1.0f / 9.0f }
                                            , { 1.0f / 9.0f, 1.0f / 9.0f, 1.0f / 9.0f }
                                            };


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
            HelperFunctions.Convolution(ImageBitMap, KernalSize, FilterMatrix, RGBvalues, NewWidth, Newheight);
            // Set The Filterd Image To the MainImage
            ApplayImage.SetFilterdBitMap(ref ImageBitMap);
        }

        public override string ToString()
        {
            return "Mean Filter";
        }
    }
}
