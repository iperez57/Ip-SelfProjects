using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Menu
    {
        internal static void MenuStart()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome Hero");
                Console.WriteLine("Choose your class:");
                Console.WriteLine("Archer");
                Console.WriteLine("Warrior");
                Console.WriteLine("Mage");
                Console.WriteLine("Tank");
                Console.WriteLine("Type which class you want to choose:");
                string classSelection = Console.ReadLine().ToLower().Trim();

                if (string.IsNullOrWhiteSpace(classSelection))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                HeroClass selectedHero = null;

                switch (classSelection)
                {
                    case "archer":
                        selectedHero = new Archer();
                        break;
                    case "warrior":
                        selectedHero = new Warrior();
                        break;
                    case "mage":
                        selectedHero = new Mage();
                        break;
                    case "Tank":
                        selectedHero = new Tank();
                        break;
                    default:
                        Console.WriteLine("Invalid class selection.");
                        break;
                }
                selectedHero.DisplayStats();

                Console.WriteLine("\nDo you want to continue with this hero? (y/n)");
                string continueChoice = Console.ReadLine().ToLower().Trim();



            } while (true);
        }
    }
}
