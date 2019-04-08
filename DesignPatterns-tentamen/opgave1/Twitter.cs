using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave1
{
    class Twitter : SocialMedia 
    {
        private string Username;
        private string Password;

        //construct
        public Twitter(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public override void Inloggen()
        {
            Console.WriteLine("logging in (" + Username + ") on Twitter...");
        }

        public override void Posten(string message)
        {
            Console.WriteLine("posting message '" + message + "' on Twitter...");
        }

        public override void Uitloggen()
        {
            Console.WriteLine("logging out from Twitter...");
        }
    }
}
