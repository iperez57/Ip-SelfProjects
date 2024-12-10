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
            Console.WriteLine("River Right");
        }

        public static void riverLeftForest(HeroClass selectedHero)
        {
            Console.WriteLine("River Left");
        }

        public static void riverGoblinFight(HeroClass selectedHero)
        {
            Console.WriteLine("You continue walking straight and stumble upon a wide river with a bridge!");
            Console.WriteLine("Do you want to cross the 1. Cross Bridge 2. Go Left 3. Go Right ?");
        }

    }
}
