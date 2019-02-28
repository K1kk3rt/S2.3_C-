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
    public partial class Controller : Form
    {
        ITreinController treinController;
        ITreinReis treinReis;

        public Controller()
        {
            InitializeComponent();

            treinController = new TreinController();
            treinReis = new TreinReis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                treinReis.EindStationBereikt();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Maak eerst een trein!");

            }
        }

        private void btn_naarVolgendStation_Click(object sender, EventArgs e)
        {
            try
            {
                treinReis.NaarVolgendStation();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Maak eerst een trein!");

            }

        }

        private void btn_nieuweTrein_Click(object sender, EventArgs e)
        {
            //create and show display
            ITreinDisplay display = new TreinDisplay(treinReis);
            display.Show();
        }
    }
}
