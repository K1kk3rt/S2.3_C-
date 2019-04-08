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
            Employee ronald = new Employee("Ronald", 11290);
            Employee kevin = new Employee("Kevin", 10671);

            PrintHeader("clocking in... (with system 1)");
            RegistrationSystem system1 = RegistrationSystem.GetInstance();
            system1.ClockIn(ronald);
            system1.ClockIn(kevin);
            system1.ClockIn(ronald);

            Console.WriteLine();

            PrintHeader("clocking in... (with system 1)");
            RegistrationSystem system2 = RegistrationSystem.GetInstance();
            system2.ClockOut(kevin);
            system2.ClockOut(ronald);
            system2.ClockOut(kevin);

            Console.ReadKey();
        }

        static void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}
