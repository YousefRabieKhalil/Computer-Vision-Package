using HelperFunctionality;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Vision_Package
{
    public class _Image
    {
        private string ImageLocation;
        private Image MainImage, FilterdImage;
        public List<List<Vector3>> RGBVaues;
        public int ImageWidth, ImageHeight;
        private Bitmap ImageBitMap;
        private Bitmap FilterdImageBitMap;
        

        public _Image()
        {
            RGBVaues = new List<List<Vector3>>();
        }

        #region Setter And Getter

        public Bitmap GetFilterdImageBitMap()
        {
            return FilterdImageBitMap;
        }

        public void SetFilterdBitMap(ref Bitmap Filterd)
        {
            FilterdImageBitMap = Filterd;
        }
        /// <summary>
        /// Set The Image Location And Load Image Or not
        /// </summary>
        /// <param name="ImageLocation"> The Path For The Image </param>
        /// <param name="LoadImage"> Load Image Or Not </param>
        public void SetImageLocation(string ImageLocation , bool LoadImage)
        {
            this.ImageLocation = ImageLocation;
            if (LoadImage)
            {
                LoadImageFromLocation(ImageLocation);
            }
        }

        /// <summary>
        /// Get The Image Location
        /// </summary>
        /// <returns> The Image Location</returns>
        public string GetImageLocation()
        {
            return this.ImageLocation;
        }
        /// <summary>
        /// Return Image After Applay A filter
        /// </summary>
        /// <returns>The Image after Applay Some Filters</returns>
        public Image GetFilterdImage()
        {
            return FilterdImage;
        }

        /// <summary>
        /// Return The Image Without Any Filter
        /// </summary>
        /// <returns> The Image Without Any Filter</returns>
        public Image GetMainImage()
        {
            return MainImage;
        }
        /// <summary>
        /// set The Filted Image
        /// </summary>
        /// <param name="filterDImage"> Image After Applay Filter</param>
        public void SetFilterdImage(Image filterDImage)
        {
            this.FilterdImage = filterDImage;
        }
        #endregion


        /// <summary>
        /// Load The image From A specific Location 
        /// </summary>
        /// <param name="ImageLocation">The Location Of An image</param>
        public void LoadImageFromLocation(string ImageLocation)
        {
            MainImage = FilterdImage = Image.FromFile(ImageLocation);
            ImageBitMap = new Bitmap(MainImage);
            ImageWidth = ImageBitMap.Width;
            ImageHeight = ImageBitMap.Height;
        }

        /// <summary>
        /// This Function Calculate RGB Values And Put it in RGBvalues List
        /// </summary>
        private void CalculateRGBValues()
        {
            for (int i = 0; i < ImageBitMap.Width; i++)
            {
                List<Vector3> NewList = new List<Vector3>();
                for (int j = 0; j < ImageBitMap.Height; j++)
                {
                    NewList.Add(new Vector3(ImageBitMap.GetPixel(i, j).R, ImageBitMap.GetPixel(i, j).G, ImageBitMap.GetPixel(i, j).B));
                }
                RGBVaues.Add(NewList);
            }
        }
        /// <summary>
        /// Show An Image As Pixels In Picture Box
        /// </summary>
        /// <param name="WorkStation">The Picture Box Tool</param>
        public void ShowImageAsPixels(PictureBox WorkStation )
        {
            RGBVaues = new List<List<Vector3>>();
           
            for (int i = 0; i < ImageBitMap.Width; i++)
            { 
                for (int j = 0; j < ImageBitMap.Height; j++)
                {
                    // Complete it Please
                    using (Graphics g = WorkStation.CreateGraphics())
                    {
                        SolidBrush So = new SolidBrush(ImageBitMap.GetPixel(j, i));
                        g.FillRectangle(So , new RectangleF(j+  (j*3) , i + (i*3), 1 , 1));

                    }
                }
            }
        }

        public void ShowFilterdImageAsPixels(PictureBox WorkStation)
        {
            RGBVaues = new List<List<Vector3>>();
            
            for (int i = 0; i < FilterdImageBitMap.Width; i++)
            {
                for (int j = 0; j < FilterdImageBitMap.Height; j++)
                {
                    // Complete it Please
                    using (Graphics g = WorkStation.CreateGraphics())
                    {
                        SolidBrush So = new SolidBrush(FilterdImageBitMap.GetPixel(j, i));
                        g.FillRectangle(So, new RectangleF(j, i , 1, 1));

                    }
                }
            }
        }
        /// <summary>
        /// Check if The Image Will No make An Error Or Not
        /// </summary>
        public void PreprocessingStep()
        {
            if (ImageBitMap.Width != ImageBitMap.Height)
            {
                // Resize The image
                //MainImage
            }
        }

    }
}
