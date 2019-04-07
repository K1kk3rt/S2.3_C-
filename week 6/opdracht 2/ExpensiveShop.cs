using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class ExpensiveShop : ComputerFactory
    {
        public override IHardDisk MakeHardDisk(){ return new ExpensiveHarddisk(); }
        public override IProcessor MakeProcessor() { return new ExpensiveProcessor(); }
        public override IMonitor MakeMonitor() { return new ExpensiveMonitor(); }
    }
}
