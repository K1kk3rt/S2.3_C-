using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
                // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            ComputerFactory expensiveFactory = new ExpensiveShop();
            Shop expensiveShop = new Shop();
            expensiveShop.AssembleCheapMachine(expensiveFactory);

            Console.WriteLine();

            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            ComputerFactory cheapFactory = new CheapShop();
            Shop cheapShop = new Shop();
            cheapShop.AssembleCheapMachine(cheapFactory);
            Console.ReadKey();
        }
    }
}
