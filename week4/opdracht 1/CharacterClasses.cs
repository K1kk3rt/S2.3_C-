using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Queen : Character
    {
        public Queen()
        {
            weapon = new KnifeBehaviour();
        }
    }

    class Knight : Character
    {
        public Knight()
        {
            weapon = new SwordBehaviour();
        }
    }

    class Troll : Character
    {
        public Troll()
        {
            //default weapon
            //weapon = new AxeBehaviour();
        }
    }

    class King : Character
    {
        public King()
        {
            weapon = new BowAndArrowBehaviour();
        }
    }
}
