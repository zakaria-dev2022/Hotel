using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    internal class Employee
    {

        // public int employeeId;
        public string nom;
        public string prenom;
        public string cin;
        public string tel;
        public string matricule;
        public string poste;
        public string photo;


        public Employee(string nom, string prenom, string cin, string tel, string matricule, string poste, string photo)
        {
            //this.employeeId = employeeId;
            this.nom = nom;
            this.prenom = prenom;
            this.cin = cin;
            this.tel = tel;
            this.matricule = matricule;
            this.poste = poste;
            this.photo = photo;
        }

        public static void ajouterEmploye(Employee employee)
        {
            try
            {

                Utils.OpenConnection();

                string query = "INSERT INTO employe (nom, prenom,cin, tel,matricule, poste,photo) VALUES (@Nom, @Prenom,@cin, @tel,@matricule, @poste, @photo)";

                MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                {
                    command.Parameters.AddWithValue("@Nom", employee.nom);
                    command.Parameters.AddWithValue("@Prenom", employee.prenom);
                    command.Parameters.AddWithValue("@cin", employee.cin);
                    command.Parameters.AddWithValue("@tel", employee.tel);
                    command.Parameters.AddWithValue("@matricule", employee.matricule);
                    command.Parameters.AddWithValue("@poste", employee.poste);
                    command.Parameters.AddWithValue("@photo", employee.photo);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Votre Employee Bien Ajouter", "Restaurantly");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ");
            }
        }

        public static void Modifieremployee(Employee employee, int id)
        {
            try
            {

                {
                    Utils.OpenConnection();

                    string query = "UPDATE employe SET nom = @Nom, prenom = @Prenom,cin = @cin, tel = @tel,matricule = @matricule, poste = @poste, photo = @photo WHERE id = @id";


                    MySqlCommand command = new MySqlCommand(query, Utils.cnx);
                    {
                        command.Parameters.AddWithValue("@Nom", employee.nom);
                        command.Parameters.AddWithValue("@Prenom", employee.prenom);
                        command.Parameters.AddWithValue("@cin", employee.cin);
                        command.Parameters.AddWithValue("@tel", employee.tel);
                        command.Parameters.AddWithValue("@matricule", employee.matricule);
                        command.Parameters.AddWithValue("@poste", employee.poste);
                        command.Parameters.AddWithValue("@photo", employee.photo);
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Modification effectuée avec succès", "Restaurantly");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification des données : {ex.Message}");
            }
        }



















    }
}
