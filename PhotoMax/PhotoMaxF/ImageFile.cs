using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PhotoMaxF
{
    public class ImageFile
    {
        public ImageFile(string originPath)
        {
            Origin = originPath;
            Bpm = new Bitmap(Origin);
        }

        public string Origin { get; set; }
        public Bitmap Bpm { get; set; }
    }
}
