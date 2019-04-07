using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class AxeBehaviour : IWeaponBehaviour
    {
        //implement interface
        public void UseWeapon()
        {
            Console.WriteLine("Chopping with an axe");
        }
    }

    class BowAndArrowBehaviour : IWeaponBehaviour
    {
        //implement interface
        public void UseWeapon()
        {
            Console.WriteLine("Shooting an arrow with a bow");
        }
    }

    class KnifeBehaviour : IWeaponBehaviour
    {
        //implement interface
        public void UseWeapon()
        {
            Console.WriteLine("Cutting with a knife");
        }
    }

    class SwordBehaviour : IWeaponBehaviour
    {
        //implement interface
        public void UseWeapon()
        {
            Console.WriteLine("Swinging a sword");
        }
    }
}
