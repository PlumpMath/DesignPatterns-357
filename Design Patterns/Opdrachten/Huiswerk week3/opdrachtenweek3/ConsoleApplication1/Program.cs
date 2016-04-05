using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime one = new DateTime(2015, 12, 03, 12, 46, 00);
            Console.WriteLine("Today is " + one.ToString("hh : mm") + ".");
            Console.ReadLine();
        }
    }
}
