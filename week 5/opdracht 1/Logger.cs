using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Logger
    {
        //fields
        private int numberOfLines;
        private static Logger uniqueInstance;

        //construct
        private Logger()
        {
            numberOfLines = 1;
        }
        
        //get instance for singleton pattern
        public static Logger GetInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }

            return uniqueInstance;
        }

        //methods
        public void Log(string system, string action)
        {
            Console.WriteLine(numberOfLines + ". [" + system + "] " + action);

            numberOfLines++;
        }
    }
}
