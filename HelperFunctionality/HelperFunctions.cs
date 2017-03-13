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
        /// Applaying Convolution using  X And Y  Filter;
        /// </summary>
        /// <param name="ImageBitmap"> The Image itself</param>
        /// <param name="KernalSize"> The Side Size OF a Filter KErnal </param>
        /// <param name="Ymatrix"> The Y matrix Filter </param>
        /// <param name="Xmatrix"> The X matrix Filter </param>
        /// <param name="RGBvalues"> The RGB Values </param>
        /// <param name="width"> The Width of an Image After Applay Padding </param>
        /// <param name="height"> The height Of an Image After Applay Padding </param>
        public static void Convolution(Bitmap ImageBitmap, int KernalSize, double[,] Ymatrix , double[,] Xmatrix, Vector3[,] RGBvalues, int width, int height)
        {

            Vector3 MinVector = GetMin(RGBvalues, width, height);
            Vector3 MaxVector = GetMax(RGBvalues, width, height);
            int AdditionColRow = KernalSize / 2;
            for (int i = AdditionColRow; i < height - AdditionColRow * 2; i++)
            {
                for (int j = AdditionColRow; j < width - AdditionColRow * 2; j++)
                {
                    double SumRx = 0, SumGx = 0, SumBx = 0 , SumRy = 0, SumGy  = 0 , SumBy = 0 ;
                    int indexi = 0, Indexj = 0;
                    // Applay The Filter
                    for (int k = i - AdditionColRow; k < (i - AdditionColRow) + KernalSize && (j - 1) + KernalSize < height; k++)
                    {
                        Indexj = 0;
                        for (int m = j - AdditionColRow; m < (j - AdditionColRow) + KernalSize && (j - AdditionColRow) + KernalSize < width; m++)
                        {
                            SumRx += Xmatrix[indexi, Indexj] * RGBvalues[k, m].R;
                            SumGx += Xmatrix[indexi, Indexj] * RGBvalues[k, m].G;
                            SumBx += Xmatrix[indexi, Indexj] * RGBvalues[k, m].B;


                            SumRy += Xmatrix[indexi, Indexj] * RGBvalues[k, m].R;
                            SumGy += Xmatrix[indexi, Indexj] * RGBvalues[k, m].G;
                            SumBy += Xmatrix[indexi, Indexj] * RGBvalues[k, m].B;


                            Indexj++;

                        }
                        indexi++;
                    }

                    double bt, gt, rt;

                    rt = Math.Sqrt((SumRx * SumRx) + (SumRy * SumRy));
                    gt = Math.Sqrt((SumGx * SumGx) + (SumGy * SumGy));
                    bt = Math.Sqrt((SumBx * SumBx) + (SumBy * SumBy));

                    //set limits, can hold values from 0 up to 255;
                    if (bt > 255) bt = 255;
                    else if (bt < 0) bt = 0;
                    if (gt > 255) gt = 255;
                    else if (gt < 0) gt = 0;
                    if (rt > 255) rt = 255;
                    else if (rt < 0) rt = 0;
                    ImageBitmap.SetPixel(i - 1, j - 1, Color.FromArgb((int)rt, (int)gt, (int)bt));
                }
            }
        }

        /// <summary>
        /// Normalize A value 
        /// </summary>
        /// <param name="Max"> Maximum Value </param>
        /// <param name="Min"> MiniMum Value </param>
        /// <param name="Value"> Value Want To Normalize </param>
        /// <returns>The Value After Applying Normalization</returns>
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

        public static Dictionary<double, int> ShowHistoGram( Bitmap bitmap)
        {
            Dictionary<double, int> Values = new Dictionary<double, int>();

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    if (Values.ContainsKey(bitmap.GetPixel(i , j).R))
                    {
                        Values[bitmap.GetPixel(i, j).R]++;
                    }
                    else
                    {
                        Values.Add(bitmap.GetPixel(i, j).R , 0);
                    }
                }
            }
            return Values;
        }
        public static PointF GetMinMax(Bitmap ImageBitmap)
        {
            float MinValue = float.MaxValue;
            float MaxValue = float.MinValue;
            for (int i = 0; i < ImageBitmap.Width; i++)
            {
                for (int j = 0; j < ImageBitmap.Height; j++)
                {
                    if (ImageBitmap.GetPixel(i , j).R > MaxValue)
                    {
                        MaxValue = ImageBitmap.GetPixel(i , j).R;
                    }

                    if (ImageBitmap.GetPixel(i , j).R < MinValue)
                    {
                        MinValue = ImageBitmap.GetPixel(i , j).R;
                    }
                }
            }
            return new PointF(MinValue, MaxValue);
        }
    }
}
