using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class SubSystem
    {
        //construct
        public SubSystem()
        {
            DoSomeWork();
            DoSomeMoreWork();
        }

        //methods
        private void DoSomeWork()
        {
            Logger logger = Logger.GetInstance();

            logger.Log("SubSystem", "doing some work");
        }

        private void DoSomeMoreWork()
        {
            Logger logger = Logger.GetInstance();

            logger.Log("SubSystem", "doing some more work");
        }
    }
}
