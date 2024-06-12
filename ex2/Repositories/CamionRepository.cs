using ex2.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ex2.Repositories {
    public class CamionRepository {
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=X:\\facultate\\paw\\ex2\\consultatii.mdf;Integrated Security=True;Connect Timeout=30";
        public List<Camion> GetCamioane() {

            var camioane = new List<Camion>();
            using (var connection = new SqlConnection(connectionString)) {
                // open connection
                connection.Open();
                //define command
                using (var command = new SqlCommand("SELECT Id, Name, Tonaj FROM Camioane", connection)) {
                    //execute command
                    var reader = command.ExecuteReader();
                    //optional: read data
                    while (reader.Read()) {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        var tonaj = reader.GetInt32(2);
                        var camion = new Camion(id, name, tonaj);
                        camioane.Add(camion);
                    }
                }
            }
            return camioane;
        }

        public void StergeCamioane(List<int> ids) {
            using (var connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (var transaction = connection.BeginTransaction()) {
                    try {

                        foreach (var id in ids) {

                            using (var command = new SqlCommand("DELETE FROM Camioane WHERE Id = @id", connection)) {
                                command.Transaction = transaction;
                                command.Parameters.AddWithValue("id", id);
                                command.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex) {
                        transaction.Rollback();
                        MessageBox.Show("Ceva a mers prost: " + ex.Message);
                    }
                }
            }
        }
    }
}