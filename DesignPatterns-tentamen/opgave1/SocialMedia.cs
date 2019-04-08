using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave1
{
    abstract class SocialMedia
    {
        public void PostMessage(string message)
        {
            Inloggen();
            Posten(message);
            Uitloggen();
        }

        public abstract void Inloggen();
        public abstract void Posten(string message);
        public abstract void Uitloggen();
    }
}
