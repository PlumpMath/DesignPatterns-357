using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Huiswerk_Opdracht1
{
    class Boekhandel
    {
        public string naam { get; set; }
        public List<BoekhandelItem> inventory = new List<BoekhandelItem>();

        public Boekhandel(string naam)
        {
            this.naam = naam;
        }

        public void VoegToe(BoekhandelItem item)
        {
            this.inventory.Add(item);
        }

        public void PrintOverzicht()
        {
            foreach (var i in inventory)
            {
                Console.WriteLine(i);
            }
        }
    }
}
