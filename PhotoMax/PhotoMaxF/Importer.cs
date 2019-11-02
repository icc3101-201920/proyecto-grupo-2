using PhotoMaxF.InputOutput;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace PhotoMaxF
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

            // LIST OF SEARCH OPTIONS
            SelectMoreImages = new List<string>()
            {
                "Back to image production",
                "Select another image from Import folder"
            };

            // YES OR NO
            YNListI = new List<string>()
            {
                "No",
                "Yes"
            };

<<<<<<< HEAD
            importDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../PM-Images/Imports");
            //C:/Users/Francisco/Desktop/Proyecto-Grupo2/PhotoMax-master/PhotoMaxF/PM-Images/Imports
            // C:\Users\Francisco\Desktop\Proyecto-Grupo2\PhotoMax-master\PhotoMaxF\PM-Images\Imports

=======
            importDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\PM-Images\\Imports");
            
>>>>>>> 763dcf2da1a1d66a1caebf2b25df0812649be6df
            extensionTypes = new List<string>() { ".jpg", ".jpeg", ".png", ".bpm" };
        }


        public List<string> ImportList { get; set; }
        public List<string> SelectMoreImages { get; set; }
        public List<string> YNListI { get; set; }
        public string importDirectory { get; set; }
        List<string> extensionTypes { get; set; }

        public string ImportPath(int op)
        {
            string workingPath = "/%void%/";
            string path;
            switch (op)
            {
                case 0:
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
                    //IOUser.ConsoleError("NOT YET IMPLEMENTED...");
                    //Console.WriteLine("\nPress any key to continue");
                    //Console.ReadLine();

                    //GENERIC TEST EXAMPLE
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\test1.jpg");

                    return path;
                
            }

            return workingPath;
        }
        public List<string> MoreImages(int op, List<string> fusionImgs)
        {
            List<string> backOP = new List<string>() { "/%void%/" };
            switch (op)
            {
                case 0:
                    return backOP;

                case 1:
                    bool valid = false;
                    
                    int moreOption = -1;
                    while (!valid)
                    {
                        while (moreOption == -1) 
                        {
                            IOUser.ClearConsole();
                            string path = IOUser.ConsoleReadFileName(importDirectory, extensionTypes, "Enter the image name to select from import folder:\n");
                            if (path != "/%void%/" && !fusionImgs.Contains(path))
                            {
                                fusionImgs.Add(path);
                                break;
                            }
                            if (fusionImgs.Contains(path))
                            {
                                IOUser.ConsoleError("Image already selected...\n");
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                IOUser.ClearConsole();
                                IOUser.ConsoleListOutput("Go back to image production menu?", YNListI);
                                moreOption = IOUser.ConsoleReadInput(YNListI) - 1;
                                if(moreOption == 0)
                                {
                                    return new List<string>() { "/%void%/" };
                                }
                            }
                        }

                        IOUser.ClearConsole();
                        IOUser.ConsoleListOutput("Use another image?", YNListI);
                        moreOption = IOUser.ConsoleReadInput(YNListI);
                        if (moreOption == 0)
                        {
                            return fusionImgs;
                        }
                        else
                        {
                            IOUser.ClearConsole();
                            string path = IOUser.ConsoleReadFileName(importDirectory, extensionTypes, "Enter the image name to select from import folder:\n");
                            if (path != "/%void%/" && !fusionImgs.Contains(path))
                            {
                                fusionImgs.Add(path);
                                continue;
                            }
                            if (fusionImgs.Contains(path))
                            {
                                IOUser.ConsoleError("Image already selected...\n");
                                Thread.Sleep(1000);
                            }
                            continue;
                        }
                    }
                    return backOP;

                    //MORE CASES
            }

            return backOP;
        }
    }   
}
