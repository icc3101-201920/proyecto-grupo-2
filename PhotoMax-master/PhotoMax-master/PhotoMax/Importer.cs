﻿using PhotoMax.InputOutput;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace PhotoMax
{
    public class Importer
    {
        public Importer()
        {
            // LIST OF SEARCH OPTIONS
            ImportList = new List<string>()
            {
                "Exit PhotoMax",
                "Import file by path location",
                "Import multiple files by directory location",
                "Select image to work with from Import folder",
                "D"
            };

            importDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../PM-Images/Imports");
        }


        public List<string> ImportList { get; set; }
        public string importDirectory { get; set; }

        public ImageFile ImportPath(int op)
        {
            string path = "";
            switch (op)
            {
                case 0:
                    IOUser.ConsoleExit();
                    break;

                case 1:
                    path = IOUser.ConsoleReadPath();
                    File.Copy(path, Path.Combine(importDirectory, Path.GetFileName(path)));
                    break;

                case 2:
                    IOUser.ConsoleError("NOT YET IMPLEMENTED");
                    //string directory = IOUser.ConsoleReadPath(1);
                    //string fileName = IOUser.ConsoleReadFileName(directory);
                    //path = Path.Combine(directory, fileName);
                    break;

                case 3:
                    path = IOUser.ConsoleReadPath(2);
                    break;

                case 4:
                    IOUser.ConsoleError("SEARCHING...");
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadLine();
                    break;
            }

            //GENERIC TEST EXAMPLE
            ImageFile imageFile = new ImageFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../test1.jpg"));

            // C:/Users/Francisco/Desktop/proyecto-grupo-2/PhotoMax-master/PhotoMax-master/PhotoMax

            if (op == 3 /*|| /*op == 4*/)
            {

                imageFile = new ImageFile(path);
            }
            return imageFile;
        }

    }
}
