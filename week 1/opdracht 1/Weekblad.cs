using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Weekblad : BoekHandelItem
    {
        public string uitgifteDag { get; set; }

        public Weekblad(string titel, float prijs, int aantal, string uitgifteDag) : base(titel, prijs, aantal)
        {
            this.uitgifteDag = uitgifteDag;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", titel, prijs, aantal, uitgifteDag);
        }
    }
}
