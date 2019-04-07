using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class CheapShop : ComputerFactory
    {
        public override IProcessor MakeProcessor() { return new CheapProcessor(); }
        public override IHardDisk MakeHardDisk() { return new CheapHarddisk(); }
        public override IMonitor MakeMonitor() { return new CheapMonitor(); }
    }
}
