using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class MainSystem
    {
        //construct
        public MainSystem()
        {
            DoSomeMainWork();

            SubSystem subSystem = new SubSystem();
        }

        //methods
        private void DoSomeMainWork()
        {
            Logger logger = Logger.GetInstance();

            logger.Log("MainSystem", "doing some main work");
        }
    }
}
