using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave2
{
    class SilverShield : IDefendBehaviour
    {
        public void Defend()
        {
            Console.WriteLine("using silver shield to defend...");
        }
    }
}
