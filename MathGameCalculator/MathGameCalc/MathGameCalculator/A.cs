using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameCalculator
{
    internal class A
    {
        //method for addition game
        internal static void Addition()
        {

            Console.Clear();
            Console.WriteLine("Welcome to Addition\n");

            Random random = new Random();
            int number1 = random.Next(1, 101);
            int number2 = random.Next(1, 101);
            Console.WriteLine($"{number1} + {number2} = ?");

            int sum = number1 + number2;
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
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();


        }
    }
}
