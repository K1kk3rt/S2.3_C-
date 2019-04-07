using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class NoCardState : IATMState
    {
        //fields
        private ATMMachine machine;

        //construct
        public NoCardState(ATMMachine machine)
        {
            this.machine = machine;
        }

        //implement interface
        public void EnterPincode(int pin)
        {

        }

        public void InsertCard()
        {
            Console.WriteLine("Please enter your pincode");
            machine.SetMachineStatus(machine.GetCardPresentStatus());
        }

        public void RejectCard()
        {

        }

        public void WithdrawCash(int cash)
        {

        }
    }
}
