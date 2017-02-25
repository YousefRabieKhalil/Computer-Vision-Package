using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperFunctionality
{
    public class HelperFunctions
    {
        /// <summary>
        /// Applay Padding To an Image
        /// </summary>
        /// <param name="ImageBitMap"> The Image That Want to applay Padding To </param>
        /// <param name="KernalSize"> The size of The Kernal (Filter) </param>
        /// <param name="NewWidth"> The Width Of The Image After Applay Padding </param>
        /// <param name="Newheight"> The Height of The Image After Applay Padding </param>
        /// <returns> The Image After Applay Padding </returns>
        public static Vector3[,] Padding(Bitmap ImageBitMap, int KernalSize, out int NewWidth, out int Newheight)
        {
            NewWidth = ImageBitMap.Width + 2 * ((int)KernalSize / 2);
            Newheight = ImageBitMap.Height + 2 * ((int)KernalSize / 2);

            Vector3[,] RGBvalues = new Vector3[Newheight, NewWidth];
            for (int i = 0; i < Newheight; i++)
            {
                for (int j = 0; j < NewWidth; j++)
                {

                    if ((i >= 0 && i < ((int)KernalSize / 2))
                        || (j >= 0 && j < ((int)KernalSize / 2))
                        || (i >= Newheight - ((int)KernalSize / 2) && i < Newheight)
                        || (j >= NewWidth - ((int)KernalSize / 2) && j < NewWidth)
                        )

                    {
                        RGBvalues[i, j] = new Vector3(0, 0, 0);
                    }
                    else
                    {
                        RGBvalues[i, j] = new Vector3(ImageBitMap.GetPixel(i - ((int)KernalSize / 2), j - ((int)KernalSize / 2)).R, ImageBitMap.GetPixel(i - ((int)KernalSize / 2), j - ((int)KernalSize / 2)).G, ImageBitMap.GetPixel(i - ((int)KernalSize / 2), j - ((int)KernalSize / 2)).B);
                    }
                }
            }
            return RGBvalues;
        }
        /// <summary>
        /// Applay Any Filter To Any Image
        /// </summary>
        /// <param name="ImageBitmap"> Image That Will Be Edited </param>
        /// <param name="KernalSize"> The Filter Side Size </param>
        /// <param name="FilterMatrix"> The Filter </param>
        /// <param name="RGBvalues"> Image After Applay Padding </param>
        /// <param name="width">Width for image </param>
        /// <param name="height">Height for Image</param>
        public static void Convolution(Bitmap ImageBitmap,int KernalSize, double[,] FilterMatrix, Vector3[,] RGBvalues, int width, int height)
        {

            Vector3 MinVector = GetMin(RGBvalues, width, height);
            Vector3 MaxVector = GetMax(RGBvalues, width, height);
            int AdditionColRow = KernalSize / 2;
            for (int i = AdditionColRow ; i < height - AdditionColRow * 2; i++)
            {
                for (int j = AdditionColRow; j < width - AdditionColRow * 2; j++)
                {
                    double SumR = 0, SumG = 0, SumB = 0;
                    int indexi = 0, Indexj = 0;
                    // Applay The Filter
                    for (int k = i - AdditionColRow; k < (i - AdditionColRow) + KernalSize && (j - 1) + KernalSize < height; k++)
                    {
                        Indexj = 0;
                        for (int m = j - AdditionColRow; m < (j - AdditionColRow) + KernalSize && (j - AdditionColRow) + KernalSize < width; m++)
                        {
                            SumR += FilterMatrix[indexi, Indexj] * RGBvalues[k, m].R;
                            SumG += FilterMatrix[indexi, Indexj] * RGBvalues[k, m].G;
                            SumB += FilterMatrix[indexi, Indexj] * RGBvalues[k, m].B;

                            
                            //SumR = Normalize(MaxVector.R , MinVector.R , SumR);
                            //SumG = Normalize(MaxVector.G, MinVector.G, SumG);
                            //SumB = Normalize(MaxVector.B, MinVector.B, SumB);

                            Indexj++;

                        }
                        indexi++;
                    }
                    ImageBitmap.SetPixel(i - 1, j - 1, Color.FromArgb((int)SumR, (int)SumG, (int)SumB));
                }
            }
        }

        /// <summary>
        /// Normalize A value 
        /// </summary>
        /// <param name="Max"> Maximum Value </param>
        /// <param name="Min"> MiniMum Value </param>
        /// <param name="Value"> Value Want To Normalize </param>
        /// <returns></returns>
        public static double Normalize(double Max, double Min, double Value)
        {
            double NormalizedValue;

            NormalizedValue = (Value - Min) / (Max - Min);

            return NormalizedValue;
        }
        /// <summary>
        /// Get The Min Value Of 2D array of vector3
        /// </summary>
        /// <param name="RGB"> 2d array of  Vector3 </param>
        /// <param name="width"> The width Of Array </param>
        /// <param name="height"> The height Of array </param>
        /// <returns></returns>
        public static Vector3 GetMin(Vector3[,] RGB , int width , int height)
        {
            int MinR , MinG, MinB;

            MinR = MinG = MinB = int.MaxValue;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (MinR > RGB[i,j].R)
                    {
                        MinR = RGB[i, j].R;
                    }

                    if (MinG > RGB[i,j].G)
                    {
                        MinG = RGB[i, j].G;
                    }

                    if (MinB > RGB[i,j].B)
                    {
                        MinB = RGB[i, j].B;
                    }
                }
            }
            Vector3 V = new Vector3(MinR, MinG, MinB);

            return V;

        }
        /// <summary>
        /// get the Max value of Array of vector3
        /// </summary>
        /// <param name="RGB"> 2D Array </param>
        /// <param name="width">the width of Array</param>
        /// <param name="height">the height of array</param>
        /// <returns></returns>
        public static Vector3 GetMax(Vector3[,] RGB, int width, int height)
        {
            int MaxR, MaxG, MaxB;

            MaxR = MaxG = MaxB = int.MinValue;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (MaxR < RGB[i, j].R)
                    {
                        MaxR = RGB[i, j].R;
                    }

                    if (MaxG < RGB[i, j].G)
                    {
                        MaxG = RGB[i, j].G;
                    }

                    if (MaxB < RGB[i, j].B)
                    {
                        MaxB = RGB[i, j].B;
                    }
                }
            }
            Vector3 V = new Vector3(MaxR, MaxG, MaxB);

            return V;
        }
    }
}
