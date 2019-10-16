using PhotoMax.InputOutput;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoMax
{
    public class Launcher
    {
        public Launcher()
        {
            // LIST OF PHOTO EDITING OPTIONS
            EditingList = new List<string>()
            {
                "Back to image search",
                "Apply Filter",
                "Image Production",
                "Insert Text",
                "Rotate",
                "Show Image"
            };

            // LIST OF IMAGE FILTERS
            FilterList = new List<string>()
            {
                "Back to image editor",
                "Gray Scale",
                "Negative",
                "Sepia",
                "Blossom",
                "Old Movie"
            };
        }

        public List<string> EditingList { get; set; }
        public List<string> FilterList { get; set; }


        public void Launch()
        {
            IOUser.ConsoleWelcome();
            Importer importer = new Importer();
            SaveData saveData = new SaveData();

            int searchOption = -1;
            while (searchOption != 0)
            {
                IOUser.ConsoleListOutput("Select one of the following search methods to find your image:", importer.ImportList);
                searchOption = IOUser.ConsoleReadInput(importer.ImportList);
                IOUser.ClearConsole();
                ImageFile imageFile = importer.ImportPath(searchOption);

                if (searchOption == 0)
                {
                    break;
                }


                int editingOption = -1;
                while (editingOption != 0)
                {
                    IOUser.ClearConsole();
                    IOUser.ConsoleListOutput("Select one of the following options:", EditingList);
                    editingOption = IOUser.ConsoleReadInput(EditingList);
                    switch (editingOption)  //PHOTO EDITING OPTIONS
                    {
                        case 0:
                            break;

                        case 1:
                            int saveDataOption1 = 1;
                            while ((saveDataOption1 == 1) || (saveDataOption1 == 3))
                            {
                                IOUser.ClearConsole();
                                IOUser.ConsoleListOutput("Select one of the following filters:", FilterList);
                                int filterOption = IOUser.ConsoleReadInput(FilterList);

                                switch (filterOption) //IMAGE FILTERS
                                {
                                    case 0:
                                        break;
                                    case 1: //GRAY SCALE

                                        Filters.GreyScale(imageFile.Bpm);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();
                                        break;
                                    case 2: //NEGATIVE

                                        Filters.Negative(imageFile.Bpm);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();
                                        break;
                                    case 3: //SEPIA

                                        Filters.Sepia(imageFile.Bpm);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();
                                        break;
                                    case 4: //BLOSSOM

                                        Filters.Blossom(imageFile.Bpm);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();
                                        break;
                                    case 5: //OLD MOVIE

                                        Filters.OldMovie(imageFile.Bpm);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();
                                        break;
                                }


                                IOUser.ClearConsole();
                                IOUser.ConsoleListOutput("Apply changes?", saveData.FilterSaveDataList);
                                saveDataOption1 = saveData.FilterSaveDataOptions(imageFile);
                                IOUser.ClearConsole();

                            }
                            break;

                        case 2:
                            IOUser.ClearConsole();
                            IOUser.ConsoleError("NOT YET IMPLEMENTED");
                            Console.WriteLine("\nPress any key to continue");
                            Console.ReadLine();
                            break;

                        case 3:
                            IOUser.ClearConsole();
                            int saveDataOption3 = 1;
                            while ((saveDataOption3 == 1) || (saveDataOption3 == 3)) //TEXT INSERTER
                            {
                                IOUser.ClearConsole();
                                //IOUser.ConsoleError("NOT YET IMPLEMENTED");
                                Console.WriteLine("\nPress any key to continue");
                                Console.ReadLine();
                                //break

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
                                Editor.TEXT(imageFile.Bpm, itText, itColour, itFontSize, itXCoordinates, itYCoordinates);
                                IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                Console.WriteLine("\nPress any key to continue");
                                Console.ReadLine();

                                IOUser.ClearConsole();
                                IOUser.ConsoleListOutput("Apply changes?", saveData.GeneralSaveDataList);
                                saveDataOption3 = saveData.GSaveDataOptions(imageFile);
                                IOUser.ClearConsole();
                            }
                            break;

                        case 4:
                            IOUser.ClearConsole();
                            int saveDataOption4 = -1;
                            while ((saveDataOption4 == 1) || (saveDataOption4 == 3)) //IMAGE ROTATOR
                            {
                                IOUser.ClearConsole();
                                IOUser.ConsoleError("NOT YET IMPLEMENTED");
                                Console.WriteLine("\nPress any key to continue");
                                Console.ReadLine();
                                break;

                                //IOUser.ConsoleOutput("Select by how many degrees you want to rotate (clockwise):\n");
                                //int rotDegrees = IOUser.ConsoleReadInput();

                                //IOUser.ConsoleOutput("Image rotated successfully!");
                                //IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                //Console.WriteLine("\nPress any key to continue");
                                //Console.ReadLine();

                                //IOUser.ClearConsole();
                                //IOUser.ConsoleListOutput("Apply changes?", saveData.GeneralSaveDataList);
                                //saveDataOption4 = saveData.GSaveDataOptions(imageFile);
                                //IOUser.ClearConsole();

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
                    IOUser.ClearConsole();
                }
            }


        }


    }
}
