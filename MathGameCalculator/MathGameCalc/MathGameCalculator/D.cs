using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameCalculator
{
    internal class D
    {
        //method for division game
        internal static void Division()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Division\n");

            Random random = new Random();
            int number1 = random.Next(1, 101);
            int number2 = random.Next(1, 101);
            Console.WriteLine($"{number1} / {number2} = ? (Enter whole number)");

            int sum = number1 / number2;
            int userInput;
            bool isValid;

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
