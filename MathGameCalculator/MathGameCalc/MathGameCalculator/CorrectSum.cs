using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameCalculator
{
    internal class CorrectSum
    {
        public static void CheckCorrectSum(int sum, out int userInput, out bool isValid, List<string> history)
        {
            do
            {
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out userInput);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                }
                else if (userInput != sum)
                {
                    Console.WriteLine("Incorrect. Try Again!");
                    
                }
            } while (!isValid || userInput != sum);

            Console.WriteLine("Correct!");

        }
    }
}
