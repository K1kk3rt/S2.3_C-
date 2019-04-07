using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    abstract class BigDataLoader { 
    
        //recepe
        public void batchProcessor()
        {
            //start ETL process
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ETL process started");
            Console.ResetColor();

            //load data
            extract();
            transform();
            load();

            //end ETL process
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ETL process finished");
            Console.ResetColor();

            //new line
            Console.WriteLine();
        }

        //abstract methods
        public abstract void extract();
        public abstract void transform();
        public abstract void load();
    }
}
