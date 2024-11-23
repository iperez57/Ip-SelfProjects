using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameCalculator
{
    internal class GameStart
    {
        //shows the menu for all the different math games available
        internal static void StartScreen()
        {
            Console.Clear();
            Console.WriteLine("Please Enter your UserName: ");
            string input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Welcome: {input}\n");
            Console.WriteLine("What game would you like to play?\n");
            Console.WriteLine("A: Addition");
            Console.WriteLine("S: Subtraction");
            Console.WriteLine("D: Division");
            Console.WriteLine("M: Multiplication\n");
            MenuSelection();
        }
        //asdf

        //reads user input for what game they want to play.
        internal static void MenuSelection()
        {

            Console.WriteLine("Enter one of the Options from above");
            string gameSelection = Console.ReadLine().ToLower().Trim();
            switch (gameSelection)
            {
                case "a":
                    A.Addition();
                    break;
                case "s":
                    S.Subtraction();
                    break;
                case "d":
                    D.Division();
                    break;
                case "m":
                    M.Multiplication();
                    break;
            }

        }
    }
}
