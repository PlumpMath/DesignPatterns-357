using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPotlood p = new Potlood(20);
            string boodschap = "Deze regel is meer dan 20 karakters lang";
            p.Schrijf(boodschap);
            if (!p.IsScherp)
            {
                IPotloodSlijper slijper = new PotloodSlijper();
                slijper.Slijp(p);
            }
            boodschap = "Potlood is weer ok!";
            p.Schrijf(boodschap);

            Console.ReadKey();
        }
    }
}
