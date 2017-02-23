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
        public static Vector3[,] Padding(Bitmap ImageBitMap , int KernalSize, out int NewWidth, out int Newheight)
        {
            NewWidth = ImageBitMap.Width + 2 * ((int)KernalSize / 2);
            Newheight = ImageBitMap.Height + 2 * ((int)KernalSize / 2);

            Vector3[,] RGBvalues = new Vector3[Newheight, NewWidth];
            for (int i = 0; i < Newheight; i++)
            {
                for (int j = 0; j < NewWidth; j++)
                {

                    if (   (i >= 0 && i < ((int)KernalSize / 2))
                        || ( j >= 0 && j < ((int)KernalSize / 2))
                        || ( i >= Newheight - ((int)KernalSize / 2) && i < Newheight)
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
    }
}
