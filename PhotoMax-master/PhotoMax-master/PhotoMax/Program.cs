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

namespace PhotoMax
{
    class Program
    {


        static void Main(string[] args)
        {
            // LIST OF SEARCH OPTIONS
            List<string> searchOptions = new List<string>()
            {
                "Exit PhotoMax",
                "A",
                "B",
                "C",
                "D"
            };

            // LIST OF PHOTO EDITING OPTIONS
            List<string> editingOptions = new List<string>()
            {
                "Back to image search",
                "Apply Filter",
                "Cut",
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

            int searchOption = -1;
            int YNOption = -1;
            while (true)
            {
                IOUser.ConsoleListOutput("Select one of the following search methods:", searchOptions);
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
                        IOUser.ConsoleError("SEARCHING...");
                        break;
                    case 2:
                        IOUser.ConsoleError("SEARCHING...");
                        break;
                    case 3:
                        IOUser.ConsoleError("SEARCHING...");
                        break;
                    case 4:
                        IOUser.ConsoleError("SEARCHING...");
                        break;
                }

                if (searchOption != 0)
                {
                    IOUser.ConsoleListOutput("Do you want to edit the following image?", YNOptions);
                    IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                    YNOption = IOUser.ConsoleReadInput();
                    while (YNOption >= YNOptions.Count || YNOption < 0)
                    {
                        IOUser.ConsoleError("Input must be a valid number\n");
                        YNOption = IOUser.ConsoleReadInput();
                    }
                    switch (YNOption)
                    {
                        case 0:
                            IOUser.ConsoleOutput("Going back to image search");
                            break;
                        case 1:
                            IOUser.ConsoleOutput("Going to image editor");
                            break;
                    }
                    if (YNOption == 0)
                    {
                        continue;
                    }
                }

                //***IMAGE TEST***

                //PONER AQUI EL CODIGO PARA QUE SE HABRA UNA IMAGEN

                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../hola.jpg");
                Bitmap image = new Bitmap(path);


                //***IMAGE TEST***

                int editingOption = -1;
                while (searchOption != 0)
                {
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
                            int filterOption = -1;
                            int saveDataOption1 = -1;
                            while (true)
                            {
                                Editor editor = new Editor();
                                Bitmap imagenNueva = new Bitmap(image);


                                IOUser.ConsoleListOutput("Select one of the following filters:",     filterList);
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

                                        editor.ApplyGreyScale(imagenNueva);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        break;
                                    case 2: //NEGATIVE
                                        
                                        editor.ApplyNegative(imagenNueva);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        break;
                                    case 3: //SEPIA
                                        
                                        editor.ApplySepia(imagenNueva);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        break;
                                    case 4: //ACID

                                        editor.ApplyAcid(imagenNueva);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        break;
                                    case 5: // DIAMONDWAFFLE

                                        editor.ApplyDiamondWaffle(imagenNueva);
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
                                            IOUser.ConsoleOutput("Changes Saved! Going back to image editor");
                                            imagenNueva.Save(path);
                                            break;
                                        case 1:
                                            IOUser.ConsoleOutput("Going back to filter select");
                                            break;
                                        case 2:
                                            IOUser.ConsoleOutput("Changes Discarded! Going back to image editor");
                                            break;
                                        case 3:
                                            IOUser.ConsoleOutput("Changes Saved! Going back to filter select");
                                            imagenNueva.Save(path);
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
                            IOUser.ConsoleOutput("Select the coordenates you want to cut:");
                            IOUser.ConsoleError("NOT YET IMPLEMENTED");
                            break;

                        case 3:
                            int saveDataOption3 = -1;
                            while (true) //TEXT INSERTER
                            {
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

                                while (true)
                                {
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
                                            break;
                                        case 1:
                                            IOUser.ConsoleOutput("Going back to text inserter");
                                            break;
                                        case 2:
                                            IOUser.ConsoleOutput("Changes Discarded! Going back to image editor");
                                            break;
                                        case 3:
                                            IOUser.ConsoleOutput("Changes Saved! Going back to text inserter");
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
                            int saveDataOption4 = -1;
                            while (true) //IMAGE ROTATOR
                            {
                                IOUser.ConsoleOutput("Select by how many degrees you want to rotate (clockwise):\n");
                                int rotDegrees = IOUser.ConsoleReadInput();

                                IOUser.ConsoleOutput("Image rotated successfully!");
                                IOUser.ConsoleError("SHOW IMAGE"); //SHOW

                                while (true)
                                {
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
                                            break;
                                        case 1:
                                            IOUser.ConsoleOutput("Going back to image rotator");
                                            break;
                                        case 2:
                                            IOUser.ConsoleOutput("Changes Discarded! Going back to image editor");
                                            break;
                                        case 3:
                                            IOUser.ConsoleOutput("Changes Saved! Going back to image rotator");
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
                            IOUser.ConsoleError("SHOW IMAGE");
                            continue;
                            //MORE CASES


                    }
                    break;
                }
                if (searchOption == 0)
                {
                    break;
                }
            }


        }

    }
}