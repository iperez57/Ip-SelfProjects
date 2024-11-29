using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameCalculator
{
    internal class PlayAgain
    {
        public static bool yesOrNo()
        {
            while (true)
            {
                Console.WriteLine("Would you like to play again? (Y/N)");
                string input = Console.ReadLine()?.Trim().ToUpper();

                if (input == "Y" ||  input == "YES")
                {
                    return true;
                }
                else if (input == "N" || input == "NO")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Y' or 'Yes' for Yes or 'N' or 'No' for No.");
                }
            }
        }

    }
}
