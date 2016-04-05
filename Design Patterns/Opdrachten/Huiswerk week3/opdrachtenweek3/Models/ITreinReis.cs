using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdrachtenweek3.Models
{
    public interface ITreinReis
    {
        void VolgendeStation();
        void AddDisplay(ITreinDisplay display);
        void RemoveDisplay(ITreinDisplay display);
        void NotifyDisplays();
    }
}
