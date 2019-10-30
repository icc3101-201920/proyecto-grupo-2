using System;
using System.Drawing;
using System.Linq;
using ExifLib;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System.IO;
using PhotoMaxF.InputOutput;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace PhotoMaxF
{
    class Program
    {
        static void Main(string[] args)
        {
            Launcher launcher = new Launcher();
            launcher.Launch();
        }
    }
}