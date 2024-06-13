using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ex3 {
    public partial class AdaugaExtras : Form {
        public ExtrasCont cExtrasCont;
        public AdaugaExtras(ExtrasCont extrasCont) {
            InitializeComponent();
            Tranzactie t1 = new Tranzactie(21, "RO24INGB34343", "Plata facturi", 452.31, "21.10.2021");
            Tranzactie t2 = new Tranzactie(45, "RO21BRDB21323", "Bani de mancare", 110, "21.12.2022");
            Tranzactie t3 = new Tranzactie(89, "RO45RAIF31212", "Transfer", 432.21, "12.11.2023");
            Tranzactie t4 = new Tranzactie(90, "RO43INGB21332", "Plata bilete", 21.21, "12.01.2023");
            Tranzactie t5 = new Tranzactie(100, "RO21BCR21323", "Plata restaurant", 100.21, "22.07.2023");
            List<Tranzactie> tranzactiiDisponibile = new List<Tranzactie>();
            tranzactiiDisponibile.Add(t1);
            tranzactiiDisponibile.Add(t2);
            tranzactiiDisponibile.Add(t3);
            tranzactiiDisponibile.Add(t4);
            tranzactiiDisponibile.Add(t5);

            cbTranzactii.Items.Add(t1.idTranzactie);
            cbTranzactii.Items.Add(t2.idTranzactie);
            cbTranzactii.Items.Add(t3.idTranzactie);
            cbTranzactii.Items.Add(t4.idTranzactie);
            cbTranzactii.Items.Add(t5.idTranzactie);

            if (extrasCont == null) {
                extrasCont = new ExtrasCont("N|A", "N|A", new List<Tranzactie>());
                btnAdauga.Text = "Adauga";
            }
            else {
                tbNume.Text = extrasCont.numeClient;
                tbAdresa.Text = extrasCont.adresa;
            }
            cExtrasCont = extrasCont;
        }

        private void btnAdauga_Click(object sender, EventArgs e) {
            Tranzactie t1 = new Tranzactie(21, "RO24INGB34343", "Plata facturi", 452.31, "21.10.2021");
            Tranzactie t2 = new Tranzactie(45, "RO21BRDB21323", "Bani de mancare", 110, "21.12.2022");
            Tranzactie t3 = new Tranzactie(89, "RO45RAIF31212", "Transfer", 432.21, "12.11.2023");
            Tranzactie t4 = new Tranzactie(90, "RO43INGB21332", "Plata bilete", 21.21, "12.01.2023");
            Tranzactie t5 = new Tranzactie(100, "RO21BCR21323", "Plata restaurant", 100.21, "22.07.2023");
            List<Tranzactie> tranzactiiDisponibile = new List<Tranzactie>();
            tranzactiiDisponibile.Add(t1);
            tranzactiiDisponibile.Add(t2);
            tranzactiiDisponibile.Add(t3);
            tranzactiiDisponibile.Add(t4);
            tranzactiiDisponibile.Add(t5);

            cExtrasCont.numeClient = tbNume.Text;
            cExtrasCont.adresa = tbAdresa.Text;

            if (cbTranzactii.SelectedIndex != -1) {
                int selectedId = (int)cbTranzactii.SelectedItem;
                Tranzactie selected = tranzactiiDisponibile.Find(t => t.idTranzactie == selectedId);
                cExtrasCont.tranzactii.Add(selected);
            }
        }

        private void tbAdresa_Validating(object sender, CancelEventArgs e) {
            if (tbAdresa.Text.Length < 8) {
                errorProviderAn.SetError(tbAdresa, "Adresa este prea scurta!");
                e.Cancel = true;
            }
            else {
                errorProviderAn.SetError(tbAdresa, "");
            }
        }
    }
}