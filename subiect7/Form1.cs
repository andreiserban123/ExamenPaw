using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace subiect7 {
    public partial class Form1 : Form {

        BindingList<Credit> credite = new BindingList<Credit>();

        public Form1() {
            InitializeComponent();

            /*  OpenFileDialog fd = new OpenFileDialog();
              fd.Filter = "|*.txt";
              fd.CheckFileExists = true;*/

            //if (fd.ShowDialog() == DialogResult.OK) {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "date.txt");

            using (StreamReader sr = new StreamReader(filePath)) {
                string line;
                while ((line = sr.ReadLine()) != null) {
                    string[] values = line.Split(',');
                    Credit c = new Credit();
                    c.Client = values[0];
                    c.ValoareCredit = double.Parse(values[1]);
                    c.Dobanda = double.Parse(values[2]);
                    c.DataAcordarii = DateTime.Parse(values[3]);
                    c.Perioada = int.Parse(values[4]);
                    credite.Add(c);
                }
            }
            //}

            dgvCredite.DataSource = credite;
            dgvCredite.AutoGenerateColumns = true;

        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e) {
            Credit credit = null;

            FormCredit form = new FormCredit(credit);
            if (form.ShowDialog() == DialogResult.OK) {

                credit = form.fCredit;
                credite.Add(credit);
            }
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e) {
            if (dgvCredite.SelectedRows.Count > 0) {
                var selectedRow = dgvCredite.SelectedRows[0];

                var credit = selectedRow.DataBoundItem as Credit;

                foreach (var cr in credite) {
                    if (credit.Equals(cr)) {
                        credit = cr; break;
                    }
                }

                FormCredit form = new FormCredit(credit);

                if (form.ShowDialog() == DialogResult.OK) {
                    credit = form.fCredit;
                }


            }
            else {
                MessageBox.Show("Nu ai selectat intregeaga inregistrare!");
            }
        }

    }
}
