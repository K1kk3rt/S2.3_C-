using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave2
{
    class NormalAttack : IAttackBehaviour
    {
        public void Attack()
        {
            Console.WriteLine("normal attack...");
        }
    }
}
