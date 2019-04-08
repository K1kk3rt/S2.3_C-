using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave2
{
    class GoldenShield : IDefendBehaviour
    {
        public void Defend()
        {
            Console.WriteLine("using golden shield to defend...");
        }
    }
}
