using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    class KopieerMachine
    {
        private static KopieerMachine uniqueInstance;
        private int aantalKopies;

        //construct
        private KopieerMachine()
        {
            aantalKopies = 0;
        }

        //methods
        public static KopieerMachine getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new KopieerMachine();
            }

            return uniqueInstance;
        }

        public void Kopieer(int aantal)
        {
            aantalKopies = aantalKopies + aantal;

            Console.WriteLine("aan het kopieren, " + aantal + "x");
            Console.WriteLine("totaal kopies: " + aantalKopies);
        }
    }
}
