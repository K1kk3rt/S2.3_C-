using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class CD : BoekHandelItem
    {
        public string artiest { get; set; }

        public CD(string titel, float prijs, int aantal, string artiest) : base(titel, prijs, aantal)
        {
            this.artiest = artiest;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", titel, prijs, aantal, artiest);
        }
    }
}
