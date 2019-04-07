using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class AlbumAdapter : IVinylSingle
    {
        private IVinylAlbum Album;

        //construct
        public AlbumAdapter(IVinylAlbum album)
        {
            Album = album;
        }

        //implement interface
        public void Pause()
        {
            Album.Pause();
        }

        public void Play()
        {
            Album.Play();
        }

        public void Stop()
        {
            Album.Stop();
        }


    }
}
