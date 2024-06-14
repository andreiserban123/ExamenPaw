using System;
using System.Windows.Forms;

namespace subiect7 {
    public partial class FormCredit : Form {
        public Credit fCredit;
        public FormCredit(Credit credit) {
            InitializeComponent();
            if (credit == null) {
                credit = new Credit();
            }
            else {
                tbClient.Text = credit.Client;
                tbData.Text = credit.DataAcordarii.ToString("d");
                tbDobanda.Text = credit.Dobanda.ToString();
                tbValoare.Text = credit.ValoareCredit.ToString();
                tbPerioada.Text = credit.Perioada.ToString();
                btnFinish.Text = "Editeaza";
            }
            fCredit = credit;
        }

        private void btnFinish_Click(object sender, System.EventArgs e) {
            try {
                fCredit.Client = tbClient.Text;
                fCredit.Dobanda = double.Parse(tbDobanda.Text);
                fCredit.ValoareCredit = double.Parse(tbValoare.Text);
                fCredit.DataAcordarii = DateTime.Parse(tbData.Text);
                fCredit.Perioada = int.Parse(tbPerioada.Text);

                if (cbAlgoritm.SelectedIndex == -1) {
                    errorProvider1.SetError(cbAlgoritm, "Seteaza un index!");
                    this.DialogResult = DialogResult.None;
                }
                // Setarea algoritmului selectat
                if (cbAlgoritm.SelectedIndex == 0) {
                    fCredit.AlgoritmDes = Algoritmi.DesfasuratorRateDescrescatoare;
                }
                else if (cbAlgoritm.SelectedIndex == 1) {
                    fCredit.AlgoritmDes = Algoritmi.DesfasuratorRateConstante;
                }


                var res = fCredit.CalculDesfasurator();
                MessageBox.Show(string.Join(",", res));


                if (fCredit.Perioada <= 0) {
                    errorProvider1.SetError(tbPerioada, "Perioada invalida");
                    this.DialogResult = DialogResult.None;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbClient_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (tbClient.Text.Length < 3) {
                errorProvider1.SetError(tbClient, "Numele este prea mic!");
            }
            else {
                errorProvider1.SetError(tbClient, "");
            }
        }
    }
}
