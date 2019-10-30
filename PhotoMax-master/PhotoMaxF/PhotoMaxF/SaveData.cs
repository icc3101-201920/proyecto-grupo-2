using PhotoMaxF.InputOutput;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;

namespace PhotoMaxF
{
    public class SaveData
    {
        public SaveData()
        {
            // SAVE CHANGES PROTOTYPE
            GeneralSaveDataList = new List<string>()
            {
                "Yes! Go back to editing options",
                "No! Try again",
                "No! Go back to options",
                "Yes! Continue applying changes"
            };

            // SAVE CHANGES FOR PRODUCTION
            ProductionSaveDataList = new List<string>()
            {
                "Yes! Save another copy to Import Folder and go back to editing options",
                "Yes! Go back to editing options",
                "No! Go back to editing options"
            };

            // SAVE CHANGES FOR TEXT AND ROTATOR 
            ProductionAlterSaveDataList = new List<string>()
            {
                "Yes! Go back to editing options",
                "No! Go back to editing options"
            };

            // SAVE CHANGES FOR FILTERS
            FilterSaveDataList = new List<string>()
            {
                "Yes! Go back to editing options",
                "No! Try another filter",
                "No! Go back to editing options",
                "Yes! Apply another filter"
            };

            // YES OR NO
            YNListSD = new List<string>()
            {
                "No",
                "Yes"
            };

            //DEFAULT SAVE DIRECTORY
            saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../PM-Images/Results");
        }


        public List<string> GeneralSaveDataList { get; set; }
        public List<string> FilterSaveDataList { get; set; }
        public List<string> ProductionSaveDataList { get; set; }
        public List<string> ProductionAlterSaveDataList { get; set; }
        public List<string> YNListSD { get; set; }
        public string saveDirectory { get; set; }

        public int GSaveDataOptions(ImageFile imageFile)
        {
            int op = IOUser.ConsoleReadInput(GeneralSaveDataList);
            switch (op)
            {
                case 0:
                    IOUser.ClearConsole();
                    IOUser.ConsoleOutput("Changes Saved! Going back to editing options");
                    Thread.Sleep(2000);
                    break;
                case 1:
                    IOUser.ClearConsole();
                    IOUser.ConsoleOutput("Changes Discarded! Going back to text inserter");
                    Thread.Sleep(2000);
                    break;
                case 2:
                    IOUser.ClearConsole();
                    IOUser.ConsoleOutput("Changes Discarded! Going back to editing options");
                    Thread.Sleep(2000);
                    break;
                case 3:
                    IOUser.ClearConsole();
                    IOUser.ConsoleOutput("Going back to *SELECTED WORKING STATION*");
                    Thread.Sleep(2000);
                    break;
            }
            return op;
        }

        public int FilterSaveDataOptions(ImageFile imageFile, Bitmap filter)
        {
            string newFileName;
            string newPath;

            int op = IOUser.ConsoleReadInput(FilterSaveDataList);
            switch (op)
            {
                case 0:
                    IOUser.ClearConsole();
                    Console.WriteLine("\nEnter a name for the new image (don't add .jpg):\n");
                    newFileName = IOUser.ConsoleSaveAs(imageFile.Origin, saveDirectory);
                    newPath = Path.Combine(saveDirectory, newFileName);
                    File.Copy(imageFile.Origin, newPath);
                    IOUser.ConsoleOutput("Changes Saved! Going back to editing options");
                    imageFile.Bpm = filter;
                    imageFile.Bpm.Save(newPath);
                    Thread.Sleep(2000);
                    break;
                case 1:
                    IOUser.ClearConsole();
                    IOUser.ConsoleOutput("Changes Discarded! Going back to filter select");
                    Thread.Sleep(1500);
                    break;
                case 2:
                    IOUser.ClearConsole();
                    IOUser.ConsoleOutput("Changes Discarded! Going back to editing options");
                    Thread.Sleep(2000);
                    break;
                case 3:
                    IOUser.ClearConsole();
                    IOUser.ConsoleOutput("Going back to filter select");
                    imageFile.Bpm = filter;
                    Thread.Sleep(1500);
                    break;
            }
            return op;
        }

        public void ProductionSaveDataOptions(string originBMPpath, Bitmap newBMP)
        {
            string newFileName;
            string newPath;
            string importFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../PM-Images/Imports");

            int op = IOUser.ConsoleReadInput(ProductionSaveDataList);
            switch (op)
            {
                case 0:
                    IOUser.ClearConsole();
                    Console.WriteLine("\nEnter a name for the new image (don't add .jpg):\n");
                    newFileName = IOUser.ConsoleSaveAs(originBMPpath, saveDirectory);
                    newPath = Path.Combine(saveDirectory, newFileName);
                    importFolderPath = Path.Combine(importFolderPath, newFileName);
                    File.Copy(originBMPpath, newPath);
                    IOUser.ConsoleOutput("Changes Saved and Copy created! Going back to editing options");
                    newBMP.Save(newPath);
                    newBMP.Save(importFolderPath);
                    Thread.Sleep(2000);
                    break;
                case 1:
                    IOUser.ClearConsole();
                    Console.WriteLine("\nEnter a name for the new image (don't add .jpg):\n");
                    newFileName = IOUser.ConsoleSaveAs(originBMPpath, saveDirectory);
                    newPath = Path.Combine(saveDirectory, newFileName);
                    File.Copy(originBMPpath, newPath);
                    IOUser.ConsoleOutput("Changes Saved! Going back to editing options");
                    newBMP.Save(newPath);
                    Thread.Sleep(2000);
                    break;
                case 2:
                    IOUser.ClearConsole();
                    IOUser.ConsoleOutput("Changes Discarded! Going back to editing options");
                    Thread.Sleep(2000);
                    break;
            }

        }

        public void ProductionAlterSaveDataOptions(ImageFile imageFile, Bitmap newBMP)
        {
            string newFileName;
            string newPath;

            int op = IOUser.ConsoleReadInput(ProductionSaveDataList);
            switch (op)
            {
                case 0:
                    IOUser.ClearConsole();
                    Console.WriteLine("\nEnter a name for the new image (don't add .jpg):\n");
                    newFileName = IOUser.ConsoleSaveAs(imageFile.Origin, saveDirectory);
                    newPath = Path.Combine(saveDirectory, newFileName);
                    File.Copy(imageFile.Origin, newPath);
                    IOUser.ConsoleOutput("Changes Saved! Going back to editing options");
                    imageFile.Bpm = newBMP;
                    imageFile.Bpm.Save(newPath);
                    Thread.Sleep(2000);
                    break;
                case 1:
                    IOUser.ClearConsole();
                    IOUser.ConsoleOutput("Changes Discarded! Going back to editing options");
                    Thread.Sleep(2000);
                    break;
            }

        }

    }
}
