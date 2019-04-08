using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave1
{
    abstract class SocialMedia
    {
        private string Username;
        private string Password;

        //construct
        public SocialMedia(string username, string password)
        {
            Username = username;
            Password = password;
        }

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
