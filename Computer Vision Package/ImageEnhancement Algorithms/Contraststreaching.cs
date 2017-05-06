using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlingClasses;
using AdditionalForms;
using System.Drawing;

namespace Computer_Vision_Package
{
   
    class Contraststreaching : ImageEnhancement
    {
        double FormInput;
        public override void ApplayEnhancement(_Image ApplayImage)
        {
            Bitmap bitmap = new Bitmap(ApplayImage.GetMainImage());
            PointF MinMax = HelperFunctionality.HelperFunctions.GetMinMax(bitmap);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    double PixelValue = bitmap.GetPixel(i, j).R;
                    int floatValue = (int)Math.Round(((Math.Pow(2, FormInput)-1) * ((PixelValue - MinMax.X) / (MinMax.Y - MinMax.X))));
                    bitmap.SetPixel(i, j,Color.FromArgb(floatValue , floatValue , floatValue));
                }
            }
            ApplayImage.SetFilterdBitMap(ref bitmap);

        }

        public override bool HasAditionalForm()
        {
            return true;

        }

        public override void ShowEnhancementForm()
        {
            ContrastStreaching F = new ContrastStreaching();
            F.ShowDialog();
            FormInput = F.BitPerPixel;
        }

        public override string ToString()
        {
            return "Contrast Streacing";
        }
    }
}
