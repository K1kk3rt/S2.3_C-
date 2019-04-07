using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    abstract class BoekHandelItem
    {
        public string titel { get; set; }
        public float prijs { get; set; }
        public int aantal { get; set; }

        //constructor
        public BoekHandelItem(string titel, float prijs, int aantal)
        {
            this.titel = titel;
            this.prijs = prijs;
            this.aantal = aantal;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", titel, prijs, aantal);
        }
    }
}
