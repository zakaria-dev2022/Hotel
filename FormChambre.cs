using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Hotel
{
    public partial class FormChambre : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string chemin = "";
        public FormChambre()
        {
            InitializeComponent();
        }

        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("select * from chambre ");
            //DataTable dataTable = Utils.ObtenirDonnees("select * from produit");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                img_chambre.Image = img;
                chemin = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + txttc.Text +  typeFile;
                chemin_Img.Text = chemin;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\hotel\img\chambre\" + chemin);

            }
        }

        void nouveau()
        {
            Utils.CloseConnection();
            txttc.Text = "";
            txtp.Text = "";
            txtdp.Text = "";
            chemin_Img.Text = "";
            img_chambre.Image = null;
            txttc.Focus();

        }


        private void exit_Click(object sender, EventArgs e)
        {
            dashbord dashbord = new dashbord();
            this.Hide();
            dashbord.Show();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            Chambre produit = new Chambre(txttc.Text, float.Parse(txtp.Text), txtdp.Text,chemin_Img.Text);
            Chambre.ajouterchambre(produit);
            nouveau();
            //Connection.CloseConnection();
            remplir();
            ajouter.Enabled = true;
            img_chambre.Enabled = true;
            modifier.Enabled = false;
            supprimer.Enabled = false;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            if (MessageBox.Show("Voulez-vous suprimer Cette Chambre?", "Hotel Nouha", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.SuprimerDonner("chambre", txtid.Text);
                MessageBox.Show("Supression Avec Success", "Hotel Nouha");
                nouveau();
                remplir();
                ajouter.Enabled = false;
                //pictureBox2.Enabled = false;
                modifier.Enabled = true;
                supprimer.Enabled = true;
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            Chambre produit = new Chambre(txttc.Text, float.Parse(txtp.Text), txtdp.Text,chemin_Img.Text);
            int id = int.Parse(txtid.Text);
            Chambre.ModifierChambre(produit, id);
            nouveau();
            remplir();
            ajouter.Enabled = false;
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
                txtid.Text = row.Cells["id"].Value.ToString();
                txttc.Text = row.Cells["type"].Value.ToString();
                txtp.Text = row.Cells["prix"].Value.ToString();
                txtdp.Text = row.Cells["description"].Value.ToString();
                chemin_Img.Text = row.Cells["image"].Value.ToString();
                string cheminimg = chemin_Img.Text;
                img_chambre.Load(@"C:\laragon\www\hotel\img\chambre\" + cheminimg);
                ajouter.Enabled = false;
                modifier.Enabled = true;
                supprimer.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Aucun Element Selectionner", "Hotel Nouha");
                txtid.Text = "";
                nouveau();
                ajouter.Enabled = true;
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
        }

        private void FormChambre_Load(object sender, EventArgs e)
        {
            remplir();
        }
    }
}
