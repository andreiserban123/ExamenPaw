using System;
using System.Windows.Forms;

namespace subiect6 {
    public partial class FormCandidat : Form {

        public Candidat fCandidat;
        public FormCandidat(Candidat candidat) {
            InitializeComponent();

            if (candidat != null) {
                tbCod.Text = candidat.CodCandidat.ToString();
                tbNume.Text = candidat.NumeCandidat;
                tbMedie.Text = candidat.MedieConcurs.ToString();
                tbOptiuni.Text = string.Join(",", candidat.VectorOptiuni);
                btnFinish.Text = "Editeaza";
            }
            else {
                candidat = new Candidat();
            }
            fCandidat = candidat;
        }

        private void btnFinish_Click(object sender, EventArgs e) {
            try {
                fCandidat.CodCandidat = int.Parse(tbCod.Text);
                fCandidat.NumeCandidat = tbNume.Text;
                fCandidat.MedieConcurs = float.Parse(tbMedie.Text);
                string[] values = tbOptiuni.Text.Split(',');
                int[] nou = new int[values.Length];
                for (int i = 0; i < nou.Length; i++) {
                    nou[i] = int.Parse(values[i]);
                }
                fCandidat.VectorOptiuni = nou;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbNume_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (tbNume.Text.Length < 3) {
                errorProvider1.SetError(tbNume, "Numele este prea scurt");
                e.Cancel = true;
            }
            else {
                errorProvider1.SetError(tbNume, "");
            }
        }
    }
}
