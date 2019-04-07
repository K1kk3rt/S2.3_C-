using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    class SimpleMP3Display : IObserver
    {

        //constructor
        public SimpleMP3Display(ISubject player)
        {
            player.AddObserver(this);
        }

        //implement interface
        public void update(Nummer nummer) { Console.WriteLine("simple: {0}, {1}", nummer.artiest, nummer.nummer); }
    }
}
