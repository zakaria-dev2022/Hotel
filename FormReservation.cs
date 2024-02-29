using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Hotel
{
    public partial class FormReservation : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string chemin = "";
        public FormReservation()
        {
            InitializeComponent();
        }
        
        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("SELECT r.id as N°reservation,r.nombre_jour,r.date_reservation,r.message ,c.id as N°Client,c.nom,c.prenom,c.email,ch.id as N°Chambre , ch.type,ch.prix FROM reservation r JOIN client c ON r.client_id=c.id JOIN chambre ch on r.chambre_id=ch.id ");
            //DataTable dataTable = Utils.ObtenirDonnees("select * from produit");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }


        private void FormReservation_Load(object sender, EventArgs e)
        {
            remplir();
        }

        /* public int TransferTypeInt()
         {
             Utils.CloseConnection();
            DataTable dataTable = Utils.ObtenirDonnees("select id from type_produits where type = '" + txttp.Text + "'");

            if (dataTable.Rows.Count > 0)
            {
                // Si des données ont été retournées par la requête
                int id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                //Console.WriteLine("ID récupéré : " + id);
                //MessageBox.Show("ID récupéré : " + id);
                //txttp.Text = id.ToString();
                return id;
                // Vous pouvez maintenant utiliser la variable "id" comme vous le souhaitez
            }
            // S'il n'y a aucune donnée retournée, vous pouvez retourner une valeur par défaut ou jeter une exception, selon votre cas.
            throw new Exception("Aucune donnée trouvée pour le type de produit : " + txttc.Text);
    }*/

    private void ajouter_Click(object sender, EventArgs e)
        {
            /*  Utils.CloseConnection();
             Reservation produit = new Reservation(txtnj.Value, Convert.ToDateTime(txtdr.Text), txtm.Text,Convert.ToInt32( txte.Text,txttc.Text);
             Reservation.ajouterReservation(produit);
             nouveau();
             //Connection.CloseConnection();
             remplir();
             ajouter.Enabled = true;
             img_Reservation.Enabled = true;
             modifier.Enabled = false;
             supprimer.Enabled = false;*/
}

            private void supprimer_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            if (MessageBox.Show("Voulez-vous suprimer Cette Reservation?", "Hotel Nouha", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.SuprimerDonner("Reservation", txtid.Text);
                MessageBox.Show("Supression Avec Success", "Hotel Nouha");
                nouveau();
                remplir();
                
                //pictureBox2.Enabled = false;
                modifier.Enabled = true;
                supprimer.Enabled = true;
            }
        }
        void nouveau()
        {
            Utils.CloseConnection();
            txtnj.Text = "";
            txtdr.Text = "";
            txtm.Text = "";
            txttc.Text = "";
            txte.Text = "";
            txtid_client.Text = "";
            txtid_chambre.Text = "";

        }
        private void modifier_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            Reservation reservation = new Reservation(Convert.ToInt32( txtnj.Text), Convert.ToDateTime(txtdr.Text), txtm.Text,Convert.ToInt32( txtid_client.Text),Convert.ToInt32( txtid_chambre.Text));
            int id = int.Parse(txtid.Text);
           Reservation.ModifierReservation(reservation, id);
            nouveau();
            remplir();
            
            modifier.Enabled = true;
            supprimer.Enabled = true;
        }

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = tableau.Rows.Count - 1;
            Utils.CloseConnection();
            if (e.RowIndex >= 0 && e.RowIndex < n)
            {
                DataGridViewRow row = tableau.Rows[e.RowIndex];
                txtid.Text = row.Cells["N°reservation"].Value.ToString();
                txtnj.Text = row.Cells["nombre_jour"].Value.ToString();
                txtdr.Text = row.Cells["date_reservation"].Value.ToString();
                txtm.Text = row.Cells["message"].Value.ToString();
                txte.Text = row.Cells["email"].Value.ToString();
                txttc.Text = row.Cells["type"].Value.ToString();
                txtid_client.Text = row.Cells["N°Client"].Value.ToString();
                txtid_chambre.Text = row.Cells["N°Chambre"].Value.ToString();
               
                modifier.Enabled = true;
                supprimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Aucun Element Selectionner", "Hote Nouha");
                txtid.Text = "";
                nouveau();
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
        }
    }
}
