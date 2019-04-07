using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class JukeBox
    {
        public List<IVinylSingle> Singles;
        private IVinylSingle currentSingle;

        //construct
        public JukeBox(List<IVinylSingle> singles)
        {
            Singles = singles;
        }

        //methods
        public void Afspelen()
        {
            currentSingle.Play();
        }

        public void SelectSingle(int i)
        {
            currentSingle = Singles[i];
        }

        public void Stoppen()
        {
            currentSingle.Stop();
        }

        public void AddAlbum(IVinylSingle album)
        {
            Singles.Add(album);
        }


        
    }
}
