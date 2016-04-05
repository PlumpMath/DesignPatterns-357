using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opdrachtenweek3.Models;

namespace opdrachtenweek3.Controllers
{
    class TreinController : ITreinController, ITreinReis
    {
        private ITreinReis treinreis;

        public TreinController(ITreinReis treinreis)
        {
            this.treinreis = treinreis;
        }

        public void VolgendeStation()
        {
            treinreis.VolgendeStation();
        }


        public void AddDisplay(ITreinDisplay display)
        {
            throw new NotImplementedException();
        }

        public void RemoveDisplay(ITreinDisplay display)
        {
            throw new NotImplementedException();
        }

        public void NotifyDisplays()
        {
            treinreis.NotifyDisplays();
        }
    }
}
