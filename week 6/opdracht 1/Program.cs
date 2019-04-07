using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            Shop expensiveShop = new ExpensiveShop();
            expensiveShop.AssembleMachine();

            Console.WriteLine();
            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            Shop cheapShop = new Shop();
            cheapShop.AssembleMachine();
            Console.ReadKey();
        }
    }
}
