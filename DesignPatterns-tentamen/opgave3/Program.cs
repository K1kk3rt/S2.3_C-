using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave3
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintHeader("clocking in... (with system 1)");
            
        }

        static void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}
