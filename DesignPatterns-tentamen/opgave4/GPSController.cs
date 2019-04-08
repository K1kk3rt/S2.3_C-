using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave4
{
    class GPSController : IGPSController
    {
        private IGPSSysteem Gps;

        //construct
        public GPSController(IGPSSysteem gps)
        {
            Gps = gps;
        }

        public void UpdatePositie()
        {
            Gps.UpdatePositie();
        }
    }
}
