using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave2
{
    class GameCharacter : IAttackBehaviour, IDefendBehaviour
    {
        private string Name;
        public IAttackBehaviour AttackBehaviour;
        public IDefendBehaviour DefendBehaviour;


        //implement interfaces
        public void Attack()
        {
            AttackBehaviour.Attack();
        }

        public void Defend()
        {
            DefendBehaviour.Defend();
        }
    }
}
