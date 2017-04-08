using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlingClasses;
using AdditionalForms;
using HelperFunctionality;
using System.Drawing;

namespace Computer_Vision_Package.Filters
{
    class Bimodal_threshold : ImageEnhancement
    {
        double T0, T1;

        public override void ApplayEnhancement(_Image ApplayImage)
        {
            ApplayImage.CalculateRGBValues();
            List<double> Group1 = new List<double>();
            List<double> Group2 = new List<double>();
            double OldT = 0;
            while (T0 < Math.Abs(T1 - OldT))
            {
                Group1 = new List<double>();
                Group2 = new List<double>();
                for (int i = 0; i < ApplayImage.ImageHeight; i++)
                {
                    for (int j = 0; j < ApplayImage.ImageWidth; j++)
                    {
                        if (ApplayImage.RGBVaues[j][i].R > T1)
                        {
                            Group1.Add(ApplayImage.RGBVaues[j][i].R);
                        }
                        else
                        {
                            Group2.Add(ApplayImage.RGBVaues[j][i].R);
                        }
                    }
                }
                OldT = T1;
                double Mean1 = Group1.Sum() / Group1.Count;
                double Mean2 = Group2.Sum() / Group2.Count;

                T1 = 0.5 * (Mean1 + Mean2);
                Console.WriteLine(T1.ToString());
            }
            Bitmap NewImage = new Bitmap(ApplayImage.GetMainImage());
            for (int i = 0; i < ApplayImage.ImageHeight; i++)
            {
                for (int j = 0; j < ApplayImage.ImageWidth; j++)
                {
                    if (ApplayImage.RGBVaues[j][i].R > T1)
                    {
                        NewImage.SetPixel(j, i, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        NewImage.SetPixel(j, i, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            ApplayImage.SetFilterdBitMap(ref NewImage);
        }

        public override bool HasAditionalForm()
        {
            return true;
        }

        public override void ShowEnhancementForm()
        {
            BimodalThresholdForm NewForm = new BimodalThresholdForm();
            NewForm.ShowDialog();
            T0 = NewForm.Value0;
            T1 = NewForm.Value1;
        }
        public override string ToString()
        {
            return "Bomodal-Threshold";
        }
    }
}
