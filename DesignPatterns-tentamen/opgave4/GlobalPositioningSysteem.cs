using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave4
{
    class GlobalPositioningSysteem : IGPSSysteem
    {
        private string BreedteGraad;
        private string LengteGraad;
        private Random Random;
        private List<IGPSObserver> Schermen;

        //getters
        public string getBreedteGraad() { return BreedteGraad; }
        public string getLengteGraad() { return LengteGraad; }


        //construct
        public GlobalPositioningSysteem()
        {
            Random = new Random();
            Schermen = new List<IGPSObserver>();
        }

        //implement interface
        public void UpdatePositie()
        {
            SetCoordinaten();

            foreach(IGPSObserver scherm in Schermen)
            {
                scherm.Update(BreedteGraad, LengteGraad);
            }
        }

        public void VoegSchermToe(IGPSObserver scherm)
        {
            Schermen.Add(scherm);
        }

        public void VerwijderScherm(IGPSObserver scherm)
        {
            Schermen.Remove(scherm);
        }

        //methods
        private void SetCoordinaten()
        {
            LengteGraad = "5." + Random.Next(0, 999999).ToString("D6");
            BreedteGraad = "5." + Random.Next(0, 999999).ToString("D6");
        }



    }
}
