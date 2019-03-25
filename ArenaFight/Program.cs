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

            fight.Attack();

            Console.ReadKey();
        }
    }
}
