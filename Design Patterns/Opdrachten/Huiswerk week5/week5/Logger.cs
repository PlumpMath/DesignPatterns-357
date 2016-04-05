using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    class Logger
    {
        public int numberOfLines { get; set; }
        private static Logger uniqueInstance { get; set; }

        private Logger()
        {

        }

        public void Log(string logregel)
        {
            numberOfLines++;
            Console.WriteLine(numberOfLines + " - " + logregel);
        }

        public static Logger GetInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }

            return uniqueInstance;
        }
    }
}
