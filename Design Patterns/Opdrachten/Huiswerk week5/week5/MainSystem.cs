using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    public class MainSystem
    {
        Logger logger = Logger.GetInstance();

        public MainSystem()
        {
            
        }

        public void DoSomeMainWork()
        {
            logger.Log("[MainSystem] doing some main work");
        }

        public class SubSystem
        {
            Logger logger = Logger.GetInstance();

            public SubSystem()
            {
                
            }

            public void DoSomeMoreWork()
            {
                logger.Log("[SubSystem] doing some more work");
            }

            public void DoSomeWork()
            {
                logger.Log("[SubSystem] doing some work");
            }
        }
    }
}
