using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class Shop
    {
        public void AssembleCheapMachine(ComputerFactory factory)
        {
            IProcessor processor = factory.MakeProcessor();
            IHardDisk harddisk = factory.MakeHardDisk();
            IMonitor monitor = factory.MakeMonitor();

            processor.PerformOperation();
            harddisk.StoreData();
            monitor.Display();

        }

      
    }
}
