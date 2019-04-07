using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4
{
    class ZonneDisplay : IObserver
    {
        private IObservable Systeem;

        //construct
        public ZonneDisplay(IObservable systeem)
        {
            Systeem = systeem;

            systeem.AddObserver(this);
        }

        //implement interface
        public void Update()
        {
            Console.WriteLine("nieuwe meting: " + Systeem.getWattage() + "Watt");
        }
    }
}
