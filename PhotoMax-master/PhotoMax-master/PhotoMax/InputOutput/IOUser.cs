using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

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



    }
}
