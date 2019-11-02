using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace PhotoMaxF.InputOutput
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
            bool valid = false;
            int optionNumber;
            while (!valid)
            {
                if (int.TryParse(Console.ReadLine(), out optionNumber))
                {
                    if (optionNumber >= 0 && optionNumber < list.Count)
                    {
                        return optionNumber;
                    }
                    else
                    {
                        ConsoleError($"The option ({optionNumber}) is not valid, try again");
                    }
                }
                else
                {
                    ConsoleError("Input must be a number, try again\n");
                }
            }
            return -1;
        }

        //USER NUMBER INPUT
        public static int ConsoleReadNumber()
        {
            bool valid = false;
            int optionNumber;
            while (!valid)
            {
                if (int.TryParse(Console.ReadLine(), out optionNumber))
                {
                    return optionNumber;
                }
                else
                {
                    ConsoleError("Input must be a number, try again\n");
                }
            }
            return -1;
        }

        //PATH INPUT
        public static string ConsoleReadPath()
        {
            bool valid = false;

            ConsoleOutput("Enter the path of the image file (to go back enter -1): \n");  
            while (!valid)
            {
                string path = Console.ReadLine();
                if (path == "-1")
                {
                    return "/%void%/";
                }
                if (File.Exists(path))
                {
                    return path;
                }
                else
                {
                    ConsoleError("The file or path does not exist, try again\n");
                }
            }  
            return "/%void%/";
        }

        //DIRECTORY INPUT
        public static List<string> ConsoleReadDirectory(List<string> extensionTypes)
        {
            bool valid = false;
            while (!valid)
            {
                ClearConsole();
                List<string> paths = new List<string>();
                ConsoleOutput("Enter the path of the directory (to go back enter -1):\n");
                string path = Console.ReadLine();

                if (path == "-1")
                {
                    return new List<string>() {"/%void%/"};
                }

                if (Directory.Exists(path))
                {
                    if (!Directory.EnumerateFiles(path).Any())
                    {
                        ClearConsole();
                        ConsoleError("The directory is empty...");
                        Thread.Sleep(1500);
                        continue;
                    }

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
                        paths = new List<string>();
                        Thread.Sleep(1500);
                        continue;
                    }
                }
            }
            return new List<string>(){"/%void%/"};
        }

        //FILE INPUT
        public static string ConsoleReadFileName(string importDirectory, List<string> extensionTypes, string title="")
        {
            bool valid = false;
            if (title == "")
            {
                ConsoleOutput("Enter the image file's name (don't add .jpg and to go back enter -1):\n");
            }
            else
            {
                ConsoleOutput(title);
            }
            
            while (!valid)
            {
                string fileName = Console.ReadLine();
                if (fileName == "-1")
                {
                    return "/%void%/";
                }
                foreach (string i in extensionTypes)
                {
                    if (File.Exists(Path.Combine(importDirectory, fileName + i)))
                    {
                        fileName = Path.Combine(importDirectory, fileName + i);
                        return fileName;
                    }
                }

                ConsoleError($"{fileName} does not exist in this directory, try again\n");
            }
            return "/%void%/";
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
