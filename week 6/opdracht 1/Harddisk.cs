using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class CheapHarddisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Store data very slow");
        }
    }

    class ExpensiveHarddisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Store data very fast");
        }
    }
}
