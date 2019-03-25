using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class CheapMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Displaying very poor");
        }
    }

    class ExpensiveMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Displaying very beautiful");
        }
    }
}
