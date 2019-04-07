using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class Single : IVinylSingle
    {
        private string Artist;
        private int Ranking;
        private string Title;

        //construct
        public Single(int ranking, string title, string artist)
        {
            Ranking = ranking;
            Title = title;
            Artist = artist;
        }

        //implement interface
        public void Pause()
        {
            Console.WriteLine(ToString() + " single paused");
        }

        public void Play()
        {
            Console.WriteLine("playing single " + ToString());
        }

        public void Stop()
        {
            Artist = "";
            Ranking = 0;
            Title = "";
            Console.WriteLine("single stopped");
        }

        public override string ToString()
        {
            string s = "'" + Title + ", " + Artist + " (" + Ranking + ")'";

            return s;
        }
    }
}
