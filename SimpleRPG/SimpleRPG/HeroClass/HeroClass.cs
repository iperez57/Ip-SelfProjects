using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class HeroClass
    {
        protected int heroHP;
        protected int heroAttack;
        protected int heroLevel;
        protected string heroClass;
        protected int heroDefense;
        protected int heroDodgeChance;
        protected int heroExperience;
        

        public HeroClass()
        {
            heroLevel = 1;
            heroExperience = 0;

        }

        internal void DisplayStats()
        {
            Console.WriteLine($"Class: {heroClass}, HP: {heroHP}, Attack: {heroAttack}, Level: {heroLevel}, Defense: {heroDefense}, Dodge Chance: {heroDodgeChance}%");
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
            heroDodgeChance = 25;
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
            heroDodgeChance = 15;
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
            heroDodgeChance = 10;

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
            heroDodgeChance = 5;

        }
    }

}
