using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    class MP3Player : ISubject
    {
        public Nummer HuidigNummer { get; private set; }
        public List<Nummer> nummers = new List<Nummer>();
        private List<IObserver> observers = new List<IObserver>();

        //constructor
        public MP3Player()
        {
            fillNummers();
        }

        //implement interfaces
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach(IObserver observer in this.observers)
            {
                observer.update(HuidigNummer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NummerGewijzigd()
        {
            // selecteert (random) een volgend nummer en informeert alle aangemelde observers van de wijziging. 

            //select random nummer
            Random random = new Random();
            int index = random.Next(nummers.Count);

            HuidigNummer = nummers[index];

            NotifyObservers();

        }

        private void fillNummers()
        {
            Nummer num1 = new Nummer("artiest 1", "nummer 1");
            Nummer num2 = new Nummer("artiest 2", "nummer 2");
            Nummer num3 = new Nummer("artiest 3", "nummer 3");
            Nummer num4 = new Nummer("artiest 4", "nummer 4");
            Nummer num5 = new Nummer("artiest 5", "nummer 5");
            Nummer num6 = new Nummer("artiest 6", "nummer 6");

            this.nummers.Add(num1);
            this.nummers.Add(num2);
            this.nummers.Add(num3);
            this.nummers.Add(num4);
            this.nummers.Add(num5);
            this.nummers.Add(num6);
        }
    }
}
