using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave3
{
    class Employee
    {
        private string Name;
        private int Number;

        //getters
        public string getName() { return Name; }
        public int getNumber() { return Number; }

        //construct
        public Employee(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            string s = "Employee " + Name + " (" + Number + ") ";

            return s;
        }
    }
}