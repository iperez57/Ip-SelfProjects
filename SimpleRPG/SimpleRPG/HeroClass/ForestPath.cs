using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class ForestPath
    {
        public static void forestright(HeroClass selectedHero)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("You decided to walk right and encountered a wide river. Do you want to cross the bridge ahead of you or go right ?");
                Console.WriteLine("Which path do you want to go through? 1. cross the bridge 2. right?");
                string pathRiver = Console.ReadLine().ToLower().Trim();

                switch (pathRiver)
                {
                    case "bridge":
                        RiverPath.riverBridgeForest(selectedHero);
                        break;
                    case "right":
                        RiverPath.riverRightForest(selectedHero);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose left or right");
                        Console.WriteLine("Press any key to try again...");
                        Console.ReadKey();
                        continue;
                }
                break;
            } while (true);

        }

        public static void forestLeft(HeroClass selectedHero)
        {
            Console.Clear();
            Console.WriteLine("You went left and a see 3 goblins around an object you can't see what it is yet. After a few seconds one turns around and spots you and they begin to charge towards you.");
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. Run");

            List<Monsters> goblins = new List<Monsters>
            {
                new Goblin(),
                new Goblin(),
                new Goblin()
            };


            string choice = Console.ReadLine().ToLower().Trim();

            switch (choice)
            {
                case "1":
                case "fight":

                    CombatSystem.StartBattle(selectedHero, goblins);
                    RiverPath.riverGoblinFight(selectedHero);
                    break;
                case "2":
                case "run":
                    Flee.AttemptEscape(selectedHero);
                    break;
                default:
                    Console.WriteLine("Invalid choice! The goblins close in!");
                    CombatSystem.StartBattle(selectedHero, goblins); // Default to combat if input is invalid
                    break;
            }
        }

    }
}