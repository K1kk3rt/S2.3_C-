using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class SensorDataLoader : BigDataLoader
    {
        public override void extract()
        {
            Console.WriteLine("Extracting sensor data...");
        }

        public override void transform()
        {
            Console.WriteLine("Transforming sensor data...");
        }

        public override void load()
        {
            Console.WriteLine("Loading sensor data...");
        }
    }
}
