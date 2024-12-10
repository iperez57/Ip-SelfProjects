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
                Console.WriteLine("You decided to walk straight and encountered a wide river. Do you want to cross the bridge ahead of you, go left, or go right ?");
                Console.WriteLine("Which path do you want to go through? left, right, straight.");
                string pathRiver = Console.ReadLine().ToLower().Trim();

                switch (pathRiver)
                {
                    case "left":
                        RiverPath.riverLeft();
                        break;
                    case "right":
                        RiverPath.riverRight();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose left, right, or straight.");
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
                    break;
                case "2":
                case "run":
                    AttemptEscape(selectedHero);
                    break;
                default:
                    Console.WriteLine("Invalid choice! The goblins close in!");
                    CombatSystem.StartBattle(selectedHero, goblins); // Default to combat if input is invalid
                    break;
            }
        }

        private static void AttemptEscape(HeroClass selectedHero)
        {
            Console.Clear();
            Console.WriteLine("You try to run away...");
            Random rng = new Random();
            if (rng.Next(0, 100) < 50) // 50% chance to escape
            {
                Console.WriteLine("You successfully escape the goblins!");
                Console.ReadKey();
                // Return to the previous method or path selection
            }
            else
            {
                Console.WriteLine("You failed to escape! The goblins catch up.");
                Console.ReadKey();
                List<Monsters> goblins = new List<Monsters>
                {
                    new Goblin(),
                    new Goblin(),
                    new Goblin()
                };
                CombatSystem.StartBattle(selectedHero, goblins);
            }
        }
    }
}