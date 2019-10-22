using PhotoMax.InputOutput;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

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
                "USE TEST1.JPG (REMOVE OPTION LATER)"
            };

            importDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../PM-Images/Imports");
            
            extensionTypes = new List<string>() { ".jpg", ".jpeg", ".png", ".bpm" };
        }


        public List<string> ImportList { get; set; }
        public string importDirectory { get; set; }
        List<string> extensionTypes { get; set; }

        public string ImportPath(int op)
        {
            string workingPath = "/%void%/";
            string path;
            switch (op)
            {
                case 0:
                    IOUser.ConsoleExit();
                    break;

                case 1:
                    path = IOUser.ConsoleReadPath();
                    if (path != "/%void%/")
                    {
                        File.Copy(path, Path.Combine(importDirectory, Path.GetFileName(path)));
                    }
                    return workingPath;

                case 2:
                    List<string> paths = IOUser.ConsoleReadDirectory(extensionTypes);
                    if (paths[0] != "/%void%/")
                    {
                        foreach (string p in paths)
                        {
                            File.Copy(p, Path.Combine(importDirectory, Path.GetFileName(p)));
                        }
                    }
                    return workingPath;

                case 3:
                    if (!Directory.EnumerateFiles(importDirectory).Any())
                    {
                        IOUser.ConsoleError("Import directory is empty...");
                        Thread.Sleep(1500);
                        IOUser.ClearConsole();
                        return workingPath;
                    }
                    else
                    {
                        path = IOUser.ConsoleReadFileName(importDirectory, extensionTypes);
                        return path;
                    }

                case 4:
                    IOUser.ConsoleError("NOT YET IMPLEMENTED...");
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadLine();

                    //GENERIC TEST EXAMPLE
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../test1.jpg");

                    // C:/Users/Francisco/Desktop/proyecto-grupo-2/PhotoMax-master/PhotoMax-master/PhotoMax

                    return path;

                    //return workingPath;
                
            }

            return workingPath;
        }

    }
}
