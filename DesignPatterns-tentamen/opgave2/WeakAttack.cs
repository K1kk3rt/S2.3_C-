using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave2
{
    class WeakAttack : IAttackBehaviour
    {
        public void Attack()
        {
            Console.WriteLine("weak attack...");
        }
    }
}
