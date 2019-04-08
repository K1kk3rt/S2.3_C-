using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            // create GPS system            
            IGPSSysteem gps = new GlobalPositioningSysteem();

            // create controller            
            IGPSController controller = new GPSController(gps);

            // create displays            
            IGPSObserver positieScherm = new PositieScherm(gps);
            IGPSObserver standaardScherm = new StandaardScherm(gps);

            // update GPS system (using a timer)            
            Timer timer = new Timer(new TimerCallback(Timer_Elapsed), controller, 0, 5000);

            Console.ReadKey();
        }

        private static void Timer_Elapsed(object state)
        {            
            // update GPS system            
            IGPSController ctrl = (IGPSController)state;
            ctrl.UpdatePositie();
            Console.WriteLine();
        }
    }
}
