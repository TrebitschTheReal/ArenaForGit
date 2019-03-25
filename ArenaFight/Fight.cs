using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class Fight
    {
        private int dice;
        private Random roll = new Random();
        private MonsterBuilder[] Monsters = new Monsters().CreateMobs;

        public void Attack()
        {
            Console.WriteLine("{0} - war power: {1} ", Monsters[0].Name, Monsters[0].AttackRate);
            Console.WriteLine("{0} - war power: {1} ", Monsters[1].Name, Monsters[1].AttackRate);
            Console.WriteLine("{0} - war power: {1} ", Monsters[2].Name, Monsters[2].AttackRate);

            Console.WriteLine(Monsters[0].AttackRate);

        }

        public Fight()
        {
            this.dice = roll.Next(1, 101);
        }




    }
}
