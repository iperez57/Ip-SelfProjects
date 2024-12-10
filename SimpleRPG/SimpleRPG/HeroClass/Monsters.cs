using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Monsters
    {
        public int monsterHP;
        public int monsterAttack;
        public int monsterLevel;
        public int monsterDefense;
        public int monsterDodgeChance;
        public string monsterType;

        public Monsters(int hp, int attack, int monsterDefense, int monsterDodgeChance, int level = 1)
        {
            monsterHP = hp;
            monsterAttack = attack;
            monsterLevel = level;
        }
        public void DisplayStats()
        {
            Console.WriteLine($"{monsterType} - HP: {monsterHP}, Attack: {monsterAttack}, Defense: {monsterDefense}, Dodge Chance: {monsterDodgeChance}%, Level: {monsterLevel}");
        }


    }

    internal class Goblin : Monsters
    {
        public Goblin() : base(15, 10, 5, 30)
        {
            monsterType = "Goblin";
            
        }
    }

    internal class Hobgoblin : Monsters
    {
        public Hobgoblin() : base(20, 20, 10, 10)
        {
            monsterType = "Hobgoblin";
        }
    }

    internal class Orc : Monsters
    {
        public Orc() : base(40, 30, 15, 15)
        {
            monsterType = "Orc";
        }
    }

    internal class Skeleton : Monsters
    {
        public Skeleton() : base(25, 20, 15, 5)
        {
            monsterType = "Skeleton";
        }
    }
}
