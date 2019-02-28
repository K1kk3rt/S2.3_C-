using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class TwitterDataLoader : BigDataLoader
    {
        public override void extract()
        {
            Console.WriteLine("Extracting Twitter data...");
        }

        public override void transform()
        {
            Console.WriteLine("Transforming Twitter data...");
        }

        public override void load()
        {
            Console.WriteLine("Loading Twitter data...");
        }
    }
}
