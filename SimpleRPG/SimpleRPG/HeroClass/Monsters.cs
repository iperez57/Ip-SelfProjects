using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Monsters
    {
        protected int monsterHP;
        protected int monsterAttack;
        protected int monsterLevel;
        protected int monsterDefense;
        protected int monsterDodgeChance;

        public Monsters(int hp, int attack, int monsterDefense, int monsterDodgeChance, int level = 1)
        {
            monsterHP = hp;
            monsterAttack = attack;
            monsterLevel = level;
        }


    }

    internal class Goblin : Monsters
    {
        public Goblin() : base(30, 10, 5, 30)
        {

            
        }
    }

    internal class Hobgoblin : Monsters
    {
        public Hobgoblin() : base(50, 20, 10, 10)
        {

        }
    }

    internal class Orc : Monsters
    {
        public Orc() : base(80, 30, 15, 15)
        {

        }
    }

    internal class Skeleton : Monsters
    {
        public Skeleton() : base(40, 20, 15, 5)
        {

        }
    }
}
