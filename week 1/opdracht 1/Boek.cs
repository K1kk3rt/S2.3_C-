using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Boek : BoekHandelItem
    {
        public string auteur { get; set; }

        public Boek(string titel, float prijs, int aantal, string auteur) : base (titel, prijs, aantal)
        {
            this.auteur = auteur;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", titel, prijs, aantal, auteur);
        }

    }
}
