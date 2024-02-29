using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class dashbord : Form
    {
        public dashbord()
        {
            InitializeComponent();
        }

        private void dashbord_Load(object sender, EventArgs e)
        {
            Utils.AfficherImageAdmin(logo);
            
        }

        private void lb_employe_Click(object sender, EventArgs e)
        {
            FormEmploye emp = new FormEmploye();
            this.Hide();
            emp.Show();
        }

        private void pc_employe_Click(object sender, EventArgs e)
        {
            FormEmploye emp = new FormEmploye();
            this.Hide();
            emp.Show();
        }

        private void lb_chambre_Click(object sender, EventArgs e)
        {
            FormChambre emp = new FormChambre();
            this.Hide();
            emp.Show();
        }

        private void pc_chambre_Click(object sender, EventArgs e)
        {
            FormChambre emp = new FormChambre();
            this.Hide();
            emp.Show();
        }

        private void lb_reservation_Click(object sender, EventArgs e)
        {
            FormReservation emp = new FormReservation();
            this.Hide();
            emp.Show();
        }

        private void pc_reservation_Click(object sender, EventArgs e)
        {
            FormReservation emp = new FormReservation();
            this.Hide();
            emp.Show();

        }

        private void deconncter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-Vous Sortir??", "Hotel Nouha", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login login = new login();
                login.Show();
                this.Hide();
            }
        }
    }
}
