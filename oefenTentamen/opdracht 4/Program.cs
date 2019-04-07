using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // maak een zonnepaneel systeem aan
            IObservable systeem = new ZonnePaneelSysteem();

            // maak een controller  aan
            IPaneelController controller = new PaneelController(systeem);

            // maak een display voor het systeem aan
            IObserver display = new ZonneDisplay(systeem);

            // doe een aantal metingen
            for (int i = 0; i < 10; i++)
            {
                controller.NieuweMeting();
            }
            
            Console.ReadKey();
        }
    }
}
