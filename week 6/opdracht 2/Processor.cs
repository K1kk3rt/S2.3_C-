using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class CheapProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Perform operation very slow");
        }
    }

    class ExpensiveProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Perform operation very fast");
        }
    }
}
