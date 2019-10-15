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
        // AGREGA TEXTO A LAS FOTOS [ S O L O   E S C R I B E ]
        // HAY QUE IMPLEMENTARLE COSAS
        public static void TEXT(Bitmap bitmap)

        {   string firstText = "Prueba de test2";
            

            PointF firstLocation = new PointF(40f, 40f);


            //string imageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../test2.jpg");
            //Bitmap imagenreal = new Bitmap(imageFilePath);
            //load the image file

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font arialFont = new Font("Arial",200))
                {
                    graphics.DrawString(firstText, arialFont, Brushes.Blue, firstLocation);
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


   
