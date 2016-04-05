using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdrachtenweek3.Models
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
            huidigstation = 0;
        }

        public void VolgendeStation()
        {
            this.huidigstation++;
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
    }
}

