using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class Vliegtuig : IVliegbaar
    {
        //implement interface
        public void Opstijgen() { Console.WriteLine("vliegtuig aan het opstijgen..."); }
        public void Vliegen() { Console.WriteLine("vliegtuig aan het vliegen"); }
        public void Landen() { Console.WriteLine("vliegtuig aan het landen"); }
    }
}
