using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    class StandardLife : ConwayGameOfLife
    {
        public StandardLife()
        {

            life.IsLife(livingCell, neighBourCount);
        }
    }

    class HighLife : ConwayGameOfLife
    {
        public HighLife()
        {
            life.IsLife(livingCell, neighBourCount);
        }
    }
}
