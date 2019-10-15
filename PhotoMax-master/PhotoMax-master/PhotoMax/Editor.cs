using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
 


namespace PhotoMax
{
    [Serializable]
    public static class Editor
    {

        public static void TEXT(Bitmap bitmap, string itText, string itColour, int itFontSize, int itXCoordinates, int itYCoordinates)

        {   string firstText = itText;
            
            PointF firstLocation = new PointF(itXCoordinates, itYCoordinates);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font arialFont = new Font("Arial",itFontSize))
                {
                    graphics.DrawString(firstText, arialFont, Brushes.IndianRed, firstLocation);
                }
            }
            //bitmap.Save(imageFilePath);//save the image file
        }

        public static void ApplySepia(Bitmap image)
        {   
            Filters.Sepia(image);
        }

        public static void ApplyGreyScale(Bitmap image)
        {
            Filters.GreyScale(image);
        }

        public static void ApplyNegative(Bitmap image)
        {
            Filters.Negative(image);
        }

        public static void ApplyAcid(Bitmap image)
        {
            Filters.Acid(image);
        }

        public static void ApplyDiamondWaffle(Bitmap image)
        {
            Filters.Acid(image);
            Filters.Sepia(image);
            Filters.Negative(image);
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }
    }

}


   
