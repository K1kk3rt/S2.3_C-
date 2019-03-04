using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConwayGameOfLife
{
    public class HighLifeBehaviour : ILife
    {
        public bool IsLife(bool livingCell, int neighbourCount)
        {
            // with 3 or 6 neighbour cell will live
            if (neighbourCount == 3 || neighbourCount == 6)
                return true;

            // live cell with 2  or 3 neighbours stays alive
            if (livingCell && (neighbourCount == 2 || neighbourCount == 3))
                return true;

            // dead cell
            return false;
        }
    }

    public class StandardLifeBehaviour : ILife
    {
        public bool IsLife(bool livingCell, int neighbourCount)
        {
            // with 3 neighbour cell will live
            if (neighbourCount == 3)
                return true;

            // live cell with 2 neighbours stays alive
            if (livingCell && neighbourCount == 2)
                return true;

            // dead cell
            return false;
        }
    }
}