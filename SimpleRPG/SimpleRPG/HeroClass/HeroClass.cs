using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class HeroClass
    {
        public int heroHP;
        public int heroAttack;
        public int heroLevel;
        public string heroClass;
        public int heroDefense;
        

        public HeroClass()
        {

        }

        internal void DisplayStats()
        {
            Console.WriteLine($"Class: {heroClass}, HP: {heroHP}, Attack: {heroAttack},Defense: {heroDefense}");
        }
    }
    internal class Archer : HeroClass
    {
        public Archer()
        {
            heroHP = 130;
            heroAttack = 20;
            heroClass = "Archer";
            heroDefense = 10;

        }
    }

    internal class Warrior : HeroClass
    {
        public Warrior()
        {
            heroHP = 125;
            heroAttack = 15;
            heroClass = "Warrior";
            heroDefense = 15;

        }
    }
    internal class Mage : HeroClass
    {
        public Mage()
        {
            heroHP = 100;
            heroAttack = 25;
            heroClass = "Mage";
            heroDefense = 5;


        }
    }

    internal class Tank : HeroClass
    {
        public Tank()
        {
            heroHP = 150;
            heroAttack = 5;
            heroClass = "Tank";
            heroDefense = 20;


        }
    }

}
