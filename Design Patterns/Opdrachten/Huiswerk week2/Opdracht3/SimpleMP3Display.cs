using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class SimpleMP3Display : IObserver
    {
        private ISubject mp3Player;

        public void Update(Nummer nummer)
        {
            Console.WriteLine("Huidige nummer van de simple display is: " + nummer.titel);
        }

        public SimpleMP3Display(ISubject player)
        {
            this.mp3Player = player;
            mp3Player.AddObserver(this);
        }
    }
}
