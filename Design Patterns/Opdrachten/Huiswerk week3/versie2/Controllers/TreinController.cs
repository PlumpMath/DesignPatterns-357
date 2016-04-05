using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using versie2.Models;
using System.Windows.Forms;

namespace versie2.Controllers
{
    class TreinController : ITreinController
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
    }
}
