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

        //public MonsterBuilder[] Monsters1 { get => Monsters; set => Monsters = value; } --> csináltunk még egy példányt a .CreateMobsból, de ez a példány meg fogja kapni a Monsters, tehát az első példány összes változását is.
        public Fight()
        {
            this.dice = roll.Next(1, 6);
        }

        private void Attack(int MonstersIndexAttacker, int MonstersIndexDefender)
        {
            Monsters[MonstersIndexDefender].ActualHealth -= Monsters[MonstersIndexAttacker].AttackRate + dice;
        }
        public bool IsSomeoneDied(int MonstersIndexAttacker, int MonstersIndexDefender)
        {
            if (Monsters[MonstersIndexAttacker].ActualHealth <= 0 || Monsters[MonstersIndexDefender].ActualHealth <= 0)
            {
                return true;
            }
            else return false;
        }
        public string MonsterHealthStatus(int MonstersIndex)
        {
            return Convert.ToString(Monsters[MonstersIndex].ActualHealth);
        }
        public string Battle (int MonstersIndexAttacker, int MonstersIndexDefender)
        {
            while (!IsSomeoneDied(MonstersIndexAttacker, MonstersIndexDefender))
            {
                Attack(MonstersIndexAttacker, MonstersIndexDefender);
                Console.WriteLine("{0}'s health: {1}", Monsters[MonstersIndexAttacker].Name, Monsters[MonstersIndexAttacker].ActualHealth);
                Console.WriteLine("{0}'s health: {1}", Monsters[MonstersIndexDefender].Name, Monsters[MonstersIndexDefender].ActualHealth);
                Attack(MonstersIndexDefender, MonstersIndexAttacker);
            }


            string winner = CheckActualHealths(MonstersIndexAttacker, MonstersIndexDefender);
            return winner;
        }
        public string CheckActualHealths(int MonstersIndexAttacker, int MonstersIndexDefender)
        {
            string live;

            if(Monsters[MonstersIndexAttacker].ActualHealth > Monsters[MonstersIndexDefender].ActualHealth)
            {
                live = Convert.ToString(Monsters[MonstersIndexAttacker].Name);
            }
            else
            {
                live = Convert.ToString(Monsters[MonstersIndexDefender].Name);
            }
            return live;
        }






    }
}
