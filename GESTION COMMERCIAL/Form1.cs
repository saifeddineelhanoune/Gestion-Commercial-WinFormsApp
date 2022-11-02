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
    public partial class frmSaisieClient : Form
    {
        public frmSaisieClient()
        {
            InitializeComponent();
        }

        private void lblNumcl_Click(object sender, EventArgs e)
        {

        }

        private void txtadressecl_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            if (txtnumerocl.Text == "" || txtnomcl.Text == "" || txttelephonecl.Text == "" || txtadressecl.Text == "" || txtemailcl.Text == "" || txtPayscl.Text == "" || txtRegioncl.Text == "")
            {
                MessageBox.Show("REMPLISSEZ-VOUS TOUS LES CHAMPS");
            }
            else
            {
                try
                {
                    this.dgvClient.Rows.Add(int.Parse(txtnumerocl.Text), txtnomcl.Text, int.Parse(txttelephonecl.Text), txtadressecl.Text, txtemailcl.Text, txtPayscl.Text, txtRegioncl.Text);
                    txtnumerocl.Text = "";
                    txtnomcl.Text = "";
                    txttelephonecl.Text = "";
                    txtadressecl.Text = "";
                    txtemailcl.Text = "";
                    txtPayscl.Text = "";
                    txtRegioncl.Text = "";
                }
                catch(FormatException)
                {
                    MessageBox.Show("Téléphone ou Numéro est invalide");
                }
            }
                
        }
    }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            int index = this.dgvClient.CurrentRow.Index;
            this.dgvClient.Rows.RemoveAt(index);
        }
    }
