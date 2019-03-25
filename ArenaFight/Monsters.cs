using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class Monsters
    {
        private MonsterBuilder Bruti = new MonsterBuilder("Bruti", false, 60, 55, 8, 3, 2);
        private MonsterBuilder SwampOrc = new MonsterBuilder("Swamp Orc", true, 55, 30, 4, 7, 4);
        private MonsterBuilder OrcShaman = new MonsterBuilder("Orc Shaman", true, 20, 5, 3, 8, 5);
        
        public MonsterBuilder[] Mob
        {
            get { return new MonsterBuilder[3] { Bruti, SwampOrc, OrcShaman }; }
        }

        public void MonstarStats()
        {
            Console.WriteLine("{0} - war power: {1} ", Mob[0].Name, Mob[0].AttackRate);
            Console.WriteLine("{0} - war power: {1} ", Mob[1].Name, Mob[1].AttackRate);
            Console.WriteLine("{0} - war power: {1} ", Mob[2].Name, Mob[2].AttackRate);
        }


    }
}
