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
                Console.WriteLine("\nYour Turn!");
                bool validAction = false;
                
                do
                {
                    Console.WriteLine("Choose an action: 1. Attack 2. Defend");
                    string action = Console.ReadLine()?.Trim();
                    switch (action)
                    {
                        case "1":
                        case "fight":
                            Console.WriteLine("You Attack!");
                            HeroAttack(selectedHero, enemies);
                            validAction = true;
                            break;
                        case "2":
                        case "defend":
                            Console.WriteLine("You Defend!");
                            DefendPlayer(selectedHero);
                            validAction = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice! Try again");
                            break;
                    }
                } while(!validAction);

                // Enemy's turn logic here...
                Console.WriteLine("\nEnemy Turn!");
                foreach (var enemy in enemies)
                {
                    if (enemy.monsterHP > 0)
                    {
                        Console.WriteLine($"A {enemy.monsterType} attacks you!");
                        MonsterAttack(selectedHero, enemy);
                    }
                }
            }
            if (selectedHero.heroHP <= 0)
            {
                Console.WriteLine("\nYou have been defeated...");
            }
        }
        private static void HeroAttack(HeroClass selectedHero, List<Monsters> enemies)
        {
            // Example attack logic (targets the first enemy with HP > 0)
            foreach (var enemy in enemies)
            {
                if (enemy.monsterHP > 0)
                {
                    enemy.monsterHP -= selectedHero.heroAttack; // Damage calculation
                    Console.WriteLine($"You dealt {selectedHero.heroAttack} damage to a {enemy.monsterType}!");
                    if (enemy.monsterHP <= 0)
                    {
                        Console.WriteLine($"You defeated an {enemy.monsterType}!");
                    }
                    break;
                }
            }
        }

        private static void DefendPlayer(HeroClass selectedHero)
        {
            // Example defense logic
            Console.WriteLine($"You braces for impact, reducing incoming damage!");
            selectedHero.heroDefense += 5; // Temporary defense boost
        }

        private static void MonsterAttack(HeroClass selectedHero, Monsters enemy)
        {
            // Example enemy attack logic
            int damage = Math.Max(enemy.monsterAttack - selectedHero.heroDefense, 0); // Damage reduced by defense
            selectedHero.heroHP -= damage;
            Console.WriteLine($"A {enemy.monsterType} dealt {damage} damage to you! Your HP is now {selectedHero.heroHP}.");
        }
       
    }
}