using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    interface IATMState
    {
        void EnterPincode(int pin);
        void InsertCard();
        void RejectCard();
        void WithdrawCash(int cash);
    }
}
