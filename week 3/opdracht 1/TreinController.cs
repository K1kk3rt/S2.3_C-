using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class TreinController : ITreinController
    {
        public Treinreis treinreis;
        public List<TreinTemplate> observerList;

        //constructor
        public TreinController(Treinreis treinreis)
        {
            this.treinreis = treinreis;

            observerList = new List<TreinTemplate>();
        }

        //implement interface
        public void StationBereikt() { }
        public void NaarVolgendStation() { treinreis.naarVolgendStation(); }
    }
}
