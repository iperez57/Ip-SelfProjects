using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameCalculator
{
    internal class S
    {
        //method for subtraction game
        internal static void Subtraction(List<string> history)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Subtraction\n");

                Random random = new Random();
                int number1 = random.Next(1, 101);
                int number2 = random.Next(1, 101);
                Console.WriteLine($"{number1} - {number2} = ?");

                int sum = number1 - number2;
                int userInput;
                bool isValid;

                // Check if the user provides the correct answer
                CorrectSum.CheckCorrectSum(sum, out userInput, out isValid, history);
                history.Add($"Subtraction: {number1} + {number2} = {sum} (Correct)");

                // Ask the user if they want to play again
                if (!PlayAgain.yesOrNo())
                {
                    Console.Clear();
                    Console.WriteLine("Returning to the main menu...");
                    return; // Exit the `Subtraction` method and return to the main menu
                }

            } while (true);
        }
    }
}
