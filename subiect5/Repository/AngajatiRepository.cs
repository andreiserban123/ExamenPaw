using subiect5.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace subiect5.Repository {
    public class AngajatiRepository {
        static Random random = new Random();
        public List<Angajat> getAngajati() {
            List<Angajat> angajati = new List<Angajat>();
            using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=X:\\facultate\\paw\\subiect5\\db.mdf;Integrated Security=True;Connect Timeout=30")) {
                connection.Open();


                using (var command = new SqlCommand("INSERT INTO ANGAJATI(Nume, data_nastere, id_companie) values(@n, @d, @i)", connection)) {
                    command.Parameters.Add("n", "Bob Cat");
                    command.Parameters.Add("d", DateTime.Parse("05.03.2000"));
                    command.Parameters.Add("i", random.Next(1, 4));
                    command.ExecuteNonQuery();
                }


                using (var command = new SqlCommand("Select * from Angajati", connection)) {

                    var reader = command.ExecuteReader();
                    while (reader.Read()) {

                        Angajat a = new Angajat();
                        a.Name = reader.GetString(1);
                        a.Data_nasterii = reader.GetDateTime(2);
                        a.Id_companie = reader.GetInt32(3);

                        angajati.Add(a);
                    }
                }

            }
            return angajati;
        }
    }
}
