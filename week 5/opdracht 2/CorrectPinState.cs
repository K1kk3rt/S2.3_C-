using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class CorrectPinState : IATMState
    {
        //fields
        private ATMMachine machine;

        //construct
        public CorrectPinState(ATMMachine machine)
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
            if(cash < machine.GetAmountInMachine())
            {
                machine.SetAmountInMachine(machine.GetAmountInMachine() - cash);
                Console.WriteLine(cash + " Withdrawn from machine");
                Console.WriteLine("Your card has been rejected");
                machine.SetMachineStatus(machine.GetNoCardStatus());
            }
            else
            {
                machine.SetMachineStatus(machine.GetNoCashStatus());
                machine.withdrawCash(cash);
            }
            
        }
    }
}
