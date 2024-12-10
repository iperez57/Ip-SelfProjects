using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class CombatSystem
    {
        public static void StartBattle(HeroClass selectedHero, List<Monsters> enemies)
        {
            Console.WriteLine("Combat has started!");
            Console.WriteLine("\nEnemy Stats:");
            foreach (var enemy in enemies)
            {
                    enemy.DisplayStats();
            }

            while (selectedHero.heroHP > 0)
            {
                bool enemiesAlive = false;

                foreach (var enemy in enemies)
                {
                    if (enemy.monsterHP > 0)
                    {
                        enemiesAlive = true;
                        break; // Exit loop when an enemy with HP > 0 is found
                    }
                }

                if (!enemiesAlive)
                {
                    Console.WriteLine("You defeated all the enemies!");
                    break; // Exit the combat loop
                }

                // Player's turn logic here...

                // Enemy's turn logic here...
            }
        }
    }
}
