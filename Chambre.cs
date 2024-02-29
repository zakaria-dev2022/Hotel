using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    internal class Chambre
    {

        public string type;
        public float prix;
        public string description;
        public string image;


        public Chambre(string type, float prix, string description, string image)
        {
            //this.ChambreId = ChambreId;
            this.type = type;
            this.prix = prix;
            this.description = description;
            this.image = image;

        }

        public static void ajouterchambre(Chambre chambre)
        {
            try
            {

                Utils.OpenConnection();

                string query = "INSERT INTO chambre (type,prix,description,image) VALUES (@type, @prix,@description,@image)";

                MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                {
                    command.Parameters.AddWithValue("@type", chambre.type);
                    command.Parameters.AddWithValue("@prix", chambre.prix);
                    command.Parameters.AddWithValue("@description", chambre.description);
                    command.Parameters.AddWithValue("@image", chambre.image);


                    command.ExecuteNonQuery();
                    MessageBox.Show("ajoute avec success", "Hotel Nouha");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ", "Hotel Nouha");
            }
        }
        

        public static void ModifierChambre(Chambre chambre, int id)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE chambre SET type = @type, prix = @prix,description = @description,image = @image WHERE id = @id";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@type", chambre.type);
                        command.Parameters.AddWithValue("@prix", chambre.prix);
                        command.Parameters.AddWithValue("@description", chambre.description);
                        command.Parameters.AddWithValue("@image", chambre.image);
                        command.Parameters.AddWithValue("@id", id);

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
