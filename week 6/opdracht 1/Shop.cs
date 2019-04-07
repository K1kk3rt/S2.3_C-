using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Shop
    {
        public void AssembleMachine()
        {
            IProcessor processor = MakeProcessor();
            IHardDisk harddisk = MakeHardDisk();
            IMonitor monitor = MakeMonitor();

            processor.PerformOperation();
            harddisk.StoreData();
            monitor.Display();

        }

        public virtual IProcessor MakeProcessor() { return new CheapProcessor(); }
        public virtual IHardDisk MakeHardDisk() { return new CheapHarddisk(); }
        public virtual IMonitor MakeMonitor() { return new CheapMonitor(); }
    }
}
