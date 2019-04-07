using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_4
{
    class ZonnePaneelSysteem : IObservable
    {
        private List<IObserver> Observers;
        private int Wattage;
        private Random Random;

        //getters
        public int getWattage()
        {
            return Wattage;
        }

        //construct
        public ZonnePaneelSysteem()
        {
            Random = new Random();

            Observers = new List<IObserver>();
        }

        //implement interface
        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void NieuweMeting()
        {
            Wattage = Random.Next(300, 400);

            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach(IObserver item in Observers)
            {
                item.Update();
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
