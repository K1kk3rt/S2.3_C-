using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    public class Station
    {
        public string Naam { get; set; }
        public string AankomstSpoor { get; set; }
        public DateTime AankomstTijd { get; set; }
        public DateTime VertrekTijd { get; set; }

        //constructor
        public Station(string naam, string aankomstSpoor, DateTime aankomstTijd, DateTime vertrekTijd)
        {
            Naam = naam;
            AankomstSpoor = aankomstSpoor;
            AankomstTijd = aankomstTijd;
            VertrekTijd = vertrekTijd;
        }
    }
}
