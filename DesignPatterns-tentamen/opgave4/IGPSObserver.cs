using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave4
{
    interface IGPSObserver
    {
        void Update(string breedtegraad, string lengtegraad);
    }
}
