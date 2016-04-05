using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versie2.Models
{
    public class TreinReis : ITreinReis
    {
        private List<Station>stations;

        private List<ITreinDisplay> displays = new List<ITreinDisplay>();

        private int huidigstation;

        public TreinReis()
        {
            stations = new List<Station>();
            //voeg hardcoded stations toe.
            stations.Add(new Station("Leiden Centraal", "2b", new TimeSpan(13, 45, 00), new TimeSpan(13, 46, 00)));
            stations.Add(new Station("Voorhout", "2b", new TimeSpan(13, 50, 00), new TimeSpan(13, 51, 00)));
            stations.Add(new Station("Hillegom", "2a", new TimeSpan(13, 57, 00), new TimeSpan(13, 58, 00)));
            stations.Add(new Station("Heemstede-Aerdenhout", "2a", new TimeSpan(14, 02, 00), new TimeSpan(14, 03, 00)));
            stations.Add(new Station("Haarlem", "4", new TimeSpan(14, 07, 00), new TimeSpan(14, 08, 00)));
            huidigstation = 0;
        }

        public void VolgendeStation()
        {
            if (stations.Count() >= huidigstation)
            {
                
                this.huidigstation++;
                NotifyDisplays();
            }
            else
            {
                stations.Reverse();
                this.huidigstation = 1;
                NotifyDisplays();
            }
            // ...
        }

        public void AddDisplay(ITreinDisplay display)
        {
            this.displays.Add(display);
        }

        public void RemoveDisplay(ITreinDisplay display)
        {
            this.displays.Remove(display);
        }

        public void NotifyDisplays()
        {
            foreach (ITreinDisplay display in this.displays)
            {
                display.Update(huidigstation);
            }
        }

        public Station GetStation(int stationNummer)
        {
            Station station = stations[stationNummer];
            return station;
        }
    }
}

