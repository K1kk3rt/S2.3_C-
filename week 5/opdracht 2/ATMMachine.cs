using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class ATMMachine
    {
        //fields
        //possible states
        private IATMState noCard;
        private IATMState cardPresent;
        private IATMState correctPinCode;
        private IATMState noCash;

        private IATMState currentState;

        //properties
        private int amountInMachine;

        //getters
        public IATMState GetNoCardStatus()
        {
            return noCard;
        }
        public IATMState GetCardPresentStatus()
        {
            return cardPresent;
        }
        public IATMState GetCorrectPinStatus()
        {
            return correctPinCode;
        }
        public IATMState GetNoCashStatus()
        {
            return noCash;
        }
        public int GetAmountInMachine()
        {
            return amountInMachine;
        }

        //setters
        public void SetMachineStatus(IATMState status)
        {
            currentState = status;
        }
        public void SetAmountInMachine(int amount)
        {
            amountInMachine = amount;
        }

        //construct
        public ATMMachine(int amountInMachine)
        {
            noCard = new NoCardState(this);
            cardPresent = new CardPresentState(this);
            correctPinCode = new CorrectPinState(this);
            noCash = new NoCashState(this);

            this.amountInMachine = amountInMachine;

            if (this.amountInMachine > 0)
            {
                currentState = noCard;
            }
            else
            {
                currentState = noCash;
            }
        }

        //methods
        public void enterPincode(int pin)
        {
            currentState.EnterPincode(pin);
        }

        public void insertCard()
        {
            currentState.InsertCard();
        }

        public void rejectCard()
        {
            currentState.RejectCard();
        }

        public void withdrawCash(int cash)
        {
            currentState.WithdrawCash(cash);
        }
    }
}
