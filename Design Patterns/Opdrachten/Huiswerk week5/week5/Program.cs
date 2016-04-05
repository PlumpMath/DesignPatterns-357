using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    class Program
    {
        static void Main(string[] args)
        {
            MainSystem mainSystem = new MainSystem();
            MainSystem.SubSystem subSystem = new MainSystem.SubSystem();
            Logger logger = Logger.GetInstance();

            logger.Log("[main] starting");
            mainSystem.DoSomeMainWork();
            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
            logger.Log("[main] finishing");

            Console.ReadKey();
        }
    }
}
