using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    internal class admin
    {
        public string login;
        public string mot_de_passe;
        public string nom_app;
        public string logo;

        public admin(string login, string mot_de_passe, string nom_app, string logo)
        {
            //this.adminsId = adminsId;
            this.login = login;
            this.mot_de_passe = mot_de_passe;
            this.nom_app = nom_app;
            this.logo = logo;

        }

        public static void ModifierAdmin(admin admin)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE admin SET login = @login, mot_de_passe = @mot_de_passe,nom_app = @nom_app, logo = @logo WHERE id = 2";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@login", admin.login);
                        command.Parameters.AddWithValue("@mot_de_passe", admin.mot_de_passe);
                        command.Parameters.AddWithValue("@nom_app", admin.nom_app);
                        command.Parameters.AddWithValue("@logo", admin.logo);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Modification effectuée avec succès", "Hotel Nouha");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification des données : {ex.Message}", "Hotel Nouha");
            }
        }
    }
}
