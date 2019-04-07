using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class NoCashState : IATMState
    {
        //fields
        private ATMMachine machine;

        //construct
        public NoCashState(ATMMachine machine)
        {
            this.machine = machine;
        }

        //implement interface
        public void EnterPincode(int pin)
        {
            
        }

        public void InsertCard()
        {
            
        }

        public void RejectCard()
        {
            
        }

        public void WithdrawCash(int cash)
        {
            Console.WriteLine("Not enough cash in machine");
            Console.WriteLine("Your card has been rejected");
            machine.SetMachineStatus(machine.GetNoCardStatus());
        }
    }
}
