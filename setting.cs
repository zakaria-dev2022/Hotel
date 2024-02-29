using MySql.Data.MySqlClient;
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
    public partial class setting : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string chemin = "";
        public setting()
        {
            InitializeComponent();
        }

        private void inport_photo_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                logo.Image = img;
                chemin = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} -" + " Logo " + typeFile;
                lb_logo.Text = chemin;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                //File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);
                File.Copy(fileinfo.FullName, @"C:\laragon\www\hotel\img\logo\" + chemin);

            }
        }
        void remplir()
        {

            Utils.OpenConnection();

            string query = "select * from admin where id= 2";
            MySqlCommand command = new MySqlCommand(query, Utils.cnx);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtnu.Text = reader[1].ToString();
                    txtmp.Text = reader[2].ToString();
                    txtna.Text = reader[3].ToString();
                    lb_logo.Text = reader[4].ToString();
                }
                Utils.CloseConnection();
                //reader.Close();

                logo.Load(@"C:\laragon\www\hotel\img\logo\" + lb_logo.Text);
            }
            }
            private void btn_save_Click(object sender, EventArgs e)
        {
            Utils.CloseConnection();
            admin admin = new admin(txtnu.Text, txtmp.Text, txtna.Text, lb_logo.Text);
            admin.ModifierAdmin(admin);
            remplir();
        }

        private void oeil_mp_Click(object sender, EventArgs e)
        {
            if (txtmp.PasswordChar == '*')
            {
                txtmp.PasswordChar = '\0';
            }
            else
            {
                txtmp.PasswordChar = '*';
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-Vous Sortir??", "Hotel Nouha", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dashbord dashboard = new dashbord();
                dashboard.Show();
                this.Hide();
            }
        }

        private void setting_Load(object sender, EventArgs e)
        {
            remplir();
        }
    }
}
