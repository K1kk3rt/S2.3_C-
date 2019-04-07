using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3_v2
{
    class TreinController : ITreinController
    {
        ITreinReis treinReis;

        //construct
        public TreinController()
        { 
                treinReis = new TreinReis();
        }

        //implement interface
        public void UpdateDisplay() { treinReis.NaarVolgendStation(); }
        public void NaarVolgendStation() { treinReis.NaarVolgendStation(); }
        public void EindstationBereikt() { treinReis.EindStationBereikt(); }
    }
}
