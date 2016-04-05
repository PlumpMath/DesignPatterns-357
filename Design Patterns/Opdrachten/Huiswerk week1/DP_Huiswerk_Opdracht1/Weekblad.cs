using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Huiswerk_Opdracht1
{
    class Weekblad : BoekhandelItem
    {
        public string  uitgifteDag { get; set; }

        public Weekblad(string uitgifteDag, string titel, float prijs, int aantal) : base(titel, prijs, aantal)
        {
            this.uitgifteDag = uitgifteDag;
        }

        public override string ToString()
        {
            return String.Format("[Boek] '{0}', ({1})", titel, uitgifteDag);
        }
    }
}
