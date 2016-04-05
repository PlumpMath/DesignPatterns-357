using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_opdracht3
{
    class PotloodSlijper : IPotloodSlijper
    {

        public void Slijp(IPotlood potlood)
        {
            potlood.Nageslepen();
        }
    }
}
