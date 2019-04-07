using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class CallDataLoader : BigDataLoader
    {
        public override void extract()
        {
            Console.WriteLine("Extracting call data...");
        }

        public override void transform()
        {
            Console.WriteLine("Transforming call data...");
        }

        public override void load()
        {
            Console.WriteLine("Loading call data...");
        }
    }
}
