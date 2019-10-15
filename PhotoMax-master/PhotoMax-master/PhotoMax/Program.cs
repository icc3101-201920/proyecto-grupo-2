using System;
using System.Drawing;
using System.Linq;
using ExifLib;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System.IO;
using PhotoMax.InputOutput;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace PhotoMax
{
    class Program
    {

        static void Main(string[] args)
        {
            // LIST OF SEARCH OPTIONS
            List<string> searchOptions = new List<string>()
            {
                "Back to editing options",
                "By file location",
                "By directory",
                "C",
                "D"
            };

            // LIST OF PHOTO EDITING OPTIONS
            List<string> editingOptions = new List<string>()
            {
                "Exit PhotoMax",
                "Apply Filter",
                "Image Production",
                "Insert Text",
                "Rotate",
                "Show Image"
            };

            // LIST OF IMAGE FILTERS
            List<string> filterList = new List<string>()
            {
                "Back to image editor",
                "Gray Scale",
                "Negative",
                "Sepia",
                "Acid",
                "Diamond waffle"
            };

            // SAVE CHANGES GENERAL
            List<string> saveDataOptions = new List<string>()
            {
                "Yes! Go back to options",
                "No! Try again",
                "No! Go back to options",
                "Yes! Continue applying changes"
            };

            // SAVE CHANGES FILTERS
            List<string> saveDataOptions1 = new List<string>()
            {
                "Yes! Go back to options",
                "No! Try another filter",
                "No! Go back to options",
                "Yes! Apply another filter"
            };

            // YES OR NO
            List<string> YNOptions = new List<string>()
            {
                "No",
                "Yes"
            };

            IOUser.ConsoleWelcome();

            int editingOption = -1;
            while (editingOption != 0)
            {
                if (editingOption > 0)
                {
                    IOUser.ClearConsole();
                }

                IOUser.ConsoleListOutput("Select one of the following options:", editingOptions);
                editingOption = IOUser.ConsoleReadInput();
                while (editingOption >= editingOptions.Count || editingOption < 0)
                {
                    IOUser.ConsoleError("Input must be a valid number\n");
                    editingOption = IOUser.ConsoleReadInput();
                }
                switch (editingOption)  //PHOTO EDITING OPTIONS
                {
                    case 0:
                        break;

                    case 1:
                        IOUser.ClearConsole();
                        int filterOption = 0;
                        int saveDataOption1 = -1;
                        while (true)
                        {
                            //Neceitan ser no vacias al comienzo o el programa tira error
                            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../test1.jpg");
                            Bitmap image = new Bitmap(path);
                            //****

                            string saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../PM-Images");
                            string newFileName;
                            string newPath;

                            int searchOption;
                            IOUser.ConsoleListOutput("Select one of the following search methods to find your image:", searchOptions);
                            searchOption = IOUser.ConsoleReadInput();
                            while (searchOption >= editingOptions.Count || searchOption < 0)
                            {
                                IOUser.ConsoleError("Input must be a valid number\n");
                                searchOption = IOUser.ConsoleReadInput();
                            }
                            switch (searchOption)
                            {
                                case 0:
                                    IOUser.ConsoleExit();
                                    break;
                                case 1:
                                    path = IOUser.ConsoleReadPath();
                                    image = new Bitmap(path);
                                    break;
                                case 2:
                                    string directory = IOUser.ConsoleReadPath(1);
                                    string file = IOUser.ConsoleReadFileName(directory);
                                    path = Path.Combine(directory, file);
                                    image = new Bitmap(path);
                                    break;
                                case 3:
                                    IOUser.ConsoleError("SEARCHING...");
                                    break;
                                case 4:
                                    IOUser.ConsoleError("SEARCHING...");
                                    break;
                            }

                            if (searchOption == 0)
                            {
                                break;
                            }


                            
                            IOUser.ClearConsole();
                            IOUser.ConsoleListOutput("Select one of the following filters:", filterList);
                            filterOption = IOUser.ConsoleReadInput();
                            while (filterOption >= filterList.Count || filterOption < 0)
                            {
                                IOUser.ConsoleError("Input must be a valid number\n");

                                filterOption = IOUser.ConsoleReadInput();
                            }

                            switch (filterOption) //IMAGE FILTERS
                            {
                                case 0:
                                    break;
                                case 1: //GRAY SCALE

                                    Editor.ApplyGreyScale(image);
                                    IOUser.ConsoleOutput("Filter applied successfully!");
                                    IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                    break;
                                case 2: //NEGATIVE

                                    Editor.ApplyNegative(image);
                                    IOUser.ConsoleOutput("Filter applied successfully!");
                                    IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                    break;
                                case 3: //SEPIA

                                    Editor.ApplySepia(image);
                                    IOUser.ConsoleOutput("Filter applied successfully!");
                                    IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                    break;
                                case 4: //ACID

                                    Editor.ApplyAcid(image);
                                    IOUser.ConsoleOutput("Filter applied successfully!");
                                    IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                    break;
                                case 5: // DIAMONDWAFFLE

                                    Editor.ApplyDiamondWaffle(image);
                                    IOUser.ConsoleOutput("Filter applied successfully!");
                                    IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                    break;

                            }
                            if (filterOption == 0)
                            {
                                break;
                            }

                            while (true)
                            {
                                IOUser.ClearConsole();
                                IOUser.ConsoleListOutput("Apply changes?", saveDataOptions1);
                                saveDataOption1 = IOUser.ConsoleReadInput();
                                while (saveDataOption1 >= saveDataOptions1.Count || saveDataOption1 < 0)
                                {
                                    IOUser.ConsoleError("Input must be a valid number\n");
                                    saveDataOption1 = IOUser.ConsoleReadInput();
                                }
                                switch (saveDataOption1)
                                {
                                    case 0:
                                        Console.WriteLine("\nEnter a name for the new image (remember to add .jpg):\n");
                                        newFileName = Console.ReadLine();
                                        newPath = Path.Combine(saveDirectory, newFileName);
                                        File.Copy(path, newPath);
                                        IOUser.ConsoleOutput("Changes Saved! Going back to image editor");
                                        image.Save(newPath);
                                        image.Dispose();
                                        Thread.Sleep(2000);
                                        break;
                                    case 1:
                                        IOUser.ConsoleOutput("Going back to filter select");
                                        Thread.Sleep(2000);
                                        break;
                                    case 2:
                                        IOUser.ConsoleOutput("Changes Discarded! Going back to image editor");
                                        Thread.Sleep(2000);
                                        break;
                                    case 3:
                                        Console.WriteLine("\nEnter a name for the new image (don't add .jpg):\n");
                                        newFileName = Console.ReadLine();
                                        newPath = Path.Combine(saveDirectory, newFileName);
                                        File.Copy(path, newPath);
                                        IOUser.ConsoleOutput("Changes Saved! Going back to image editor");
                                        image.Save(newPath);
                                        image.Dispose();
                                        Thread.Sleep(2000);
                                        break;
                                }
                                break;
                            }
                            if ((saveDataOption1 == 0) || (saveDataOption1 == 2))
                            {
                                break;
                            }
                        }
                        if ((saveDataOption1 == 0) || (saveDataOption1 == 2))
                        {
                            continue;
                        }
                        if (filterOption == 0)
                        {
                            continue;
                        }
                        break;

                    case 2:
                        IOUser.ClearConsole();
                        IOUser.ConsoleOutput("Select the images you want to work with:");
                        IOUser.ConsoleError("NOT YET IMPLEMENTED");
                        Console.WriteLine("\nPress any key to continue");
                        Console.ReadLine();
                        break;

                    case 3:
                        IOUser.ClearConsole();
                        int saveDataOption3 = -1;
                        while (true) //TEXT INSERTER
                        {
                            IOUser.ClearConsole();
                            IOUser.ConsoleOutput("Write the text you want to insert:\n");
                            string itText = Console.ReadLine();

                            IOUser.ConsoleOutput("Insert colour:\n");
                            string itColour = Console.ReadLine();
                            //Valid colour, if not make black as default

                            IOUser.ConsoleOutput("Insert font size\n");
                            int itFontSize = IOUser.ConsoleReadInput();

                            IOUser.ConsoleOutput("Select x coordinates:\n");
                            int itXCoordinates = IOUser.ConsoleReadInput();

                            IOUser.ConsoleOutput("Select y coordinates:\n");
                            int itYCoordinates = IOUser.ConsoleReadInput();

                            IOUser.ConsoleOutput("Text inserted successfully!");
                            IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                            Console.WriteLine("\nPress any key to continue");
                            Console.ReadLine();

                            while (true)
                            {
                                IOUser.ClearConsole();
                                IOUser.ConsoleListOutput("Apply changes?", saveDataOptions);
                                saveDataOption3 = IOUser.ConsoleReadInput();
                                while (saveDataOption3 >= saveDataOptions.Count || saveDataOption3 < 0)
                                {
                                    IOUser.ConsoleError("Input must be a valid number\n");
                                    saveDataOption3 = IOUser.ConsoleReadInput();
                                }
                                switch (saveDataOption3)
                                {
                                    case 0:
                                        IOUser.ConsoleOutput("Changes Saved! Going back to image editor");
                                        Thread.Sleep(2000);
                                        break;
                                    case 1:
                                        IOUser.ConsoleOutput("Going back to text inserter");
                                        Thread.Sleep(2000);
                                        break;
                                    case 2:
                                        IOUser.ConsoleOutput("Changes Discarded! Going back to image editor");
                                        Thread.Sleep(2000);
                                        break;
                                    case 3:
                                        IOUser.ConsoleOutput("Changes Saved! Going back to text inserter");
                                        Thread.Sleep(2000);
                                        break;
                                }
                                break;
                            }
                            if ((saveDataOption3 == 0) || (saveDataOption3 == 2))
                            {
                                break;
                            }
                        }
                        if ((saveDataOption3 == 0) || (saveDataOption3 == 2))
                        {
                            continue;
                        }
                        break;

                    case 4:
                        IOUser.ClearConsole();
                        int saveDataOption4 = -1;
                        while (true) //IMAGE ROTATOR
                        {
                            IOUser.ClearConsole();
                            IOUser.ConsoleError("NOT YET IMPLEMENTED");
                            IOUser.ConsoleOutput("Select by how many degrees you want to rotate (clockwise):\n");
                            int rotDegrees = IOUser.ConsoleReadInput();

                            IOUser.ConsoleOutput("Image rotated successfully!");
                            IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                            Console.WriteLine("\nPress any key to continue");
                            Console.ReadLine();

                            while (true)
                            {
                                IOUser.ClearConsole();
                                IOUser.ConsoleListOutput("Apply changes?", saveDataOptions);
                                saveDataOption4 = IOUser.ConsoleReadInput();
                                while (saveDataOption4 >= saveDataOptions.Count || saveDataOption4 < 0)
                                {
                                    IOUser.ConsoleError("Input must be a valid number\n");
                                    saveDataOption4 = IOUser.ConsoleReadInput();
                                }
                                switch (saveDataOption4)
                                {
                                    case 0:
                                        IOUser.ConsoleOutput("Changes Saved! Going back to image editor");
                                        Thread.Sleep(2000);
                                        break;
                                    case 1:
                                        IOUser.ConsoleOutput("Going back to image rotator");
                                        Thread.Sleep(2000);
                                        break;
                                    case 2:
                                        IOUser.ConsoleOutput("Changes Discarded! Going back to image editor");
                                        Thread.Sleep(2000);
                                        break;
                                    case 3:
                                        IOUser.ConsoleOutput("Changes Saved! Going back to image rotator");
                                        Thread.Sleep(2000);
                                        break;
                                }
                                break;
                            }
                            if ((saveDataOption4 == 0) || (saveDataOption4 == 2))
                            {
                                break;
                            }
                        }
                        if ((saveDataOption4 == 0) || (saveDataOption4 == 2))
                        {
                            continue;
                        }
                        break;

                    case 5:
                        IOUser.ClearConsole();
                        IOUser.ConsoleError("SHOW IMAGE");
                        Console.WriteLine("\nPress any key to go back to editing options");
                        Console.ReadLine();
                        break;
                    //MORE CASES


                }

            }

        }

    }
}