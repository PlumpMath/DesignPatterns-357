using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    public class Mp3player : ISubject
    {
        public Nummer HuidigNummer { get; private set; }
        public List<Nummer> nummers = new List<Nummer>();
        private List<IObserver> mp3Displays = new List<IObserver>();
        Random random = new Random();

        public void NummerGewijzigd()
        {
            int r = random.Next(nummers.Count());
            HuidigNummer = nummers[r];
            NotifyObservers();
        }

        public void AddObserver(IObserver observer)
        {
            mp3Displays.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            mp3Displays.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver display in this.mp3Displays)
            {
                display.Update(HuidigNummer);
            }
        }

        public Mp3player()
        {
            Nummer nummer1 = new Nummer("Titel1", "Jan");
            Nummer nummer2 = new Nummer("Titel2", "Gozer");
            Nummer nummer3 = new Nummer("Titel3", "Wesley");
            nummers.Add(nummer1);
            nummers.Add(nummer2);
            nummers.Add(nummer3);

        }
    }
}
