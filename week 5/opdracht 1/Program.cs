using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.GetInstance();

            logger.Log("main", "starting");

            MainSystem mainSystem = new MainSystem();

            logger.Log("main", "finishing");

            Console.ReadKey();
        }
    }
}
