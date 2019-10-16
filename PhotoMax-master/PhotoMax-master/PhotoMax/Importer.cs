using PhotoMax.InputOutput;
using System;
using System.Collections.Generic;
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
                "By file location",
                "By directory",
                "C",
                "D"
            };
        }

        public List<string> ImportList { get; set; }

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
                    break;

                case 2:
                    string directory = IOUser.ConsoleReadPath(1);
                    string fileName = IOUser.ConsoleReadFileName(directory);
                    path = Path.Combine(directory, fileName);
                    break;

                case 3:
                    IOUser.ConsoleError("SEARCHING...");
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadLine();
                    break;

                case 4:
                    IOUser.ConsoleError("SEARCHING...");
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadLine();
                    break;
            }

            //GENERIC TEST EXAMPLE
            ImageFile imageFile = new ImageFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../test1.jpg"));

            if (op == 1 || op == 2)
            {

                imageFile = new ImageFile(path);
            }
            return imageFile;
        }

    }
}
