using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace PhotoMax.InputOutput
{
    public static class IOUser
    {
        public static void ConsoleWelcome()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nWelcome to PhotoMax!");
            Console.ResetColor();
        }
        public static void ConsoleExit()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nGoodbye!");
            Console.ResetColor();
        }

        //REQUESTS OR ANSWERS
        public static void ConsoleOutput(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + message);
            Console.ResetColor();
        }

        //ERRORS
        public static void ConsoleError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n" + message);
            Console.ResetColor();
        }

        //OPTIONS LIST
        public static void ConsoleListOutput(string title, List<String> options)
        {
            ConsoleOutput(title);
            Console.WriteLine("");
            for (int i = 1; i < options.Count; i++)
            {
                Console.WriteLine($"({i}) {options[i]}");
            }
            Console.WriteLine($"({0}) {options[0]}");
            Console.WriteLine("");
        }

        //USER OPTION
        public static int ConsoleReadInput(List<string> list = null)
        {
            string option = Console.ReadLine();
            int optionNumber = ConsoleVerifyInput(option);
            while (optionNumber <= -1 || optionNumber >= list.Count)
            {
                ConsoleError("Input must be a valid option\n");
                option = Console.ReadLine();
                optionNumber = ConsoleVerifyInput(option);
            }

            return optionNumber;
        }

        //USER OPTION MUST BE INT
        public static int ConsoleVerifyInput(string op)
        {
            int optionNumber;
            while ((!int.TryParse(op, out optionNumber)))
            {
                ConsoleError("Input must be a number\n");
                op = Console.ReadLine();
            }
            return optionNumber;
        }

        //PATH INPUT
        public static string ConsoleReadPath()
        {
            ConsoleOutput("Enter the path of the image file:\n");
            string path = Console.ReadLine();
            while (!File.Exists(path))
            {
                ConsoleError("The file or path does not exist, try again\n");
                path = Console.ReadLine();
            }

            return path;
        }

        //DIRECTORY INPUT
        public static List<string> ConsoleReadDirectory(List<string> extensionTypes)
        {
            List<string> paths = new List<string>();
            while (true)
            {
                ClearConsole();
                ConsoleOutput("Enter the path of the directory:\n");
                string path = Console.ReadLine();
                while (!Directory.Exists(path))
                {
                    ClearConsole();
                    ConsoleError("The directory or path does not exist, try again\n");
                    path = Console.ReadLine();
                }

                if (!Directory.EnumerateFiles(path).Any())
                {
                    ClearConsole();
                    ConsoleError("The directory is empty...");
                    continue;
                }

                paths = new List<string>();
                string[] allFiles = Directory.GetFiles(path);

                foreach (string file in allFiles)
                {
                    foreach (string i in extensionTypes)
                    {
                        if (Path.GetExtension(file) == i)
                        {
                            paths.Add(file);
                        }
                    }
                }

                if (!paths.Any())
                {
                    ClearConsole();
                    ConsoleError("No compatible files to import...");
                    continue;
                }

                break;
            }

            return paths;
        }

        //FILE INPUT
        public static string ConsoleReadFileName(string importDirectory, List<string> extensionTypes)
        {
            string fileName;
            ConsoleOutput("Enter the image file's name (don't add .jpg):\n");
            fileName = Console.ReadLine();

            int checker = 0;
            //int attempts = 0;
            //List<string> YNList = new List<string>() {"No", "Yes"};
            while (checker == 0)
            {
                foreach (string i in extensionTypes)
                {
                    if (File.Exists(Path.Combine(importDirectory, fileName +i )))
                    {
                        checker += 1;
                        fileName = Path.Combine(importDirectory, fileName + i);
                    }
                }

                //if (attempts == 3)
                //{
                //    ConsoleError($"Do you want to go back?\n");
                //    int op = ConsoleReadInput(YNList);
                //    switch (op)
                //    {
                //        case 0:
                //            break;
                //        case 1:
                //            checker += 1;
                //            fileName = "";
                //            break;
                //    }
                //    attempts = 0;
                //}

                if (checker == 0)
                {
                    ClearConsole();
                    //attempts += 1;
                    ConsoleError($"{fileName} does not exist in this directory, try again\n");
                    fileName = Console.ReadLine();
                }
            }

            return fileName;
        }

        //SAVE FILE AS...
        public static string ConsoleSaveAs(string path, string saveDirectory)
        {
            
            string extension = Path.GetExtension(path);
            string rawFileName = Console.ReadLine();
            string newFileName = rawFileName + extension;

            string uniqueFile = Path.Combine(saveDirectory, newFileName);
            while (File.Exists(uniqueFile))
            {
                ClearConsole();
                ConsoleError($"{rawFileName} already exists, please enter another name (don't add .jpg)\n");
                rawFileName = Console.ReadLine();
                newFileName = rawFileName + extension;
                uniqueFile = Path.Combine(saveDirectory, newFileName);
            }

            return newFileName;
        }

        //CLEAR CONSOLE
        public static void ClearConsole()
        {
            Console.ResetColor();
            Console.Clear();
        }
    }
}
