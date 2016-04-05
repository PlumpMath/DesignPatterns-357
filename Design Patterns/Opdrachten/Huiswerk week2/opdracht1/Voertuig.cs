using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1
{
    public abstract class Voertuig
    {
        public bool isGestart = true;

        public void Test()
        {
            
            Starten();
            if(this.isGestart)
            {
                Rijden();
                Stoppen();
            }
        }

        public abstract void Starten();

        public void Rijden()
        {
            Console.WriteLine("Rijd lekker snel!!");
        }

        public abstract void Stoppen();
    }
}
