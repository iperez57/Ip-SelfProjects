using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class RiverPath
    {
        public static void riverRightForest(HeroClass selectedHero)
        {
            Console.WriteLine("You see a hobgoblin and an orc heading your way");
            Console.WriteLine("DDo you want to 1. fight 2. run ?");

            List<Monsters> monsters = new List<Monsters>
            {
                new Orc(),
                new Hobgoblin()

            };


            string choice = Console.ReadLine().ToLower().Trim();

            switch (choice)
            {
                case "1":
                case "fight":

                    CombatSystem.StartBattle(selectedHero, monsters);
                    RiverPath.riverGoblinFight(selectedHero);
                    break;
                case "2":
                case "run":
                    Flee.AttemptEscape(selectedHero);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Themonsters close in!");
                    CombatSystem.StartBattle(selectedHero, monsters); // Default to combat if input is invalid
                    break;
            }

        }

        public static void riverBridgeForest(HeroClass selectedHero)
        {
            Console.WriteLine("You made it to the village");
        }

        public static void riverGoblinFight(HeroClass selectedHero)
        {
            Console.WriteLine("You continue walking straight and stumble upon a wide river with a bridge!");
            Console.WriteLine("Do you want to cross the 1. Cross Bridge 2. Go Right ?");
            string choice = Console.ReadLine().ToLower().Trim();

            switch (choice)
            {
                case "crossbridge":
                case "1":
                    Console.WriteLine("You found the village");
                    break;
                case "2":
                case "right":
                    Console.WriteLine("You makde it to the Village!");
                    break;
                default:
                    
                    Console.WriteLine("Invalid choice. Please choose left or right");
                    Console.WriteLine("Press any key to try again...");
                    Console.ReadKey();
                    break;
            }
        }

    }
}
