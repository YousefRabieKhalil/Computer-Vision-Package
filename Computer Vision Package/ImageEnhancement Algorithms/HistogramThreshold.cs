using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlingClasses;
using System.Drawing;

namespace Computer_Vision_Package.ImageEnhancement_Algorithms
{
    class HistogramThreshold : ImageEnhancement
    {
        public override void ApplayEnhancement(_Image ApplayImage)
        {
            Bitmap ImageBitmap = new Bitmap(ApplayImage.GetMainImage());
            Dictionary<double, int> values = HelperFunctionality.HelperFunctions.ShowHistoGram(ImageBitmap);
            int MaxValue = values.Values.Max();
            double ThresholdValue = values.FirstOrDefault(x => x.Value == MaxValue).Key;

            for (int i = 0; i < ApplayImage.ImageHeight; i++)
            {
                for (int j = 0; j < ApplayImage.ImageWidth; j++)
                { 
                    if (ImageBitmap.GetPixel(j , i).R > ThresholdValue)
                    {
                        ImageBitmap.SetPixel(j, i, Color.FromArgb(255, 255, 255));
                    }
                    else if (ImageBitmap.GetPixel(j ,i ).R < ThresholdValue)
                    {
                        ImageBitmap.SetPixel(j, i, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            ApplayImage.SetFilterdBitMap(ref ImageBitmap);

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
            return "Histgram-Threshold";
        }
    }
}
