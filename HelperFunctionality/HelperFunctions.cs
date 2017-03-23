using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelperFunctionality
{
    public class HelperFunctions
    {

        /// <summary>
        /// Multiple two Bitmap using Array Multiplication
        /// </summary>
        /// <param name="One"> The First Bitmap </param>
        /// <param name="Two"> The Second Bitmap </param>
        /// <returns> The Result OF multiplication </returns>
        public static Bitmap MultibleTwoImage(Bitmap One , Bitmap Two)
        {
            Bitmap bitmap = One;
            float[,] Arrayone = new float[One.Height, One.Width];
            float[,] ArrayTwo = new float[One.Height, One.Width];

            for (int i = 0; i < One.Height; i++)
            {
                for (int j = 0; j < One.Width; j++)
                {
                    Arrayone[i, j] = One.GetPixel(i, j).R;
                    ArrayTwo[i, j] = Two.GetPixel(i, j).R;
                }
            }

            int[,] ApplyedMultiplication = SobelsFilterMul(Arrayone, ArrayTwo, One.Width);

            for (int i = 0; i < One.Height; i++)
            {
                for (int j = 0; j < One.Width; j++)
                {
                    int Rvalue = ApplyedMultiplication[i, j];

                    if (Rvalue > 255)
                        Rvalue = 255;
                    else if (Rvalue < 0)
                        Rvalue = 0;

                    bitmap.SetPixel(i, j, Color.FromArgb(Rvalue , Rvalue , Rvalue));
                }
            }

            return bitmap;



         }


        /// <summary>
        /// Multiple Two float Array (Equal Size)
        /// </summary>
        /// <param name="SobelVertical"> First Array </param>
        /// <param name="SobelHorizontal"> Second Array </param>
        /// <param name="size"> Size OF Array </param>
        /// <returns></returns>
        public static int[,] SobelsFilterMul(float[,] SobelVertical, float[,] SobelHorizontal, int size)
        {
            int[,] SobelsMulOutput = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    SobelsMulOutput[j, i] = (int)(SobelVertical[j, i] * SobelHorizontal[j, i]);
                }
            }
            return SobelsMulOutput;
        }

        /// <summary>
        /// Mask Two Image Mean Multiply two Image using Bitmap Method
        /// </summary>
        /// <param name="SrcBitmap1"> Image Bitmap 1 </param>
        /// <param name="SrcBitmap2"> Image Bitmap 2 </param>
        /// <param name="Message"> Exception Message </param>
        /// <returns> The Result Of Multiplication </returns>
        public static Bitmap MultibleTwoImage(Bitmap SrcBitmap1, Bitmap SrcBitmap2, out string Message)
        {
            int width;
            int height;

            Message = "";

            if (SrcBitmap1.Width < SrcBitmap2.Width)
                width = SrcBitmap1.Width;
            else
                width = SrcBitmap2.Width;

            if (SrcBitmap1.Height < SrcBitmap2.Height)
                height = SrcBitmap1.Height;
            else
                height = SrcBitmap2.Height;

            Bitmap bitmap = new Bitmap(width, height);
            int clr1, clr2;

            try
            {
                BitmapData Src1Data = SrcBitmap1.LockBits(new Rectangle(0, 0, SrcBitmap1.Width, SrcBitmap1.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

                BitmapData Src2Data = SrcBitmap2.LockBits(new Rectangle(0, 0, SrcBitmap2.Width, SrcBitmap2.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

                BitmapData DestData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);


                int xOffset = 3;
                unsafe
                {
                    for (int col = 0; col < bitmap.Height - 1; col++)
                    {
                        byte* Src1Ptr = (byte*)Src1Data.Scan0 + col * Src1Data.Stride;
                        byte* Src2Ptr = (byte*)Src2Data.Scan0 + col * Src2Data.Stride;
                        byte* DestPtr = (byte*)DestData.Scan0 + col * DestData.Stride;

                        for (int row = 0; row < bitmap.Width - 1; row++)
                        {
                            clr1 = (Src1Ptr[row * xOffset] + Src1Ptr[row * xOffset + 1] + Src1Ptr[row * xOffset + 2]) / 3;
                            clr2 = (Src2Ptr[row * xOffset] + Src2Ptr[row * xOffset + 1] + Src2Ptr[row * xOffset + 2]) / 3;

                            clr1 *= clr2;

                            if (clr1 == 0)
                            {
                                DestPtr[row * xOffset] = (byte)(0);
                                DestPtr[row * xOffset + 1] = (byte)(0);
                                DestPtr[row * xOffset + 2] = (byte)(0);
                            }
                            else
                            {
                                DestPtr[row * xOffset] = (byte)(Src2Ptr[row * xOffset]);
                                DestPtr[row * xOffset + 1] = (byte)(Src2Ptr[row * xOffset + 1]);
                                DestPtr[row * xOffset + 2] = (byte)(Src2Ptr[row * xOffset + 2]);
                            }
                        }
                    }
                }

                bitmap.UnlockBits(DestData);
                SrcBitmap1.UnlockBits(Src1Data);
                SrcBitmap2.UnlockBits(Src2Data);

                SrcBitmap1.Dispose();
                SrcBitmap2.Dispose();
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }

            return bitmap;
        }
        /// <summary>
        /// To Build A Gaussian Matrix From Kernel Size 
        /// </summary>
        /// <param name="Size"> The Size Of Kernel </param>
        /// <returns> The Gaussian Matrix </returns>

        public static double[,] BuildGaussianMatrix(int Size  , double Sigma)
        {
            double sigma = Sigma;
            int W = Size;
            double[,] kernel = new double[W,W];
            double mean = W / 2;
            double sum = 0.0; // For accumulating the kernel values

            for (int x = 0; x < W; ++x)
            {
                for (int y = 0; y < W; ++y)
                {
                    kernel[x, y] = Math.Exp(-0.5 * (Math.Pow((x - mean) / sigma, 2.0) + Math.Pow((y - mean) / sigma, 2.0)))
                                     / (2 * Math.PI * sigma * sigma);

                    // Accumulate the kernel values
                    sum += kernel[x, y];
                }
            }

            // Normalize the kernel
            for (int x = 0; x < W; ++x)
                for (int y = 0; y < W; ++y)
                    kernel[x,y] /= sum;

            return kernel;
        }

        /// <summary>
        /// Applay Padding using marshal Conversion
        /// </summary>
        /// <param name="ImageBitMap"> The Bit Map Want to Padding </param>
        /// <param name="KernalSize"> The Size Padding Items </param>
        /// <param name="NewWidth"> out of the new width of bitmap </param>
        /// <param name="Newheight"> out pf the new height of bitmap </param>
        /// <returns> The New image value after applay padding </returns>
        public static Vector3[,] PaddingWithSimpleImplement(Bitmap ImageBitMap, int KernalSize, out int NewWidth, out int Newheight)
        {
            int w = ImageBitMap.Width;
            int h = ImageBitMap.Height;
            int wp = w + 2 * KernalSize;
            int hp = h + 2 * KernalSize;

            NewWidth = wp;
            Newheight = hp;
            Vector3[,] RGBvalues = new Vector3[hp , wp];

            Bitmap ri = new Bitmap(wp, hp);
            BitmapData rd = ri.LockBits(new Rectangle(0, 0, wp, hp),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            BitmapData id = ImageBitMap.LockBits(new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int imgb = id.Stride * id.Height;
            int borb = rd.Stride * rd.Height;
            byte[] imga = new byte[imgb];
            byte[] bora = new byte[borb];
            for (int i = 3; i < borb; i += 4)
            {
                bora[i] = 255;
            }
            Marshal.Copy(id.Scan0, imga, 0, imgb);
            ImageBitMap.UnlockBits(id);
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    int ip = y * id.Stride + x * 4;
                    int rp = y * rd.Stride + x * 4;
                    for (int i = 0; i < 3; i++)
                    {
                        bora[(rd.Stride + 4) * KernalSize + rp + i] = imga[ip + i];
                    }
                }
            }
            Marshal.Copy(bora, 0, rd.Scan0, borb);
            ri.UnlockBits(rd);


            for (int i = 0; i < hp; i++)
            {
                for (int j = 0; j < wp; j++)
                {
                    RGBvalues[i , j] = new Vector3(ri.GetPixel(j, i).R, ri.GetPixel(j, i).G, ri.GetPixel(j, i).B);
                }
            }

            return RGBvalues;
        }

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

                    if (   (i >= 0 && i < ((int)KernalSize / 2))
                        || (j >= 0 && j < ((int)KernalSize / 2))
                        || (i > ImageBitMap.Height && i < Newheight)
                        || (j > ImageBitMap.Width && j < NewWidth)
                        )

                    {
                        RGBvalues[i, j] = new Vector3(0, 0, 0);
                    }
                    else
                    {
                        

                        int Iindex = j - (((int)KernalSize / 2));
                        int Jindex = i - ((int)KernalSize / 2);

                        //if (Jindex >= Newheight)
                        //    Jindex = Newheight - 1;
                        //if (Iindex >= NewWidth)
                        //    Iindex = NewWidth - 1;

                        Color CurentBitmapPixel = ImageBitMap.GetPixel(Iindex ,Jindex );
                        RGBvalues[i, j] = new Vector3(CurentBitmapPixel.R , CurentBitmapPixel.G , CurentBitmapPixel.B);
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

                    if (SumB > 255) SumB = 255;
                    else if (SumB < 0) SumB = 0;
                    if (SumG > 255) SumG = 255;
                    else if (SumG < 0) SumG = 0;
                    if (SumR > 255) SumR = 255;
                    else if (SumR < 0) SumR = 0;
                    ImageBitmap.SetPixel(j - 1, i - 1, Color.FromArgb((int)SumR, (int)SumG, (int)SumB));
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
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (RGBvalues[i, j].R == 0 && RGBvalues[i, j].G == 0 && RGBvalues[i, j].B == 0)
                        Console.Write("0");
                    else
                        Console.Write("A");
                }
                Console.WriteLine();
            }
            //Vector3 MinVector = GetMin(RGBvalues, width, height);
            //Vector3 MaxVector = GetMax(RGBvalues, width, height);
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
                    ImageBitmap.SetPixel(j - 1, i - 1, Color.FromArgb((int)rt, (int)gt, (int)bt));
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
        /// <summary>
        /// Show the Histograph for specifed Image
        /// </summary>
        /// <param name="bitmap"> Image Bitmap Want To Show Histogram For </param>
        /// <returns>  </returns>
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
