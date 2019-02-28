using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3_v2
{
    public interface ITreinReis
    {
        void Add(ITreinDisplay display);
        void Remove();
        void Notify();
        void NaarVolgendStation();
        void EindStationBereikt();
    }
}
