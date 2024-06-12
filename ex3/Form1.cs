using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ex3 {
    public partial class Form1 : Form {

        public List<Tranzactie> tranzactiiDisponibile = new List<Tranzactie> {
                new Tranzactie("RO49AAAA1B31007593840000", "Plata factura", 100.50, "2024-01-15"),
                new Tranzactie("RO49AAAA1B31007593840000", "Retragere numerar", 200.75, "2024-01-20"),
                new Tranzactie("RO49AAAA1B31007593840000", "Depunere numerar", 300.25, "2024-01-25")
            };
        public Form1() {
            InitializeComponent();

        }

        private void btnAdaugaExtras_Click(object sender, EventArgs e) {
            ExtrasCont ec = null;
            FormExtrasCont form = new FormExtrasCont(tranzactiiDisponibile, out ec);
            if (form.ShowDialog() == DialogResult.OK) {

                MessageBox.Show(ec.ToString());
            }
        }
    }
}
