using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versie2.Models
{
    public interface ITreinReis
    {
        void VolgendeStation();
        void AddDisplay(ITreinDisplay display);
        void RemoveDisplay(ITreinDisplay display);
        void NotifyDisplays();
        Station GetStation(int huidigstation);
    }
}
