using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class ComputerFactory
    {
        public virtual IProcessor MakeProcessor() { return new CheapProcessor(); }
        public virtual IHardDisk MakeHardDisk() { return new CheapHarddisk(); }
        public virtual IMonitor MakeMonitor() { return new ExpensiveMonitor(); }
    }


}
