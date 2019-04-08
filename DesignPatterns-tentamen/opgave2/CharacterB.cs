using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave2
{
    class CharacterB : GameCharacter
    {
        private string Name;

        //construct
        public CharacterB(string name)
        {
            Name = name;

            AttackBehaviour = new NormalAttack();
            DefendBehaviour = new SilverShield();
        }
    }
}
