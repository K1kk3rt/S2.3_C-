using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class Superman : IVliegbaar
    {
        //implement interface
        public void Opstijgen() { Console.WriteLine("superman aan het opstijgen..."); }
        public void Vliegen() { Console.WriteLine("superman aan het vliegen"); }
        public void Landen() { Console.WriteLine("superman aan het landen"); }
    }
}
