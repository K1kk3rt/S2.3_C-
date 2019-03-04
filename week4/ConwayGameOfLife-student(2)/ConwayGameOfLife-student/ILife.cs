using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConwayGameOfLife
{
    public interface ILife
    {
        bool IsLife(bool livingCell, int neighbourCount);
    }
}