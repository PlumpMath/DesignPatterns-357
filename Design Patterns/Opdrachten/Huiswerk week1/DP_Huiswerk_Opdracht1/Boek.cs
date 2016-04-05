using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Huiswerk_Opdracht1
{
    public class Boek : BoekhandelItem
    {
        public string auteur { get; set; }

        public Boek(string auteur, string titel, float prijs, int aantal) : base(titel, prijs, aantal)
        {
            this.auteur = auteur;
        }

        public override string ToString()
        {
            return String.Format("[Boek] '{0}', ({1})", titel, auteur);
        }
    }
}
