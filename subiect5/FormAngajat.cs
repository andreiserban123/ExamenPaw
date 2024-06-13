using subiect5.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace subiect5 {
    public partial class FormAngajat : Form {
        public Angajat cAngajat;
        public List<Companie> companies;
        public FormAngajat(Angajat angajat, List<Companie> companies) {
            InitializeComponent();

            cbCompanie.Items.Clear();

            this.companies = companies;

            foreach (var companie in companies) {
                cbCompanie.Items.Add(companie.Id);
            }

            if (angajat == null) {
                angajat = new Angajat();
                angajat.Id_companie = -1;
            }
            else {
                tbNume.Text = angajat.Name;
                dateTimeDataNast.Value = angajat.Data_nasterii;
                cbCompanie.Text = angajat.Id_companie.ToString();
                btnSalveaza.Text = "Editeaza";
            }

            cAngajat = angajat;

        }

        private void btnSalveaza_Click(object sender, EventArgs e) {

            try {
                cAngajat.Name = tbNume.Text;
                cAngajat.Data_nasterii = dateTimeDataNast.Value;
                if (cAngajat.Id_companie != (int)cbCompanie.SelectedItem && cAngajat.Id_companie != -1) {

                    var companie = companies.Find(x => x.Id == cAngajat.Id_companie) as Companie;
                    companie.Angajati.Remove(cAngajat);
                }
                cAngajat.Id_companie = (int)cbCompanie.SelectedItem;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void tbNume_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (tbNume.Text.Length < 2) {
                errorProvider1.SetError(tbNume, "Nume prea scurt");
                e.Cancel = true;
            }
            else {
                errorProvider1.SetError(tbNume, "");
            }
        }

        private void dateTimeDataNast_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (DateTime.Now.Year - dateTimeDataNast.Value.Year < 20) {
                errorProvider1.SetError(dateTimeDataNast, "Varsta minima 20");
                e.Cancel = true;
            }
            else {
                errorProvider1.SetError(dateTimeDataNast, "");
            }
        }


    }
}
