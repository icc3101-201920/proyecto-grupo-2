﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;

namespace PhotoMaxF
{
    [Serializable]
    public static class Editor
    {
        public static Bitmap TEXT(Bitmap originalBmp, string itText, string itColour, int itFontSize, int itXCoordinates, int itYCoordinates)

        {
            RectangleF cloneRect = new RectangleF(0, 0, originalBmp.Width, originalBmp.Height);
            System.Drawing.Imaging.PixelFormat format =
                originalBmp.PixelFormat;
            Bitmap bitmap = originalBmp.Clone(cloneRect, format);

            string firstText = itText;
            
            PointF firstLocation = new PointF(itXCoordinates, itYCoordinates);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font arialFont = new Font("Arial",itFontSize))
                {
                    if (itColour == "Black") { graphics.DrawString(firstText, arialFont, Brushes.Black, firstLocation); }
                    if (itColour == "White") { graphics.DrawString(firstText, arialFont, Brushes.White, firstLocation); }
                    if (itColour == "Red") { graphics.DrawString(firstText, arialFont, Brushes.Red, firstLocation); }
                    if (itColour == "Green") { graphics.DrawString(firstText, arialFont, Brushes.Green, firstLocation); }
                    if (itColour == "Blue") { graphics.DrawString(firstText, arialFont, Brushes.Blue, firstLocation); }
                    if (itColour == "Gray") { graphics.DrawString(firstText, arialFont, Brushes.Gray, firstLocation); }
                }
            }
            return bitmap;
        }

        public static Bitmap Fusion(List<Bitmap> bmpList)
        {

            Console.WriteLine("\nThis may take a while, please wait...\n");

            int w = (from bmpx in bmpList select (bmpx.Width * bmpx.Height)).Min();
            Bitmap smallerBmp = (from bmpx in bmpList where (bmpx.Width * bmpx.Height) == w select bmpx).ToList()[0];

            RectangleF cloneRectS = new RectangleF(0, 0, smallerBmp.Width, smallerBmp.Height);
            System.Drawing.Imaging.PixelFormat formatS =
                smallerBmp.PixelFormat;
            Bitmap bmp = smallerBmp.Clone(cloneRectS, formatS);

            foreach (Bitmap i in bmpList) { i.SetResolution(bmp.Width, bmp.Height);}

            List<Bitmap> bmpListClone = new List<Bitmap>();
            foreach (Bitmap i in bmpList)
            {
                if (i.Width < bmp.Width && i.Height > bmp.Height)
                {
                    Rectangle cloneRect = new Rectangle(0, 0, i.Width, bmp.Height);
                    System.Drawing.Imaging.PixelFormat format =
                        i.PixelFormat;
                    bmpListClone.Add(i.Clone(cloneRect, format));
                }
                if (i.Width < bmp.Width && i.Height < bmp.Height)
                {
                    Rectangle cloneRect = new Rectangle(0, 0, bmp.Width, i.Height);
                    System.Drawing.Imaging.PixelFormat format =
                        i.PixelFormat;
                    bmpListClone.Add(i.Clone(cloneRect, format));
                }
                if (i.Width < bmp.Width && i.Height < bmp.Height)
                {
                    Rectangle cloneRect = new Rectangle(0, 0, i.Width, i.Height);
                    System.Drawing.Imaging.PixelFormat format =
                        i.PixelFormat;
                    bmpListClone.Add(i.Clone(cloneRect, format));
                }
                else
                {
                    Rectangle cloneRect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                    System.Drawing.Imaging.PixelFormat format =
                        i.PixelFormat;
                    bmpListClone.Add(i.Clone(cloneRect, format));
                }
            }


            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    int r = 0;
                    int g = 0;
                    int b = 0;

                    foreach (Bitmap i in bmpListClone)
                    {
                        r += i.GetPixel(x, y).R;
                        g += i.GetPixel(x, y).G;
                        b += i.GetPixel(x, y).B;
                    }

                    int avrgR = (r) / bmpListClone.Count;
                    int avrgG = (g) / bmpListClone.Count;
                    int avrgB = (b) / bmpListClone.Count;

                    bmp.SetPixel(x, y, Color.FromArgb(avrgR, avrgG, avrgB));
                }
            }
            return bmp;
        }

        //REQUIRED FOR FUSION
        public static string getSmallerImage(List<string> imgList)
        {
            List<Bitmap> imgBMPList = new List<Bitmap>();
            for (int f = 0; f < imgList.Count; f++)
            {
                imgBMPList.Add(new Bitmap(imgList[f]));
            }

            int w = (from bmpx in imgBMPList select (bmpx.Width * bmpx.Height)).Min();
            Bitmap bmp = (from bmpx in imgBMPList where (bmpx.Width * bmpx.Height) == w select bmpx).ToList()[0];

            for (int f = 0; f < imgBMPList.Count; f++)
            {
                if (imgBMPList[f] == bmp)
                {
                    string smallerImage = imgList[f];
                    return smallerImage;
                }
            }

            return "/%void%/";
        }
    }

}


   
