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

        public MonsterBuilder[] Monsters1 { get => Monsters; set => Monsters = value; }

        public void Attack()
        {
            Console.WriteLine("{0} health: {1} ", Monsters1[1].Name, Monsters1[1].ActualHealth);
            Console.WriteLine("{0} health: {1} ", Monsters1[0].Name, Monsters1[0].ActualHealth);

            Console.WriteLine("\n");

            Console.WriteLine("{0} going to hit {1} with {2} attack power ", Monsters1[1].Name, Monsters1[0].Name, Monsters1[1].AttackRate);
            Console.ReadKey();

            Monsters1[0].ActualHealth -= Monsters1[1].AttackRate;

            Console.WriteLine("{0} health: {1} ", Monsters1[1].Name, Monsters1[1].ActualHealth);
            Console.WriteLine("{0} health: {1} ", Monsters1[0].Name, Monsters1[0].ActualHealth);
            Console.ReadKey();

        }

        public Fight()
        {
            this.dice = roll.Next(1, 101);
        }




    }
}
