using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    internal class Reservation
    {

        public int nombre_jour;
        public DateTime date_reservation;
        public string message;
        public int client_id;
        public int chambre_id;


        public Reservation(int nombre_jour, DateTime date_reservation, string message, int client_id, int chambre_id)
        {
            //this.ReservationId = ReservationId;
            this.nombre_jour = nombre_jour;
            this.date_reservation = date_reservation;
            this.message = message;
            this.client_id = client_id;
            this.chambre_id = chambre_id;

        }

        public static void ajouterreservation(Reservation reservation)
        {
            try
            {

                Utils.OpenConnection();

                string query = "INSERT INTO reservation (nombre_jour,date_reservation,message,client_id,chambre_id) VALUES (@nombre_jour, @date_reservation,@message, @client_id,@chambre_id)";

                MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                {
                    command.Parameters.AddWithValue("@nombre_jour", reservation.nombre_jour);
                    command.Parameters.AddWithValue("@date_reservation", reservation.date_reservation);
                    command.Parameters.AddWithValue("@message", reservation.message);
                    command.Parameters.AddWithValue("@client_id", reservation.client_id);
                    command.Parameters.AddWithValue("@chambre_id", reservation.chambre_id);


                    command.ExecuteNonQuery();
                    MessageBox.Show("ajoute avec success", "Hotel Nouha");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ", "Hotel Nouha");
            }
        }
       

        public static void ModifierReservation(Reservation reservation, int id)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE reservation SET nombre_jour = @nombre_jour, date_reservation = @date_reservation,message = @message, client_id = @client_id,chambre_id = @chambre_id WHERE id = @id";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@nombre_jour", reservation.nombre_jour);
                        command.Parameters.AddWithValue("@date_reservation", reservation.date_reservation);
                        command.Parameters.AddWithValue("@message", reservation.message);
                        command.Parameters.AddWithValue("@client_id", reservation.client_id);
                        command.Parameters.AddWithValue("@chambre_id", reservation.chambre_id);
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
