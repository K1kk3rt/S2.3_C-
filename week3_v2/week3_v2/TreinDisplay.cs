using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3_v2
{
    public partial class TreinDisplay : Form, ITreinDisplay
    {
        ITreinReis treinReis;

       //construct
        public TreinDisplay(ITreinReis treinReis)
        {
            InitializeComponent();

            this.treinReis = treinReis;
            treinReis.Add(this);
        }

        //implement interface
        public void UpdateDisplayInfo(Station station)
        {
            lbl_huidigStationText.Text = station.naam;
            lbl_aankomstTijdText.Text = station.aankomstTijd.ToString();
            lbl_spoorText.Text = station.aankomstSpoor;
        }

        public void NaarVolgendStation() { treinReis.NaarVolgendStation(); }
        public void EinStationBereikt() { treinReis.EindStationBereikt(); }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
