using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Flee
    {
        public static void AttemptEscape(HeroClass selectedHero)
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
