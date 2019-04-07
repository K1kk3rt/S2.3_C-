using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class Album : IVinylAlbum
    {
        private string Title;
        private string Band;
        private int Year;

        //construct
        public Album(string title, string band, int year)
        {
            Title = title;
            Band = band;
            Year = year;
        }

        //implement interface
        public void Pause()
        {
            Console.WriteLine(ToString() + "album paused");
        }

        public void Play()
        {
            Console.WriteLine("playing album " + ToString());
        }

        public void Stop()
        {
            Title = "";
            Band = "";
            Year = 0;
            Console.WriteLine("album stopped");
        }

        public override string ToString()
        {
            string s = "'" + Title + ", " + Band + " (" + Year + ")'";

            return s;
        }
    }
}
