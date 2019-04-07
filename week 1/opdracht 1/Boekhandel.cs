using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Boekhandel
    {
        List<BoekHandelItem> list { get; set; }

        //constructor
        public Boekhandel()
        {
            // maak eeen nieuwe lijst
            this.list = new List<BoekHandelItem>();
        }

        public void VoegToe(BoekHandelItem item)
        {
            //voeg item toe aan list
            this.list.Add(item);
        }

        public void PrintOverzicht()
        {
            //print all items
            foreach(BoekHandelItem item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
