using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

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
        public static int ConsoleReadInput()
        {
            string option = Console.ReadLine();
            int optionNumber;
            while (!int.TryParse(option, out optionNumber))
            {
                ConsoleError("Input must be a number\n");
                option = Console.ReadLine();
            }
            return optionNumber;
        }

        //PATH INPUT
        public static string ConsoleReadPath(int i=0)
        {

            string path = "";
            if (i == 0)
            {
                ConsoleOutput("Enter the path of the image file:\n");
                path = Console.ReadLine();
                while ((File.Exists(path) != true) || (path == "abort"))
                {
                    ConsoleError("The file or path does not exist, try again\n");
                    path = Console.ReadLine();
                }
            }

            if (i == 1)
            {
                ConsoleOutput("Enter the path of the directory:\n");
                path = Console.ReadLine();
                while ((Directory.Exists(path) != true) || (path == "abort"))
                {
                    ConsoleError("The directory or path does not exist, try again\n");
                    path = Console.ReadLine();
                }
            }

            return path;
        }

        //FILE INPUT
        public static string ConsoleReadFileName(string directory)
        {
            string file = "";
            ConsoleOutput("Enter the image file's name:\n");
            file = Console.ReadLine();
            while ((File.Exists(directory + "/" + file) != true) || (file == "abort"))
            {
                ConsoleError(file + " does not exist in this directory, try again\n");
                file = Console.ReadLine();
            }
            return file;
        }
    }
}
