using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class Monsters
    {
      //private MonsterBuilder Bruti = new MonsterBuilder("Bruti", EvilOrNot, Health, Armor, Strength, Speed, Intelligence);
        private MonsterBuilder Bruti = new MonsterBuilder("Bruti", false, 100, 55, 8, 3, 2);
        private MonsterBuilder SwampOrc = new MonsterBuilder("Swamp Orc", true, 55, 30, 4, 7, 4);
        private MonsterBuilder OrcShaman = new MonsterBuilder("Orc Shaman", true, 20, 5, 3, 8, 5);
        
        public MonsterBuilder[] CreateMobs
        {
            get { return new MonsterBuilder[3] { Bruti, SwampOrc, OrcShaman }; }
        }

        public void MonsterStats()
        {

        }


    }
}
