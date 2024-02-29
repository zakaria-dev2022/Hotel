using Hotel;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FormEmploye : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string chemin = "";
        public FormEmploye()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                photo.Image = img;
                chemin = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + txtmt.Text + typeFile;
                lb_photo.Text = chemin;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\hotel\img\employe\" + chemin);

            }
        }

        private void FormEmploye_Load(object sender, EventArgs e)
        {
            remplir();
        }

        void nouveau()
        {
            txtn.Text = "";
            txtp.Text = "";
            txtcn.Text = "";
            txtmt.Text = "";
            txtpt.Text = "";
            txtt.Text = "";
            photo.Image = null;
            txtn.Focus();
            ajouter.Enabled = true;
            modifier.Enabled = false;
            supprimer.Enabled = false;
        }
        void remplir()
        {
            Utils.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Utils.ObtenirDonnees("select * from employe");
            //DataTable dataTable = Utils.ObtenirDonnees("select nom,prenom,cin,adresse,date_naissance,poste from employe");
            // Lier le DataTable au DataGridView
            tableaux.DataSource = dataTable;

        }

        private void tableaux_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = tableaux.Rows.Count - 1;
            if (e.RowIndex >= 0 && e.RowIndex < n)
            {
                DataGridViewRow row = tableaux.Rows[e.RowIndex];
                txtid.Text = row.Cells["id"].Value.ToString();
                txtn.Text = row.Cells["nom"].Value.ToString();
                txtp.Text = row.Cells["prenom"].Value.ToString();
                txtcn.Text = row.Cells["cin"].Value.ToString();
                txtt.Text = row.Cells["tel"].Value.ToString();
                txtmt.Text = row.Cells["matricule"].Value.ToString();
                txtpt.Text = row.Cells["poste"].Value.ToString();
                lb_photo.Text = row.Cells["photo"].Value.ToString();
                photo.Image = Image.FromFile(@"C:\laragon\www\hotel\img\employe\" + lb_photo.Text);
                ajouter.Enabled = false;
                modifier.Enabled = true;
                supprimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Aucun Element Selectionner", "Restaurantly");
                txtid.Text = "";
                nouveau();
                ajouter.Enabled = true;
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "" && txtp.Text != "" && txtcn.Text != "" && txtt.Text != "" && txtmt.Text != "" && txtpt.Text != "" && photo.Image != null)
            {


                Employee employee = new Employee(txtn.Text, txtp.Text, txtcn.Text, txtt.Text, txtmt.Text, txtpt.Text, lb_photo.Text);
                Employee.ajouterEmploye(employee);
                nouveau();
                //Connection.CloseConnection();
                remplir();
            }
            else
            {
                MessageBox.Show("Verifier Votre Donner", "Restaurantly");
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            if (MessageBox.Show("Voulez-vous  se Employe?", "Restaurantly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.SuprimerDonner("employe", txtid.Text);
                MessageBox.Show("Supression Avec Success", "Restaurantly");
                //Connection.CloseConnection();
                remplir();
                nouveau();
                ajouter.Enabled = true;
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "" && txtp.Text != "" && txtcn.Text != "" && txtt.Text != "" && txtmt.Text != "" && txtpt.Text != "" && photo.Image != null)
            {
                Employee employee = new Employee(txtn.Text, txtp.Text, txtcn.Text, txtt.Text, txtmt.Text, txtpt.Text, lb_photo.Text);
                int id = int.Parse(txtid.Text);
                Employee.Modifieremployee(employee, id);
                nouveau();
                remplir();
                ajouter.Enabled = true;
                modifier.Enabled = false;
                supprimer.Enabled = false;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dashbord dashbord = new dashbord();
            this.Hide();
            dashbord.Show();
        }
    }
}















