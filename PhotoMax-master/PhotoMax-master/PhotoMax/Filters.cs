using System;
using System.Drawing;





namespace PhotoMax
{
    [Serializable]
    public static class Filters
    {
        public static void Sepia(Bitmap bitmap)
        {
            int ancho = bitmap.Width;
            int alto = bitmap.Height;

            Color pixel;

            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    pixel = bitmap.GetPixel(x, y);

                    int alpha = pixel.A;
                    int rojo = pixel.R;
                    int verde = pixel.G;
                    int azul = pixel.B;

                    double promedio = (rojo + verde + azul) / 3;

                    Color sepia = Color.FromArgb((byte)promedio, (byte)(promedio * 0.95), (byte)(promedio * 0.82));

                    bitmap.SetPixel(x, y, sepia);

                }
            }
        }

        public static void GreyScale(Bitmap bitmap)
        {
            int ancho = bitmap.Width;
            int alto = bitmap.Height;

            Color pixel;

            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    pixel = bitmap.GetPixel(x, y);

                    int alpha = pixel.A;
                    int rojo = pixel.R;
                    int verde = pixel.G;
                    int azul = pixel.B;

                    int promedio = (rojo + verde + azul) / 3;

                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, promedio, promedio, promedio));
                }
            }
        }

        public static void Negative(Bitmap bitmap)
        {
            int ancho = bitmap.Width;
            int alto = bitmap.Height;

            Color pixel;

            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    pixel = bitmap.GetPixel(x, y);

                    int alpha = pixel.A;
                    int rojo = pixel.R;
                    int verde = pixel.G;
                    int azul = pixel.B;

                    double promedio = (rojo + verde + azul) / 3;

                    // valores negativos
                    rojo = 255 - alpha;
                    verde = 255 - verde;
                    azul = 255 - azul;

                    //crear filtro
                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, rojo, verde, azul));
                }
            }

        
        }
        public static void Acid(Bitmap bitmap)
        {
            int ancho = bitmap.Width;
            int alto = bitmap.Height;

            Color pixel;

            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    pixel = bitmap.GetPixel(x, y);

                    int alpha = pixel.A;
                    int rojo = pixel.R;
                    int verde = pixel.G;
                    int azul = pixel.B;

                    double promedio = (rojo + verde + azul) / 3;

                    // valores negativos
                    rojo = 255 - alpha;
                    verde = 255 - verde;
                    azul = 255 - azul;

                    //crear filtro
                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, verde, azul,rojo ));
                }
            }

        }

    }

}

    