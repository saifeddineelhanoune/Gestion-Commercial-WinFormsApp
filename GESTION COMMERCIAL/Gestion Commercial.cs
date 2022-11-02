using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_COMMERCIAL
{
    public partial class Gestion_Commercial : Form
    {
        public Gestion_Commercial()
        {
            InitializeComponent();
        }

        private void saisieDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaisieClient f = new frmSaisieClient();
            f.Show();
        }

        private void rechercheDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRechercheClients f = new frmRechercheClients();
            f.Show();
        }

        private void saisieUnFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaisie_Fournisseur f = new frmSaisie_Fournisseur();
            f.Show();
        }

        private void rechercheUnFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRechercheFournisseur f = new  frmRechercheFournisseur();
            f.Show();
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
