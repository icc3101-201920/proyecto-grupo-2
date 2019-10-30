using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace PhotoMaxF
{
    [Serializable]
    public static class Filters
    {
        public static Bitmap Sepia(Bitmap originalBmp)
        {
            RectangleF cloneRect = new RectangleF(0, 0, originalBmp.Width, originalBmp.Height);
            System.Drawing.Imaging.PixelFormat format =
                originalBmp.PixelFormat;
            Bitmap bmp = originalBmp.Clone(cloneRect, format);

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            // The colors here are in BGRA order and not RGBA  
            for (int counter = 0; counter < rgbValues.Length; counter += 4)
            {
                int b = rgbValues[counter];
                int g = rgbValues[counter + 1];
                int r = rgbValues[counter + 2];
                rgbValues[counter] = (byte)max255((r * .272) + (g * .534) + (b * .131));
                rgbValues[counter + 1] = (byte)max255((r * .349) + (g * .686) + (b * .168));
                rgbValues[counter + 2] = (byte)max255((r * .393) + (g * .769) + (b * .189));

            }

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            bmp.UnlockBits(bmpData);
            return bmp;
        }

        public static Bitmap GreyScale(Bitmap originalBmp)
        {
            RectangleF cloneRect = new RectangleF(0, 0, originalBmp.Width, originalBmp.Height);
            System.Drawing.Imaging.PixelFormat format =
                originalBmp.PixelFormat;
            Bitmap bmp = originalBmp.Clone(cloneRect, format);

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            // The colors here are in BGRA order and not RGBA  
            for (int counter = 0; counter < rgbValues.Length; counter += 4)
            {
                int b = rgbValues[counter];
                int g = rgbValues[counter + 1];
                int r = rgbValues[counter + 2];
                double average = (b + g + r) / 3;
                rgbValues[counter] = (byte)average;
                rgbValues[counter + 1] = (byte)average;
                rgbValues[counter + 2] = (byte)average;

            }

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            bmp.UnlockBits(bmpData);
            return bmp;
        }

        public static Bitmap Negative(Bitmap originalBmp)
        {
            RectangleF cloneRect = new RectangleF(0, 0, originalBmp.Width, originalBmp.Height);
            System.Drawing.Imaging.PixelFormat format =
                originalBmp.PixelFormat;
            Bitmap bmp = originalBmp.Clone(cloneRect, format);

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            // The colors here are in BGRA order and not RGBA 
            for (int counter = 0; counter < rgbValues.Length; counter += 4)
            {
                int b = rgbValues[counter];
                int g = rgbValues[counter + 1];
                int r = rgbValues[counter + 2];
                rgbValues[counter] = (byte)(255 - b);
                rgbValues[counter + 1] = (byte)(255 - g);
                rgbValues[counter + 2] = (byte)(255 - r);

            }

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            bmp.UnlockBits(bmpData);
            return bmp;
        }

        public static Bitmap Blossom(Bitmap originalBmp)
        {
            originalBmp = Negative(originalBmp);

            RectangleF cloneRect = new RectangleF(0, 0, originalBmp.Width, originalBmp.Height);
            System.Drawing.Imaging.PixelFormat format =
                originalBmp.PixelFormat;
            Bitmap bmp = originalBmp.Clone(cloneRect, format);

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            // The colors here are in BGRA order and not RGBA 
            for (int counter = 0; counter < rgbValues.Length; counter += 4)
            {
                int b = rgbValues[counter];
                int g = rgbValues[counter + 1];
                int r = rgbValues[counter + 2];
                rgbValues[counter] = (byte)(r);
                rgbValues[counter + 1] = (byte)(60);
                rgbValues[counter + 2] = (byte)(b);

            }

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            bmp.UnlockBits(bmpData);
            return bmp;
        }

        public static Bitmap OldMovie(Bitmap originalBmp)
        {
            Bitmap bmp = Blossom(originalBmp);
            bmp = Negative(bmp);
            bmp = Sepia(bmp);
            return bmp;
        }
        public static double max255(double c)
        {
            if (c > 255)
            {
                return 255;
            }
            else
            {
                return c;
            }
        }
    }

}

    