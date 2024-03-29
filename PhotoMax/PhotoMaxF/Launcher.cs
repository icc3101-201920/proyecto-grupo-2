﻿using Microsoft.VisualBasic.FileIO;
using PhotoMaxF.InputOutput;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace PhotoMaxF
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
                "Rotate Image"
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

            // LIST OF IMAGE FILTERS
            ProductionList = new List<string>()
            {
                "Back to image editor",
                "Fusion",
                "Mosaic",
                "Collage"
            };
        }

        public List<string> EditingList { get; set; }
        public List<string> FilterList { get; set; }
        public List<string> ProductionList { get; set; }

        public void Launch()
        {
            IOUser.ConsoleWelcome();
            
            Importer importer = new Importer();
            if (!Directory.Exists(importer.importDirectory))
            {
                FileSystem.CreateDirectory(importer.importDirectory);
            }
            SaveEXIFData();

            SaveData saveData = new SaveData();
            if (!Directory.Exists(saveData.saveDirectory))
            {
                FileSystem.CreateDirectory(saveData.saveDirectory);
            }

            List<ImageFile> imageFilesImportFolder = LoadEXIFData();

            int searchOption = -1;
            while (searchOption != 0)
            {
                IOUser.ConsoleListOutput("Select one of the following options:", importer.ImportList);
                searchOption = IOUser.ConsoleReadInput(importer.ImportList);
                IOUser.ClearConsole();

                if (searchOption == 0) { IOUser.ConsoleExit(); Thread.Sleep(2500); break;}

                string path = importer.ImportPath(searchOption);
                
                if (path == "/%void%/") {IOUser.ClearConsole(); continue;}
                SaveEXIFData();

                ImageFile imageFile = new ImageFile(path);

                

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

                        case 1:  //IMAGE FILTERS

                            int saveDataOption1 = 1;
                            while ((saveDataOption1 == 1) || (saveDataOption1 == 3))
                            {
                                IOUser.ClearConsole();
                                IOUser.ConsoleListOutput("Select one of the following filters:", FilterList);
                                int filterOption = IOUser.ConsoleReadInput(FilterList);

                                Bitmap filter = imageFile.Bpm; //

                                switch (filterOption)
                                {
                                    case 0:
                                        break;
                                    case 1: //GRAY SCALE

                                        filter = Filters.GreyScale(imageFile.Bpm);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();
                                        break;
                                    case 2: //NEGATIVE

                                        filter = Filters.Negative(imageFile.Bpm);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();
                                        break;
                                    case 3: //SEPIA

                                        filter = Filters.Sepia(imageFile.Bpm);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();
                                        break;
                                    case 4: //BLOSSOM

                                        filter = Filters.Blossom(imageFile.Bpm);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();
                                        break;
                                    case 5: //OLD MOVIE

                                        filter = Filters.OldMovie(imageFile.Bpm);
                                        IOUser.ConsoleOutput("Filter applied successfully!");
                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();
                                        break;
                                }

                                if (filterOption == 0) { break; }

                                IOUser.ClearConsole();
                                IOUser.ConsoleListOutput("Apply changes?", saveData.FilterSaveDataList);
                                saveDataOption1 = saveData.FilterSaveDataOptions(imageFile, filter);
                                IOUser.ClearConsole();

                            }
                            break;

                        case 2:
                            int productionOption = -1;
                            while (productionOption != 0)
                            {
                                IOUser.ClearConsole();
                                IOUser.ConsoleListOutput("Select one of the following production options:", ProductionList);
                                productionOption = IOUser.ConsoleReadInput(ProductionList);

                                switch (productionOption) //IMAGE PRODUCTION
                                {
                                    case 0:
                                        break;
                                    case 1: //FUSION

                                        IOUser.ClearConsole();
                                        IOUser.ConsoleListOutput("Select one of the following options:", importer.SelectMoreImages);
                                        int moreImgOp = IOUser.ConsoleReadInput(importer.SelectMoreImages);
                                        if (moreImgOp == 0) { break; }

                                        List<string> fusionList = new List<string> { imageFile.Origin };
                                        fusionList = importer.MoreImages(moreImgOp, fusionList);
                                        if (fusionList[0] == "/%void%/") { break; }


                                        List<Bitmap> fusionListBMP = new List<Bitmap>();
                                        fusionListBMP.Add(imageFile.Bpm);
                                        foreach (string f in fusionList)
                                        {
                                            fusionListBMP.Add(new Bitmap(f));
                                        }

                                        string productionBase = Editor.getSmallerImage(fusionList);
                                        Bitmap fusionBMP = Editor.Fusion(fusionListBMP);

                                        IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();

                                        IOUser.ClearConsole();
                                        IOUser.ConsoleListOutput("Apply changes?", saveData.ProductionSaveDataList);
                                        saveData.ProductionSaveDataOptions(productionBase, fusionBMP);
                                        IOUser.ClearConsole();

                                        productionOption = 0;
                                        break;
                                    case 2: //MOSAIC

                                        IOUser.ClearConsole();
                                        IOUser.ConsoleError("NOT YET IMPLEMENTED");
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();

                                        productionOption = 0;
                                        break;
                                    case 3: //COLLAGE

                                        IOUser.ClearConsole();
                                        IOUser.ConsoleError("NOT YET IMPLEMENTED");
                                        Console.WriteLine("\nPress any key to continue");
                                        Console.ReadLine();

                                        productionOption = 0;
                                        break;
                                }
                            }
                            break;


                        case 3:   //TEXT INSERTER 

                            IOUser.ClearConsole();
                            IOUser.ConsoleOutput("Write the text you want to insert:\n");
                            string itText = Console.ReadLine();

                            List<string> ColorList = new List<string>() { "Black", "White", "Red", "Green", "Blue", "Gray" };
                            IOUser.ConsoleListOutput("Select a color:", ColorList);
                            int colorOption = IOUser.ConsoleReadInput(ColorList);

                            IOUser.ConsoleOutput("Insert font size (bigger font is recomended for large images):\n");
                            int itFontSize = IOUser.ConsoleReadNumber();

                            IOUser.ConsoleOutput($"Select x coordinates (for reference your image has {imageFile.Bpm.Width} of width):\n");
                            int itXCoordinates = IOUser.ConsoleReadNumber();

                            IOUser.ConsoleOutput($"Select y coordinates (for reference your image has {imageFile.Bpm.Height} of height):\n");
                            int itYCoordinates = IOUser.ConsoleReadNumber();

                            Bitmap textBMP = Editor.TEXT(imageFile.Bpm, itText, ColorList[colorOption], itFontSize, itXCoordinates, itYCoordinates);

                            IOUser.ClearConsole();
                            IOUser.ConsoleOutput("Text inserted successfully!");
                            IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                            Console.WriteLine("\nPress any key to continue");
                            Console.ReadLine();

                            IOUser.ClearConsole();
                            IOUser.ConsoleListOutput("Apply changes?", saveData.ProductionAlterSaveDataList);
                            saveData.ProductionAlterSaveDataOptions(imageFile, textBMP);
                            IOUser.ClearConsole();

                            break;

                        case 4:    //IMAGE ROTATOR 

                            IOUser.ClearConsole();
                            List<string> RotateList = new List<string>() { "By 270°", "By 90°", "By 180°"};

                            IOUser.ConsoleListOutput("By how many degrees you want to rotate the image (clockwise)?", RotateList);
                            int rotateOption = IOUser.ConsoleReadInput(RotateList);

                            RotateFlipType applyRotate = RotateFlipType.RotateNoneFlipNone; //BASE
                            if (rotateOption == 1) { applyRotate = RotateFlipType.Rotate90FlipNone; }
                            if (rotateOption == 2) { applyRotate = RotateFlipType.Rotate180FlipNone; }
                            if (rotateOption == 0) { applyRotate = RotateFlipType.Rotate270FlipNone; }

                            Bitmap rotate = imageFile.Bpm; //
                            rotate.RotateFlip(applyRotate);


                            IOUser.ConsoleOutput("Image rotated successfully!");
                            IOUser.ConsoleError("SHOW IMAGE"); //SHOW
                            Console.WriteLine("\nPress any key to continue");
                            Console.ReadLine();

                            IOUser.ClearConsole();
                            IOUser.ConsoleListOutput("Apply changes?", saveData.ProductionAlterSaveDataList);
                            saveData.ProductionAlterSaveDataOptions(imageFile, rotate);
                            IOUser.ClearConsole();

                            break;

                            //MORE CASES



                    }
                    IOUser.ClearConsole();
                }
            }

        }

        public void SaveEXIFData()
        {
            if (Directory.EnumerateFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\PM-Images\\Imports")).Any())
            {
                string EXIFDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\EXIFData");

                string[] imageFilePaths = new string[] { };
                imageFilePaths = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\PM-Images\\Imports"));

                string pName;
                ImageFile img;
                foreach (string path in imageFilePaths)
                {
                    img = new ImageFile(path);
                    pName = Path.GetFileNameWithoutExtension(path);
                    if (!File.Exists(Path.Combine(EXIFDirectory, pName + ".txt")))
                    {
                        FileStream fs = new FileStream(Path.Combine(EXIFDirectory, pName + ".txt"), FileMode.Create);
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(fs, img);
                        fs.Close();
                    }
                }
            }


        }
        
        public List<ImageFile> LoadEXIFData()
        {
            if (Directory.EnumerateFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\EXIFData")).Any())
            {
                List<ImageFile> importsEXIFData = new List<ImageFile> { };
                string[] EXIFDataPaths = new string[] { };
                EXIFDataPaths = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\EXIFData"));

                ImageFile img;
                foreach (string path in EXIFDataPaths)
                {
                    FileStream fs = new FileStream(path, FileMode.Open);
                    IFormatter formatter = new BinaryFormatter();
                    img = formatter.Deserialize(fs) as ImageFile;
                    importsEXIFData.Add(img);
                    fs.Close();
                }
                return importsEXIFData;
            }
            return new List<ImageFile> {};
        }
        
    }
}
