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
            BigDataLoader sensor = new SensorDataLoader();
            sensor.batchProcessor();

            BigDataLoader twitter = new TwitterDataLoader();
            twitter.batchProcessor();

            BigDataLoader call = new CallDataLoader();
            call.batchProcessor();

            Console.ReadKey();
        }
    }
}
