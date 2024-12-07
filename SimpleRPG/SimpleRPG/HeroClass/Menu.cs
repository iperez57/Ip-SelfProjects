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
                Console.WriteLine("Type which class you want to choose:\n");
                string classSelection = Console.ReadLine().ToLower().Trim();

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
                    case "tank":
                        selectedHero = new Tank();
                        break;
                    default:
                        continue;
                }
                selectedHero.DisplayStats();

                string continueChoice;
                do
                {
                    Console.WriteLine($"\nDo you want to continue with this hero({classSelection})? (y/n)");
                    continueChoice = Console.ReadLine().ToLower().Trim();

                    if (continueChoice != "y" && continueChoice != "n")
                    {
                        Console.Clear();
                        selectedHero.DisplayStats();
                        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    }
                } while (continueChoice != "y" && continueChoice != "n");

                if (continueChoice == "y")
                {
                    GameLoop.gameObjective();
                    break;
                }
                else
                {
                    Console.WriteLine("Please select a different hero.");
                }

            } while (true);

        }
    }
}
