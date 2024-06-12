using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ex3 {
    public partial class FormExtrasCont : Form {
        private List<Tranzactie> tranzactiiDisponibile;

        public ExtrasCont ExtrasContCreat { get; set; }
        public FormExtrasCont(List<Tranzactie> tranzactiiDisponibile, out ExtrasCont extrasCont) {
            InitializeComponent();
            this.tranzactiiDisponibile = tranzactiiDisponibile;
            extrasCont = null; // Inițializăm parametrul out cu null

            foreach (var tranzactie in tranzactiiDisponibile) {
                listBoxTranzactii.Items.Add(tranzactie.ToString());
            }
        }

        private void btnCreazaExtrasCont_Click(object sender, EventArgs e) {
            try {
                string numeClient = txtNumeClient.Text;
                string adresa = txtAdresa.Text;

                if (string.IsNullOrWhiteSpace(numeClient) || string.IsNullOrWhiteSpace(adresa)) {
                    throw new Exception("Nume client și adresa sunt obligatorii.");
                }

                List<Tranzactie> tranzactiiSelectate = listBoxTranzactii.SelectedIndices
                    .Cast<int>()
                    .Select(index => tranzactiiDisponibile[index])
                    .ToList();

                if (tranzactiiSelectate.Count > 5) {
                    throw new Exception("Puteți selecta maxim 5 tranzacții.");
                }

                // Creăm obiectul ExtrasCont și îl setăm în parametrul out
                ExtrasCont extrasCont = new ExtrasCont(numeClient, adresa, tranzactiiSelectate);
                MessageBox.Show("Extras de cont creat cu succes!");
                this.DialogResult = DialogResult.OK;
                this.Close();

                // Returnăm obiectul creat prin parametrul out
                ExtrasContCreat = extrasCont;
            }
            catch (Exception ex) {
                MessageBox.Show($"Eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
