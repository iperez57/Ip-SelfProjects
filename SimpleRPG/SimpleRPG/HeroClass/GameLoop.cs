using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class GameLoop
    {
        internal static void gameObjective(HeroClass selectedHero)
        {
            Console.Clear();
            Console.WriteLine("Your goal of this game is to make it to the village.\n\n");
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
            walkForestPath(selectedHero);
        }

        internal static void walkForestPath(HeroClass selectedHero)
        {
            do
            {

            
            Console.Clear();
            Console.WriteLine("You stumble upon a path that leads to 2 different areas, something passed by here and the signs are all broken.\n\n");
            Console.WriteLine("Which path do you want to go through? left, right");
            string pathForest = Console.ReadLine().ToLower().Trim();

            switch (pathForest)
                {
                    case "left":
                        ForestPath.forestLeft(selectedHero);
                        break;
                    case "right":
                        ForestPath.forestright(selectedHero);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose left, right, or straight.");
                        Console.WriteLine("Press any key to try again...");
                        Console.ReadKey();
                        continue;
                }
                break;

            }while (true);

        }
    }
}
