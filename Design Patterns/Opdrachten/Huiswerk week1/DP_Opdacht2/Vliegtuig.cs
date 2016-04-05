using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdacht2
{
    class Vliegtuig : IVliegbaar
    {

        public void Opstijgen()
        {
            Console.WriteLine("Vliegtuig aan het opstijgen");
        }

        public void Vliegen()
        {
            Console.WriteLine("Vliegtuig lekker aan het vliegen");
        }

        public void Landen()
        {
            Console.WriteLine("Vliegtuig aan het landen");
        }
    }
}
