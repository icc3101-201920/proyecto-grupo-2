﻿using System;
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
        public static string ConsoleReadPath(int i = 0)
        {

            string path = "";
            if (i == 0)
            {
                ConsoleOutput("Enter the path of the image file:\n");
                path = Console.ReadLine();
                while ((File.Exists(path) != true))
                {
                    ConsoleError("The file or path does not exist, try again\n");
                    path = Console.ReadLine();
                }
            }

            if (i == 1)
            {
                ConsoleOutput("Enter the path of the directory:\n");
                path = Console.ReadLine();
                while ((Directory.Exists(path) != true))
                {
                    ConsoleError("The directory or path does not exist, try again\n");
                    path = Console.ReadLine();
                }
            }
            if (i == 2)
            {
                ConsoleOutput("Enter the name of the file (add .jpg):\n");
                string fileN = Console.ReadLine();
                string importDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../PM-Images/Imports");
                while ((File.Exists(Path.Combine(importDirectory, fileN)) != true))
                {
                    ConsoleError("The file does not exist, try again\n");
                    fileN = Console.ReadLine();
                }
                path = Path.Combine(importDirectory, fileN);
            }

            return path;
        }

        //FILE INPUT
        public static string ConsoleReadFileName(string directory)
        {
            string file;
            ConsoleOutput("Enter the image file's name:\n");
            file = Console.ReadLine();
            while ((File.Exists(Path.Combine(directory, file)) != true))
            {
                ConsoleError(file + " does not exist in this directory, try again\n");
                file = Console.ReadLine();
            }
            return file;
        }

        //CLEAR CONSOLE
        public static void ClearConsole()
        {
            Console.ResetColor();
            Console.Clear();
        }
    }
}
