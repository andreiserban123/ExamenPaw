using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ex3 {
    public partial class Form1 : Form {

        private List<ExtrasCont> extrase = new List<ExtrasCont>();
        public Form1() {
            InitializeComponent();
            Tranzactie t1 = new Tranzactie(21, "RO24INGB34343", "Plata facturi", 452.31, "21.10.2021");
            Tranzactie t2 = new Tranzactie(45, "RO21BRDB21323", "Bani de mancare", 110, "21.12.2022");
            Tranzactie t3 = new Tranzactie(89, "RO45RAIF31212", "Transfer", 432.21, "12.11.2023");
            Tranzactie t4 = new Tranzactie(90, "RO43INGB21332", "Plata bilete", 21.21, "12.01.2023");
            Tranzactie t5 = new Tranzactie(100, "RO21BCR21323", "Plata restaurant", 100.21, "22.07.2023");

            List<Tranzactie> l1 = new List<Tranzactie>();
            l1.Add(t1);
            l1.Add(t2);
            l1.Add(t3);

            List<Tranzactie> l2 = new List<Tranzactie>();
            l2.Add(t4);
            l2.Add(t5);


            List<Tranzactie> l3 = new List<Tranzactie>();
            l3.Add(t5);
            l3.Add(t2);

            ExtrasCont ex1 = new ExtrasCont("Gabriel Popescu", "Bld. Unirii 89", l1);
            ExtrasCont ex2 = new ExtrasCont("Maria Andonescu", "Calea Victoriei 78", l2);
            ExtrasCont ex3 = new ExtrasCont("Vasile Iulius", "Strada Izvor 90", l3);

            extrase.Add(ex1);
            extrase.Add(ex2);
            extrase.Add(ex3);


            ListViewItem itm = new ListViewItem(new string[] { ex1.NumeClient, ex2.Adresa });
            itm.Tag = ex1;
            lvExtraseCont.Items.Add(itm);
            itm = new ListViewItem(new string[] { ex2.NumeClient, ex2.Adresa });
            itm.Tag = ex2;
            lvExtraseCont.Items.Add(itm);
            itm = new ListViewItem(new string[] { ex3.NumeClient, ex3.Adresa });
            itm.Tag = ex3;
            lvExtraseCont.Items.Add(itm);
        }

        private void btnAdaugaExtras_Click(object sender, EventArgs e) {
            ExtrasCont extras = null;
            AdaugaExtras formAdauga = new AdaugaExtras(extras);
            if (formAdauga.ShowDialog() == DialogResult.OK) {
                extras = formAdauga.cExtrasCont;
                ListViewItem itm = new ListViewItem(
                   new string[] {
                       extras.NumeClient, extras.Adresa
                   }
                   );
                itm.Tag = extras;
                lvExtraseCont.Items.Add(itm);
                extrase.Add(extras);
            }
        }

        private void lvExtraseCont_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvExtraseCont.SelectedItems.Count > 0) {
                var extras = lvExtraseCont.SelectedItems[0].Tag as ExtrasCont;
                lvTranzactii.Items.Clear();
                tbExtrasDetalii.Text = extras.NumeClient;

                foreach (var item in extras.tranzactii) {

                    ListViewItem itm = new ListViewItem(new string[] {
                        item.contIban, item.detaliiTranzactie, item.suma.ToString(),
                        item.dataTranzactie.ToString()
                    });
                    lvTranzactii.Items.Add(itm);
                    lvTranzactii.Tag = item;
                }
            }
        }

        private void salvareTXTToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Fisiere txt: extrase cont |*.txt";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK) {

                using (StreamWriter sw = new StreamWriter(fd.FileName)) {
                    foreach (var extras in extrase) {
                        sw.WriteLine(extras.numeClient + " " + extras.adresa);
                        foreach (var tranz in extras.tranzactii) {
                            sw.WriteLine("\t\t" + tranz);
                        }
                    }

                    MessageBox.Show("Scrierea s-a realizat cu success!");
                }
            }
        }

        private void saveDBToolStripMenuItem_Click(object sender, EventArgs e) {
            using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=X:\\facultate\\paw\\ex3\\examen.mdf;Integrated Security=True;Connect Timeout=30")) {
                connection.Open();

                foreach (var extras in extrase) {
                    // Inserare în tabelul Extrase
                    string insertExtraseQuery = "INSERT INTO Extrase (Nume, Adresa) OUTPUT INSERTED.Id VALUES (@Nume, @Adresa)";
                    using (var commandExtrase = new SqlCommand(insertExtraseQuery, connection)) {
                        commandExtrase.Parameters.AddWithValue("@Nume", extras.NumeClient);
                        commandExtrase.Parameters.AddWithValue("@Adresa", extras.Adresa);

                        int extraseId = (int)commandExtrase.ExecuteScalar();

                        foreach (var tranzactie in extras.Tranzactii) {
                            string insertTranzactiiQuery = "INSERT INTO Tranzactii (Iban, Detalii, Suma, Data) OUTPUT INSERTED.Id VALUES (@Iban, @Detalii, @Suma, @Data)";
                            using (var commandTranzactii = new SqlCommand(insertTranzactiiQuery, connection)) {
                                commandTranzactii.Parameters.AddWithValue("@Iban", tranzactie.contIban);
                                commandTranzactii.Parameters.AddWithValue("@Detalii", tranzactie.detaliiTranzactie);
                                commandTranzactii.Parameters.AddWithValue("@Suma", tranzactie.suma);
                                commandTranzactii.Parameters.AddWithValue("@Data", tranzactie.dataTranzactie);

                                int tranzactiiId = (int)commandTranzactii.ExecuteScalar();

                                string insertExtraseTranzactiiQuery = "INSERT INTO ExtraseTranzactii (ExtraseId, TranzactiiId) VALUES (@ExtraseId, @TranzactiiId)";
                                using (var commandExtraseTranzactii = new SqlCommand(insertExtraseTranzactiiQuery, connection)) {
                                    commandExtraseTranzactii.Parameters.AddWithValue("@ExtraseId", extraseId);
                                    commandExtraseTranzactii.Parameters.AddWithValue("@TranzactiiId", tranzactiiId);
                                    commandExtraseTranzactii.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e) {
            if (lvExtraseCont.SelectedItems.Count == 1) {
                ExtrasCont cont = lvExtraseCont.SelectedItems[0].Tag as ExtrasCont;
                AdaugaExtras form = new AdaugaExtras(cont);

                if (form.ShowDialog() == DialogResult.OK) {

                }
            }
            else {
                MessageBox.Show("Selecteaza un singur extras!");
            }
        }
    }
}
