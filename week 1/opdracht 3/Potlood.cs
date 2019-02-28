using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    class Potlood : IPotlood
    {
        //members
        private int maxTeSchrijven { get; set; } // aantal te schrijven karakters v/e geslepen potlood
        private int geschrevenKarakters { get; set; } // aantal reeds geschreven karakters

        //constructor
        public Potlood(int maxTeSchrijven)
        {
            this.maxTeSchrijven = maxTeSchrijven;
        }

        //implement interface
        public bool IsScherp { get; }
        public void Schrijf(string boodschap) {
            char[] boodschapArray = boodschap.ToCharArray();
            int i = 0;
            while (i < boodschap.Length)
            {
                if (i < this.maxTeSchrijven)
                {
                    Console.Write(boodschapArray[i]);
                }
                else
                {
                    Console.Write("#");
                }
                i++;
            }
        }
        public void NaGeslepen() { geschrevenKarakters = 0; }

    }
}
