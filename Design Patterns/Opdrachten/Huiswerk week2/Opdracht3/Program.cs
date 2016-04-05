using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Mp3player player = new Mp3player();
            
            IObserver mp3Display1 = new SimpleMP3Display(player);
            IObserver mp3Display2 = new FancyMP3Display(player);

            player.NummerGewijzigd();
            player.NummerGewijzigd();
            player.NummerGewijzigd();

            Console.ReadKey();
        }
    }
}
