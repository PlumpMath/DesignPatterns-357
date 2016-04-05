using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto();
            Vrachtwagen v = new Vrachtwagen();

            a.Test();
            v.Test();

            Console.ReadLine();
        }
    }
}
