using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class CreditCardBetaling : BetaalWijze
    {
        public override void BetalingVerwerken()
        {
            Console.WriteLine("CreditCard betaling verwerken...");
        }
    }
}
