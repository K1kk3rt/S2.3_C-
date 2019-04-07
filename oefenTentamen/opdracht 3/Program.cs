using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kopieren met 'machine 1'");
            KopieerMachine machine1 = KopieerMachine.getInstance();
            machine1.Kopieer(10);
            machine1.Kopieer(23);

            Console.WriteLine();

            Console.WriteLine("kopieren met 'machine 2'");
            KopieerMachine machine2 = KopieerMachine.getInstance();
            machine2.Kopieer(40);

            Console.ReadKey();
        }
    }
}
