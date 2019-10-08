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

        {   string firstText = "Prueba de pintua";
            

            PointF firstLocation = new PointF(40f, 40f);


            //string imageFilePath = "C:/Users/Francisco/Desktop/proyecto-grupo-2/PhotoMax-master/PhotoMax-master/PhotoMax/Pintua.jpg";
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
        {   // imagen nueva hace una copia de la imagen original.
            // filters crea la instancia para poder ocupar filtros
            //filters.sepia(imagenNueva) aplica el filtro y hace que imagennueva este editada.

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


   
