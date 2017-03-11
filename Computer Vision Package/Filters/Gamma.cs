using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlingClasses;
using System.Drawing;
using AdditionalForms;
using HelperFunctionality;

namespace Computer_Vision_Package.Filters
{
    class Gamma : Filter
    {
        Bitmap ImageBitMap;
        public override void ApplayFilter(_Image ApplayImage)
        {
           
            ImageBitMap = new Bitmap(ApplayImage.GetMainImage());
            Vector3d GammaRGB = FilterInputs[0] as Vector3d;
            SetGamma(GammaRGB.X , GammaRGB.Y , GammaRGB.Z);
            ApplayImage.SetFilterdBitMap(ref ImageBitMap);

        }

        public override string ToString()
        {
            return "Gamma Filter";
        }
        public void SetGamma(double red, double green, double blue)
        {
            Color c;
            byte[] redGamma = CreateGammaArray(red);
            byte[] greenGamma = CreateGammaArray(green);
            byte[] blueGamma = CreateGammaArray(blue);
            for (int i = 0; i < ImageBitMap.Width; i++)
            {
                for (int j = 0; j < ImageBitMap.Height; j++)
                {
                    c = ImageBitMap.GetPixel(i, j);
                    ImageBitMap.SetPixel(i, j, Color.FromArgb(redGamma[c.R],
                                           greenGamma[c.G], blueGamma[c.B]));
                }
            }
        }
        private byte[] CreateGammaArray(double color)
        {
            byte[] gammaArray = new byte[256];
            for (int i = 0; i < 256; ++i)
            {
                gammaArray[i] = (byte)Math.Min(255,
                    (int)((255.0 * Math.Pow(i / 255.0, 1.0 / color)) + 0.5));
            }
            return gammaArray;
        }

        public override bool HasAditionalForm()
        {
            return true;
        }

        public override void ShowFilterForm()
        {
            GammaFilterForm FilterForm = new GammaFilterForm();
            FilterForm.ShowDialog();

            FilterInputs = new List<object>();
            FilterInputs = FilterForm.FormAttribute;
        }
    }
}
