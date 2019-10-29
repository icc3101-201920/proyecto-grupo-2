using System;
using DlibDotNet;
using DlibDotNet.Extensions;
using Dlib = DlibDotNet.Dlib;
namespace PhotoMax
{
    public static class FaceDetector
    {
        public static void Recognize(string file)
        {
            using (var fd = Dlib.GetFrontalFaceDetector())
            {
                var img = Dlib.LoadImage<RgbPixel>(file);


                var faces = fd.Operator(img);

                foreach (var face in faces)
                {
                    // draw a rectangle for each face
                    Dlib.DrawRectangle(img, face, color: new RgbPixel(0, 255, 255), thickness: 4);
                }


                Dlib.SaveJpeg(img,file);

            }
        }


    }
    
}
