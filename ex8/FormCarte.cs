using System;
using System.Windows.Forms;

namespace ex8 {
    public partial class FormCarte : Form {
        public Carte fCarte;

        public FormCarte(Carte carte) {
            InitializeComponent();

            cbCategorie.Items.Clear();

            cbCategorie.Items.Add("SF");
            cbCategorie.Items.Add("Fantasy");
            cbCategorie.Items.Add("Crime and mistery");
            cbCategorie.Items.Add("Romance");

            cbCategorie.Text = string.Empty;
        }

        private void btnFinish_Click(object sender, System.EventArgs e) {

            try {
                double pret = double.Parse(tbPret.Text);
                string categ = cbCategorie.SelectedItem.ToString();
                string titlu = tbTitlu.Text;
                string ISBN = tbISBN.Text;

                fCarte = new Carte(titlu, pret, categ, ISBN);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbPret_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (double.Parse(tbPret.Text) <= 0) {
                errorProvider1.SetError(tbPret, "Pret invalid");
                e.Cancel = true;
            }
            else {
                errorProvider1.SetError(tbPret, "");

            }
        }

        private void tbISBN_Validating(object sender, System.ComponentModel.CancelEventArgs e) {

            if (tbISBN.Text.Length != 13) {
                errorProvider1.SetError(tbISBN, "ISBN invalid");
                e.Cancel = true;
            }
            else {
                errorProvider1.SetError(tbISBN, "");
            }

        }
    }
}
