using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameCalculator
{
    internal class H
    {
        internal static void History(List<string> history)
        {
            Console.Clear();
            Console.WriteLine("Game History:\n");

            if (history.Count == 0)
            {
                Console.WriteLine("No games played yet!");
            }
            else
            {
                foreach (var record in history)
                {
                    Console.WriteLine(record);
                }
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
    }
}
