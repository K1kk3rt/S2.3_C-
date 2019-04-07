using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class PayPalBetaling : BetaalWijze
    {
        public override void BetalingVerwerken()
        {
            Console.WriteLine("PayPal betaling verwerken...");
        }
    }
}
