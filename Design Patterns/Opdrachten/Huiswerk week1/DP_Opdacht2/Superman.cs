using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdacht2
{
    class Superman : IVliegbaar
    {

        public void Opstijgen()
        {
            Console.WriteLine("Superman aan het opstijgen");
            
        }

        public void Vliegen()
        {
            Console.WriteLine("Superman lekker aan het vliegen");
        }

        public void Landen()
        {
            Console.WriteLine("Superman aan het landen");
        }
    }
}
