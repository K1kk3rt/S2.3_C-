using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Treinreis : ITreinreis
    {
        List<Station> stations { get; set; }
        int huidigStation { get; set; }
        public List<TreinTemplate> observerList;
        public TreinTemplate treinTemplate;

        //constructor
        public Treinreis(TreinTemplate treinTemplate)
        {
            this.treinTemplate = treinTemplate;

            stations = new List<Station>();
            fillList();

            huidigStation = 0;

            observerList = new List<TreinTemplate>();
            this.AddObserver();
            this.NotifyObserver();
        }

        //implement interfaces
        public void AddObserver() { observerList.Add(treinTemplate); }
        public void NotifyObserver()
        {
            foreach(TreinTemplate template in observerList)
            {
                template.Update(stations[huidigStation]);
            }
        }
        public void RemoveObserver() { observerList.Remove(treinTemplate); }

        public void naarVolgendStation()
        {
            huidigStation++;
            Station station = stations[huidigStation];

            foreach (ITreinreis treinreis in observerList)
            {
                treinreis.NotifyObserver();
            }
        }

        //methods
        private void fillList()
        {
            DateTime date1 = new DateTime(2019, 1, 1);
            DateTime date2 = new DateTime(2019, 1, 2);
            Station station1 = new Station("Station 1", "1", date1, date2);

            DateTime date3 = new DateTime(2019, 2, 1);
            DateTime date4 = new DateTime(2019, 2, 2);
            Station station2 = new Station("Station 2", "2", date3, date4);

            DateTime date5 = new DateTime(2019, 2, 1);
            DateTime date6 = new DateTime(2019, 2, 2);
            Station station3 = new Station("Station 2", "2", date4, date6);

            stations.Add(station1);
            stations.Add(station2);
            stations.Add(station3);
        }
    }
}
