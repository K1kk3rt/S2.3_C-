using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declareer Boekhandelitems
            BoekHandelItem boek1 = new Boek("Boek 1", 14, 100, "auteur 1");
            BoekHandelItem boek2 = new Boek("Boek 2", 12, 90, "auteur 2");
            BoekHandelItem weekblad1 = new Weekblad("Weekblad 1", 10, 50, "Uitgiftedag 1");
            BoekHandelItem weekblad2 = new Weekblad("Weekblad 2", 12, 40, "Uitgiftedag 2");
            BoekHandelItem CD1 = new CD("CD1", 5, 10, "artiest 1");
            BoekHandelItem CD2 = new CD("CD2", 6, 20, "artiest 2");

            //voeg toe aan boekhandel
            Boekhandel boekhandel = new Boekhandel();
            boekhandel.VoegToe(boek1);
            boekhandel.VoegToe(boek2);
            boekhandel.VoegToe(weekblad1);
            boekhandel.VoegToe(weekblad2);
            boekhandel.VoegToe(CD1);
            boekhandel.VoegToe(CD2);

            //print boekhandel
            boekhandel.PrintOverzicht();

            Console.ReadKey();
        }
    }
}
