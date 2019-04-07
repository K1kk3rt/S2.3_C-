using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    class Robot : IRobot
    {
        //methods
        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }

        public void MoveByPerson()
        {
            Console.WriteLine("Robot is moved by Mark");
        }

        public void WalkForward()
        {
            Console.WriteLine("Robot walks 3 steps forward");
        }
    }
}
