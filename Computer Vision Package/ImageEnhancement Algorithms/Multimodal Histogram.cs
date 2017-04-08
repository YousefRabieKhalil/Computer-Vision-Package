using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlingClasses;
using AdditionalForms;
using System.Drawing;

namespace Computer_Vision_Package.ImageEnhancement_Algorithms
{
    class Multimodal_Histogram : ImageEnhancement
    {

        double ThresholdStart, ThresholdEnd, DefultValue;

        public override void ApplayEnhancement(_Image ApplayImage)
        {
            ApplayImage.CalculateRGBValues();
            Bitmap NewBitMap = new Bitmap(ApplayImage.GetMainImage());
            for (int i = 0; i < ApplayImage.ImageHeight; i++)
            {
                for (int j = 0; j < ApplayImage.ImageWidth; j++)
                {
                    if (ApplayImage.RGBVaues[j][i].R < ThresholdStart)
                    {
                        NewBitMap.SetPixel(j, i, Color.FromArgb(0, 0, 0));
                    }
                    else if (ApplayImage.RGBVaues[j][i].R > ThresholdEnd)
                    {
                        NewBitMap.SetPixel(j, i, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        NewBitMap.SetPixel(j, i, Color.FromArgb((int)DefultValue, (int)DefultValue, (int)DefultValue));
                    }
                }
            }
            ApplayImage.SetFilterdBitMap(ref NewBitMap);
        }

        public override bool HasAditionalForm()
        {
            return true;
        }

        public override void ShowEnhancementForm()
        {
            MultimodalHistogramForm NewForm = new MultimodalHistogramForm();
            NewForm.ShowDialog();
            ThresholdStart = NewForm.ThresholdStart;
            ThresholdEnd = NewForm.ThresoldEnd;
            DefultValue = NewForm.DefultValue;
        }

        public override string ToString()
        {
            return "Multimodel-Histogram";
        }
    }
}
