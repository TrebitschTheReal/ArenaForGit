using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class Program
    {
        static void Main()
        {
            var fight = new Fight();
            string winner;

            winner = fight.Battle(0,2);
            Console.WriteLine(winner);



            Console.ReadKey();
        }
    }
}
