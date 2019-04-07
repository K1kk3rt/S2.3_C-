using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class CardPresentState : IATMState
    {
        //fields
        private ATMMachine machine;

        //construct
        public CardPresentState(ATMMachine machine)
        {
            this.machine = machine;
        }

        //implement interface
        public void EnterPincode(int pin)
        {
            if (pin == 1234)
            {
                Console.WriteLine("You have entered the correct pincode");
                machine.SetMachineStatus(machine.GetCorrectPinStatus());
            }
            else
            {
                Console.WriteLine("Pin incorrect, please enter your pincode again");
            }
            
        }

        public void InsertCard()
        {

        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            machine.SetMachineStatus(machine.GetNoCardStatus());
        }

        public void WithdrawCash(int cash)
        {

        }
    }
}
