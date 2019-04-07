using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3_v2
{
    class TreinReis : ITreinReis
    {
        List<Station> stations;
        int huidigStation;
        List<ITreinDisplay> treinDisplays;
        bool terugReis = false;

        //construct
        public TreinReis()
        {
            //maak stationslijst
            stations = new List<Station>();
            MaakStationsLijst();

            //maak observerlist
            treinDisplays = new List<ITreinDisplay>();
        }

        //implement interface
        public void Add(ITreinDisplay display) { treinDisplays.Add(display); display.UpdateDisplayInfo(stations[huidigStation]); }
        public void Remove() { }
        public void Notify()
        {
            foreach (ITreinDisplay display in treinDisplays)
            {
                if(huidigStation < stations.Count())
                {
                    if (huidigStation >= 0)
                    {
                        display.UpdateDisplayInfo(stations[huidigStation]);
                    }
                    else
                    {
                        Station eindStation = new Station("EIND STATION", "", "", "");
                        display.UpdateDisplayInfo(eindStation);
                    }
                }
                else
                {
                    Station eindStation = new Station("EIND STATION", "", "", "");
                    display.UpdateDisplayInfo(eindStation);
                }
                
            }
        }
        public void NaarVolgendStation()
        {
            if (terugReis)
            {
                huidigStation--;
            }
            else
            {
                huidigStation++;
            }

            Notify();
        }
        public void EindStationBereikt()
        {
            if (!terugReis)
            {
                huidigStation--; terugReis = true;
            }
            else{
                huidigStation++; terugReis = false;
            }

            Notify();
        }

        private void MaakStationsLijst()
        {
            Station station1 = new Station("Station 1", "1", "11:00", "11:02");
            Station station2 = new Station("Station 2", "2", "12:00", "12:02");
            Station station3 = new Station("Station 3", "3", "13:00", "13:02");

            stations.Add(station1);
            stations.Add(station2);
            stations.Add(station3);
        }
    }
}
