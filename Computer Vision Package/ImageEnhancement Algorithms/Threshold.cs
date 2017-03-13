using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlingClasses;
using AdditionalForms;
using System.Drawing;
using System.Windows.Forms;

namespace Computer_Vision_Package.ImageEnhancement_Algorithms
{
    class Threshold : ImageEnhancement
    {

        double FormInput;
        Bitmap bitmap;
        PointF MinMax;
        public override void ApplayEnhancement(_Image ApplayImage)
        {
            bitmap = new Bitmap(ApplayImage.GetMainImage());
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    if (bitmap.GetPixel(i , j).R > FormInput)
                        bitmap.SetPixel(i , j, Color.FromArgb(255, 255, 255));
                    else
                        bitmap.SetPixel(i , j, Color.FromArgb(0, 0, 0));
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
            
            EnhancementThreshold Enf = new EnhancementThreshold();
            Enf = new EnhancementThreshold();
            Enf.ShowDialog();
            FormInput = Enf.Threshold;
        }

        public override string ToString()
        {
            return "Threshold";
        }
    }
}
