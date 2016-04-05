using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_opdracht3
{
    class Potlood : IPotlood
    {
        private int maxTeSchrijven;
        private int geschrevenKarakters;

        public Potlood(int maxTeSchrijven)
        {
            this.maxTeSchrijven = maxTeSchrijven;
        }

        //public bool IsScherp()
        //{
        //    if (maxTeSchrijven == 0)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        public void Schrijf(string boodschap)
        {
            char[] characters = boodschap.ToCharArray();
            
            for (int i = 0; i < characters.Length; i++)
            {
                if (i > maxTeSchrijven)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(characters[i]);
                }
                
            }
            Console.WriteLine();
        }

        public void Nageslepen()
        {
            this.maxTeSchrijven = 25;
        }

        bool IPotlood.IsScherp
        {
            get
            {
                if (maxTeSchrijven == 0)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
