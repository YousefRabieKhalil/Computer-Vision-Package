using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlingClasses;
using System.Drawing;

namespace Computer_Vision_Package.Filters
{
    class RedColorFilter : Filter
    {
        public override void ApplayFilter(_Image ApplayImage)
        {
            Bitmap ImageBitMap = new Bitmap(ApplayImage.GetMainImage());

            Color c;
            for (int i = 0; i < ImageBitMap.Width; i++)
            {
                for (int j = 0; j < ImageBitMap.Height; j++)
                {
                    c = ImageBitMap.GetPixel(i, j);
                    int nPixelR = 0;
                    int nPixelG = 0;
                    int nPixelB = 0;

                    nPixelR = c.R;
                    nPixelG = c.G - 255;
                    nPixelB = c.B - 255;

                    nPixelR = Math.Max(nPixelR, 0);
                    nPixelR = Math.Min(255, nPixelR);

                    nPixelG = Math.Max(nPixelG, 0);
                    nPixelG = Math.Min(255, nPixelG);

                    nPixelB = Math.Max(nPixelB, 0);
                    nPixelB = Math.Min(255, nPixelB);


                    ImageBitMap.SetPixel(i, j, Color.FromArgb((byte)nPixelR,(byte)nPixelG, (byte)nPixelB));
                }
            }
            ApplayImage.SetFilterdBitMap(ref ImageBitMap);
        }

        public override bool HasAditionalForm()
        {
            return false;
        }

        public override void ShowFilterForm()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Red Color Filter";
        }

    }
}
