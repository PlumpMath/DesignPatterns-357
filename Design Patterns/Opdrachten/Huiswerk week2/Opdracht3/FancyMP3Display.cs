using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class FancyMP3Display : IObserver
    {
        private ISubject mp3player;

        public FancyMP3Display(ISubject player)
        {
            this.mp3player = player;
            mp3player.AddObserver(this);
        }
        public void Update(Nummer nummer)
        {
            Console.WriteLine("Huidige nummer van de fancy display is: " + nummer.titel + nummer.artiest);
        }
    }
}
