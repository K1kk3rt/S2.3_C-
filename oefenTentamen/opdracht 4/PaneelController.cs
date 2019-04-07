using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4
{
    class PaneelController : IPaneelController
    {
        IObservable ZonnePaneel;

        //construct
        public PaneelController(IObservable zonnePaneel)
        {
            ZonnePaneel = zonnePaneel;
        }

        public void NieuweMeting()
        {
            ZonnePaneel.NieuweMeting();

        }
    }
}
