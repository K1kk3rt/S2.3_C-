using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave2
{
    class CharacterA : GameCharacter
    {
        private string Name;
        //construct
        public CharacterA(string name)
        {
            Name = name;

            AttackBehaviour = new WeakAttack();
            DefendBehaviour = new BronzeShield();
        }
    }
}
