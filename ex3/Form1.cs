using System;
using System.Windows.Forms;

namespace ex3 {
    public partial class Form1 : Form {

        private ExtrasCont cont = null;

        public Form1() {
            InitializeComponent();

        }

        private void btnAdaugaExtras_Click(object sender, EventArgs e) {
            AdaugaExtras adaugaExtras = new AdaugaExtras(cont);
            adaugaExtras.ShowDialog();
        }
    }
}
