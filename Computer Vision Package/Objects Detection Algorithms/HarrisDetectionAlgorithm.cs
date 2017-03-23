using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlingClasses;
using Computer_Vision_Package.Filters;
using System.Drawing;
using System.Drawing.Imaging;
using HelperFunctionality;

namespace Computer_Vision_Package.Objects_Detection_Algorithms
{
    class HarrisDetectionAlgorithm : ObjectDetectionAlgorithm
    {
        Image MainImage;
        Bitmap ImageBitMap;
        public override void ApplayObjectDetection(_Image ApplayImage)
        {
            _Image XsobelImage = new _Image();
            XsobelImage.SetImageLocation(ApplayImage.ImageLocation, true);
            // Applaying x-Sobel Opreator
            X_Sobel xsolbel = new X_Sobel();
            xsolbel.ApplayFilter(XsobelImage);



            _Image YsobelImage = new _Image();
            YsobelImage.SetImageLocation(ApplayImage.ImageLocation, true);
            // Applaying Y-sobel Opreator
            Y_Sobel ysobel = new Y_Sobel();
            ysobel.ApplayFilter(YsobelImage);
 

           double[,] XsolbelArray =  SquerBitmap(XsobelImage.GetFilterdImageBitMap());
           double[,] YsolbelArray = SquerBitmap(YsobelImage.GetFilterdImageBitMap());


            YsobelImage.ReplaceMainImageWithiltedImage();
            XsobelImage.ReplaceMainImageWithiltedImage();


            // Get The Multipication OF 2 Image
            string Message = "";
            Bitmap MultBitMap =  HelperFunctions.MaskImagePtr(XsobelImage.GetFilterdImageBitMap(), YsobelImage.GetFilterdImageBitMap() , out Message);
            _Image MultiImage = new _Image();
            MultiImage.SetFilterdBitMap(ref MultBitMap);
            MultiImage.ReplaceMainImageWithiltedImage();

            // Applay Gaussian Filter
            GaussianFilter NewFilter = new GaussianFilter();
            NewFilter.Sigma = 2;
            NewFilter.KernalSize = 7;
            NewFilter.ApplayFilter(XsobelImage);
            NewFilter.ApplayFilter(YsobelImage);
            NewFilter.ApplayFilter(MultiImage);


            Bitmap SobelXBitMap = XsobelImage.GetFilterdImageBitMap();
            Bitmap SobelyBitMap = YsobelImage.GetFilterdImageBitMap();

            MainImage = ApplayImage.GetMainImage();
            ImageBitMap = new Bitmap(MainImage);
            int imageWidth = ApplayImage.ImageWidth, ImageHieght = ApplayImage.ImageHeight;
          
            double[,] Result = new double[ImageHieght, imageWidth];
            double[,] R = new double[ImageHieght, imageWidth];
            double Rmax = double.MinValue;
            for (int i = 0; i < ImageHieght; i++)
            {
                for (int j = 0; j < imageWidth; j++)
                {
                    double det = (SobelXBitMap.GetPixel(i, j).R * SobelyBitMap.GetPixel(i, j).R) - (MultBitMap.GetPixel(i, j).R * MultBitMap.GetPixel(i, j).R);
                    double trace = (SobelXBitMap.GetPixel(i,j).R + SobelyBitMap.GetPixel(i,j).R);

                    R[i, j] = det - (trace * trace / 100);

                    if (R[i, j] > Rmax)
                        Rmax = R[i, j];

                    //int RGB = (int)R[i, j];
                    //ImageBitMap.SetPixel(i, j, Color.FromArgb(RGB , RGB , RGB));
                }
            }
            int count = 0;
            for (int i = 2; i < ImageHieght-1; i++)
            {
                for (int j = 2; j < imageWidth-1; j++)
                {
                    if ((R[i, j] > Rmax / 10) && (R[i, j] > R[i - 1, j - 1]) && (R[i, j] > R[i - 1, j]) && (R[i, j] > R[i - 1, j + 1]) && (R[i, j] > R[i, j - 1]) && (R[i, j] > R[i, j + 1]) && (R[i, j] > R[i + 1, j - 1]) && (R[i, j] > R[i + 1, j]) && (R[i, j] > R[i + 1, j + 1]))
                    {
                        ImageBitMap.SetPixel(i, j, Color.Red);
                        count++;

                    }

                    //if (R[i, j] > 0.1 * Rmax && R[i, j] > R[i - 1, j - 1] && R[i, j] > R[i - 1, j] && R[i, j] > R[i - 1, j + 1] && R[i, j] > R[i, j - 1] && R[i, j] > R[i, j + 1] && R[i, j] > R[i + 1, j - 1] && R[i, j] > R[i + 1, j] && R[i, j] > R[i + 1, j + 1])
                    //{
                    //    //Result[i, j] = 1;
                    //    ImageBitMap.SetPixel(i, j, Color.Red);
                    //    count++;
                    //}
                }
            }
            Console.WriteLine(count);
            ApplayImage.SetFilterdBitMap(ref ImageBitMap);

        }

        public override bool HasAditionalForm()
        {
            return false;
        }

        public override void ShowEnhancementForm()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Harris-Object Detection Algorithm";
        }

        private double[,] SquerBitmap(Bitmap bitmap)
        {
            double[,] Arr = new double[bitmap.Height, bitmap.Width];
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                //    int NewR = bitmap.GetPixel(i, j).R * bitmap.GetPixel(i, j).R;
                //    int NewG = bitmap.GetPixel(i, j).G * bitmap.GetPixel(i, j).G;
                //    int NewB = bitmap.GetPixel(i, j).B * bitmap.GetPixel(i, j).B;

                //    if (NewB > 255) NewB = 255;
                //    else if (NewB < 0) NewB = 0;
                //    if (NewG > 255) NewG = 255;
                //    else if (NewG < 0) NewG = 0;
                //    if (NewR > 255) NewR = 255;
                //    else if (NewR < 0) NewR = 0;

                //    bitmap.SetPixel(i, j, Color.FromArgb(NewR, NewG, NewB));

                    Arr[i, j] = bitmap.GetPixel(i, j).R * bitmap.GetPixel(i, j).R;
                }
            }
            return Arr;
        }
        
    }
}
