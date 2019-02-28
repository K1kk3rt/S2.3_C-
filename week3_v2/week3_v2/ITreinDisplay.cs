using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3_v2
{
    public interface ITreinDisplay
    {
        void UpdateDisplayInfo(Station station);
        void NaarVolgendStation();
        void EinStationBereikt();

        void Show();
    }
}
