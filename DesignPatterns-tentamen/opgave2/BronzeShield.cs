using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave2
{
    class BronzeShield : IDefendBehaviour
    {
        public void Defend()
        {
            Console.WriteLine("using bronze shield to defend...");
        }
    }
}
