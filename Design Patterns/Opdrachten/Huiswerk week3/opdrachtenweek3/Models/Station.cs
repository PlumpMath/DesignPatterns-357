using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdrachtenweek3.Models
{
    public class Station
    {
        public string station { get; set; }
        public string aankomstSpoor { get; set; }
        public DateTime aankomstTijd { get; set; }
        public DateTime vertrekTijd { get; set; }

        public Station(string station, string aankomstSpoor, DateTime aankomstTijd, DateTime vertrekTijd)
        {
            this.station = station;
            this.aankomstSpoor = aankomstSpoor;
            this.aankomstTijd = aankomstTijd;
            this.vertrekTijd = vertrekTijd;
        }
        
    }
}
