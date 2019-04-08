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

        private void setEmployee(Employee employee) { Employees.Add(employee.getNumber(), employee); }
        private void RemoveEmployee(Employee employee) { Employees.Remove(employee.getNumber()); }

        //construct
        private RegistrationSystem()
        {
            NrOfClockedInEployees = 0;
            Employees = new Dictionary<int, Employee>();
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
            if (Employees.ContainsKey(employee.getNumber()))
            {
                Console.WriteLine(Employees[employee.getNumber()].ToString() + "already clocked in.");
            }
            else
            {
                NrOfClockedInEployees++;
                setEmployee(employee);
                Console.WriteLine(Employees[employee.getNumber()].ToString() + "clocked in.");
            }
            
        }

        public void ClockOut(Employee employee)
        {
            if (Employees.ContainsKey(employee.getNumber()))
            {
                Console.WriteLine(Employees[employee.getNumber()].ToString() + "clocked out.");
                NrOfClockedInEployees--;
                RemoveEmployee(employee);
            }
            else
            {
                Console.WriteLine(employee.ToString() + "not clocked in!");
            }
        }
    }
}
