using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Huiswerk_Opdracht1
{
    public abstract class BoekhandelItem
    {
        public string  titel { get; set; }
        public float prijs { get; set; }
        public int aantal { get; set; }


        public BoekhandelItem(string titel, float prijs, int aantal)
        {
            this.titel = titel;
            this.prijs = prijs;
            this.aantal = aantal;
        }
    }
}
