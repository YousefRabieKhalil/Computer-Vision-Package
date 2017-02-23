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
            FilterMatrix = new double[3, 3] { { 1.0f, 0.0f, -1.0f }, { 2.0f, 0.0f, -2.0f }, { 1.0f, 0.0f, -1.0f } };
            //FilterMatrix = new double[3, 3] { { 1.0f / 9.0f, 1.0f / 9.0f, 1.0f / 9.0f } ,
            //                                  { 1.0f / 9.0f, 1.0f / 9.0f, 1.0f / 9.0f }
            //                                , { 1.0f / 9.0f, 1.0f / 9.0f, 1.0f / 9.0f } };
            ////for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        FilterMatrix[i, j] = (float)1 / 9;
            //    }
            //}

            MainImage = ApplayImage.GetMainImage();
            ImageBitMap = new Bitmap(MainImage);
            ApplayPadding(3);
            ApplayMainFilter(3);

            ApplayImage.SetFilterdBitMap(ref ImageBitMap);
        }

        public override string ToString()
        {
            return "Mean Filter";
        }

        public void ApplayPadding(int KernalSize)
        {
            RGBvalues =  HelperFunctions.Padding(ImageBitMap, KernalSize , out NewWidth, out Newheight);
        }

        public void ApplayMainFilter(int KernalFilter)
        {
            for (int i = 1; i < Newheight-1; i++)
            {
                for (int j = 1; j < NewWidth-1; j++)
                {
                    double SumR = 0 , SumG=0 , SumB=0;
                    int indexi = 0, Indexj = 0;
                    // Applay The Filter
                    for (int k = i-1; k < (i-1)+3 && (j - 1) + 3 < Newheight; k++)
                    {
                        Indexj = 0;
                        for (int m = j-1; m < (j - 1) + 3 && (j-1) + 3 < NewWidth; m++)
                        {
                            SumR = FilterMatrix[indexi, Indexj] * RGBvalues[k, m].R;
                            SumG = FilterMatrix[indexi, Indexj] * RGBvalues[k, m].G;
                            SumB = FilterMatrix[indexi, Indexj] * RGBvalues[k, m].B;

                            if (SumR > 255)
                            {
                                SumR = 255;
                            }
                            else if (SumR < 0)
                            {
                                SumR = 0;
                            }

                            if (SumB > 255)
                            {
                                SumB = 255;
                            }
                            else if (SumB < 0)
                            {
                                SumB = 0;
                            }

                            if (SumG > 255)
                            {
                                SumG = 255;
                            }
                            else if (SumG < 0)
                            {
                                SumG = 0;
                            }

                            Indexj++;
                        }
                        indexi++;
                    }
                    ImageBitMap.SetPixel(i - 1, j - 1, Color.FromArgb((int)SumR, (int)SumG, (int)SumB));
                    // End Of Applaying The filter
                }
            }
        }
    }
}
