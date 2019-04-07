using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class PINBetaling : BetaalWijze
    {
        public override void BetalingVerwerken()
        {
            Console.WriteLine("PIN betaling verwerken...");
        }
    }
}
