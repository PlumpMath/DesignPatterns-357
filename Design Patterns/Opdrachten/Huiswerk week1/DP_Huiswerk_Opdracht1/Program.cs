using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Huiswerk_Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boekhandel burna = new Boekhandel("burna");

            burna.inventory.Add(new Boek("Wouter", "Gunz", 9, 5));
            burna.inventory.Add(new Weekblad("09-10-15", "Jup", 5, 6));
            burna.inventory.Add(new Cd("Pascal", "FML", 9, 5));

            burna.PrintOverzicht();

            Console.ReadKey();

        }
    }
}
