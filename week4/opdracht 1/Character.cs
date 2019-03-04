using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    abstract class Character
    {
        public IWeaponBehaviour weapon;



        public Character()
        {
            //default weapon
            weapon = new AxeBehaviour();
        }

        public void Fight()
        {
            weapon.UseWeapon();
        }
    }
}
