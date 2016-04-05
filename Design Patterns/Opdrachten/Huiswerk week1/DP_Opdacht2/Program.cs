using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdacht2
{
    class Program
    {
        static void Main(string[] args)
        {
            IVliegbaar s = new Superman();
            IVliegbaar v = new Vliegtuig();

            MaakVlucht(s);
            MaakVlucht(v);

            Console.ReadLine();
        }


            static void MaakVlucht(IVliegbaar item)
            {
                item.Opstijgen();
                item.Vliegen();
                item.Vliegen();
                item.Vliegen();
                item.Landen();
                Console.WriteLine();
            }
    }
}
