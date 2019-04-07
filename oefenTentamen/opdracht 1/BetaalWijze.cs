using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    abstract class BetaalWijze
    {
        //template methode, wordt vanuit de main gecallt
        public void Uitvoeren()
        {
            GegevensInvoeren();
            BetalingVerwerken();
            StuurBevestigingsMail();
        }

        //concrete methodes
        public void GegevensInvoeren()
        {
            Console.WriteLine("Invoeren van gegevens...");
        }

        public void StuurBevestigingsMail()
        {
            Console.WriteLine("Bevestigingsmail versturen...");
        }

        //abstracte methodes
        public abstract void BetalingVerwerken();
    }
}
