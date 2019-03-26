using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class Monsters
    {
      //private MonsterBuilder Bruti = new MonsterBuilder("Bruti", EvilOrNot, Health, Armor, Strength, Speed, Intelligence );
        private MonsterBuilder ElvenGhst = new MonsterBuilder("Elven Ghost Scout", false, 60, 40, 25, 15, 20);
        private MonsterBuilder OrcWarrior = new MonsterBuilder("Weak orc warrior", true, 25, 5, 12, 7, 4);
        private MonsterBuilder OrcShaman = new MonsterBuilder("Orc Shaman", true, 70, 5, 8, 10, 20);
        
        public MonsterBuilder[] CreateMobs
        {
           get { return new MonsterBuilder[3] { ElvenGhst, OrcWarrior, OrcShaman }; }
        }

        public void MonsterStats()
        {

        }


    }
}
