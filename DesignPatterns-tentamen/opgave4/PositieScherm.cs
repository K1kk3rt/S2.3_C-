using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave4
{
    class PositieScherm : IGPSObserver
    {
        private IGPSSysteem GPSSysteem;

        //construct
        public PositieScherm(IGPSSysteem GPSSysteem)
        {
            this.GPSSysteem = GPSSysteem;

            GPSSysteem.VoegSchermToe(this);
        }

        //implement interface
        public void Update(string breedtegraad, string lengtegraad)
        {
            Console.WriteLine("[positie-scherm] lengtegraad: " + breedtegraad + ", breedtegraad: " + lengtegraad);
        }
    }
}
