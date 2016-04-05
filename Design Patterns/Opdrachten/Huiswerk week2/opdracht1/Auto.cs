using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1
{
    class Auto : Voertuig
    {
        public override void Starten()
        {

            Console.WriteLine("Start auto...");
        }

        public override void Stoppen()
        {
            Console.WriteLine("Stop auto...");
        }
    }
}
