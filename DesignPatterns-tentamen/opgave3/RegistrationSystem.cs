using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave3
{
    class RegistrationSystem
    {
        private int NrOfClockedInEployees;
        private static RegistrationSystem UniqueInstance;
        private Dictionary<int, Employee> Employees;

        //construct
        private RegistrationSystem()
        {
            NrOfClockedInEployees = 0;
        }

        //methods
        public static RegistrationSystem GetInstance()
        {
            if(UniqueInstance == null)
            {
                UniqueInstance = new RegistrationSystem();
            }

            return UniqueInstance;
        }

        public void ClockIn(Employee employee)
        {

        }

        public void ClockOut(Employee employee)
        {

        }
    }
}
