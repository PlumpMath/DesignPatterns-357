using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versie2.Models
{
    public class Station
    {
        public string station { get; set; }
        public string aankomstSpoor { get; set; }
        public TimeSpan aankomstTijd { get; set; }
        public TimeSpan vertrekTijd { get; set; }

        public Station(string station, string aankomstSpoor, TimeSpan aankomstTijd, TimeSpan vertrekTijd)
        {
            this.station = station;
            this.aankomstSpoor = aankomstSpoor;
            this.aankomstTijd = aankomstTijd;
            this.vertrekTijd = vertrekTijd;
        }
        
    }
}
