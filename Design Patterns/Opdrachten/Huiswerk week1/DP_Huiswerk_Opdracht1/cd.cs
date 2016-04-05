using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Huiswerk_Opdracht1
{
    class Cd : BoekhandelItem
    {
        public string artiest { get; set; }

        public Cd(string artiest, string titel, float prijs, int aantal) : base(titel, prijs, aantal)
        {
            this.artiest = artiest;
        }

        public override string ToString()
        {
            return String.Format("[Boek] '{0}', ({1})", titel, artiest);
        }
    }
}
