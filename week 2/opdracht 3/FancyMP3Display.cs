using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    class FancyMP3Display : IObserver
    {

        //constructor
        public FancyMP3Display(ISubject player)
        {
            player.AddObserver(this);
        }

        //implement interface
        public void update(Nummer nummer) { Console.WriteLine("fancy: {0}, {1}", nummer.artiest, nummer.nummer); }
    }
}
