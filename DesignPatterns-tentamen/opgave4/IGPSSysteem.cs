using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave4
{
    interface IGPSSysteem
    {
        void UpdatePositie();
        void VoegSchermToe(IGPSObserver scherm);
        void VerwijderScherm(IGPSObserver scherm);
    }
}
