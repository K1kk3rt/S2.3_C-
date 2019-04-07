using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3_v2
{
    interface ITreinController
    {
        void UpdateDisplay();
        void NaarVolgendStation();
        void EindstationBereikt();
    }
}
