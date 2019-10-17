using PhotoMax.InputOutput;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace PhotoMax
{
    public class SaveData
    {
        public SaveData()
        {
            // SAVE CHANGES GENERAL
            GeneralSaveDataList = new List<string>()
            {
                "Yes! Go back to options",
                "No! Try again",
                "No! Go back to options",
                "Yes! Continue applying changes"
            };

            // SAVE CHANGES FILTERS
            FilterSaveDataList = new List<string>()
            {
                "Yes! Go back to options",
                "No! Try another filter",
                "No! Go back to options",
                "Yes! Apply another filter"
            };

            // YES OR NO
            YNList = new List<string>()
            {
                "No",
                "Yes"
            };

            //DEFAULT SAVE DIRECTORY
            saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../PM-Images/Results");
        }


        public List<string> GeneralSaveDataList { get; set; }
        public List<string> FilterSaveDataList { get; set; }
        public List<string> YNList { get; set; }
        public string saveDirectory { get; set; }

        public int GSaveDataOptions(ImageFile imageFile)
        {
            int op = IOUser.ConsoleReadInput(GeneralSaveDataList);
            switch (op)
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
            return op;
        }

        public int FilterSaveDataOptions(ImageFile imageFile)
        {
            string newFileName;
            string newPath;

            int op = IOUser.ConsoleReadInput(FilterSaveDataList);
            switch (op)
            {
                case 0:
                    Console.WriteLine("\nEnter a name for the new image (remember to add .jpg):\n");
                    newFileName = Console.ReadLine();
                    newPath = Path.Combine(saveDirectory, newFileName);
                    File.Copy(imageFile.Origin, newPath);
                    IOUser.ConsoleOutput("Changes Saved! Going back to image editor");
                    imageFile.Bpm.Save(newPath);
                    imageFile.Bpm.Dispose();
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
                    File.Copy(imageFile.Origin, newPath);
                    IOUser.ConsoleOutput("Changes Saved! Going back to image editor");
                    imageFile.Bpm.Save(newPath);
                    imageFile.Bpm.Dispose();
                    Thread.Sleep(2000);
                    break;
            }
            return op;
        }

    }
}
