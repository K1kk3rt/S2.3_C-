using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3_v2
{
    public class Station
    {
        public string naam;
        public string aankomstSpoor;
        public string aankomstTijd;
        public string vertrekTijd;

        //construct
        public Station(string naam="", string aankomstSpoor="", string aankomstTijd="", string vertrekTijd="")
        {
            this.naam = naam;
            this.aankomstSpoor = aankomstSpoor;
            this.aankomstTijd = aankomstTijd;
            this.vertrekTijd = vertrekTijd;
        }

        //public Station() { }
    }
}
