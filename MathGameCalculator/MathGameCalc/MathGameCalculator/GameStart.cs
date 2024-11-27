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
            string input;
            do
            {
                Console.WriteLine("Please Enter your Name: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input. Please enter a valid name.");
                }
                else
                {
                    Console.WriteLine($"Hello, {input}!");
                    break; // Exit the loop once a valid name is entered.
                }
            } while (true);

            Console.Clear();
            MenuOptions(input);
        }

        private static void MenuOptions(string input)
        {
            Console.WriteLine($"Welcome: {input}\n");
            Console.WriteLine("What game would you like to play?\n");
            Console.WriteLine("A: Addition");
            Console.WriteLine("S: Subtraction");
            Console.WriteLine("D: Division");
            Console.WriteLine("M: Multiplication\n");
            MenuSelection();
        }

        //reads user input for what game they want to play.
        internal static void MenuSelection()
        {
            do
            {
                Console.WriteLine("Enter one of the Options from above");
                string gameSelection = Console.ReadLine().ToLower().Trim();
                if (string.IsNullOrWhiteSpace(gameSelection))
                    Console.WriteLine("Enter a valid option:");
                else
                {
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
            } while(true);

        }
    }
}
