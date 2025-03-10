﻿using System;
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

            
            var history = new List<string>();
            string inputName;
            do
            {
                Console.WriteLine("Please Enter your Name: ");
                inputName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputName))
                {
                    Console.WriteLine("Invalid input. Please enter a valid name.");
                }
                else
                {
                    Console.WriteLine($"Hello, {inputName}!");
                    break; // Exit the loop once a valid name is entered.
                }
            } while (true);

            Console.Clear();
            MenuSelection(inputName, history);
        }

        //reads user input for what game they want to play.
        internal static void MenuSelection(string inputName, List<string> history)
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"Welcome {inputName}!\n");
                Console.WriteLine("What game would you like to play?\n");
                Console.WriteLine("A: Addition");
                Console.WriteLine("S: Subtraction");
                Console.WriteLine("D: Division");
                Console.WriteLine("M: Multiplication");
                Console.WriteLine("H: History");
                Console.WriteLine("Q: Quit\n");

                Console.WriteLine("Enter one of the options from above:");
                string gameSelection = Console.ReadLine().ToLower().Trim();

                if (string.IsNullOrWhiteSpace(gameSelection))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue; // Redisplay the menu if the input is invalid
                }

                switch (gameSelection)
                {
                    case "a":
                        A.Addition(history);
                        break;
                    case "s":
                        S.Subtraction(history);
                        break;
                    case "d":
                        D.Division(history);
                        break;
                    case "m":
                        M.Multiplication(history);
                        break;
                    case "h":
                        H.History(history);
                        break;
                    case "q":
                        Console.WriteLine("Thanks for playing! Goodbye!");
                        return; // Exit the loop and program
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (true);
        }
    }
}
