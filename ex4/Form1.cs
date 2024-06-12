using System;
using System.Windows.Forms;

namespace ex4 {
    public partial class Form1 : Form {

        Medic m;

        public Form1() {
            InitializeComponent();
            m = new Medic("Medic1", "Specializare1");
            textBox1.Text = m.Nume + " - " + m.Specializare;
        }

        private void btnAdauga_Click(object sender, EventArgs e) {
            FormMedic formMedic = new FormMedic();
            if (formMedic.ShowDialog() == DialogResult.OK) {

                try {
                    string nume = formMedic.tbNume.Text;
                    int varsta = Int32.Parse(formMedic.tbVarsta.Text);
                    float tarif = float.Parse(formMedic.tbTarif.Text);


                    Pacient p = new Pacient(nume, varsta, tarif);

                    m += p;

                    ListViewItem item = new ListViewItem(nume);
                    item.SubItems.Add(varsta.ToString());
                    item.SubItems.Add(tarif.ToString());
                    item.Tag = p;
                    lvPacienti.Items.Add(item);
                    lvPacienti.Refresh();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEditare_Click(object sender, EventArgs e) {
            if (lvPacienti.SelectedItems.Count > 0) {
                FormMedic form2 = new FormMedic();
                form2.btnAdaugaPacient.Text = "Editeaza";
                int poz;
                var itm = lvPacienti.SelectedItems[0];
                poz = itm.Index;
                form2.tbNume.Text = itm.SubItems[0].Text;
                form2.tbVarsta.Text = itm.SubItems[1].Text;
                form2.tbTarif.Text = itm.SubItems[2].Text;

                if (form2.ShowDialog() == DialogResult.OK) {

                    itm.SubItems[0].Text = form2.tbNume.Text;
                    itm.SubItems[1].Text = form2.tbVarsta.Text;
                    itm.SubItems[2].Text = form2.tbTarif.Text;

                    Pacient p = m[poz];
                    p.Nume = form2.tbNume.Text;
                    p.Varsta = Convert.ToInt32(form2.tbVarsta.Text);
                    p.Tarif_consultatie = float.Parse(form2.tbTarif.Text);
                    m[poz] = p;

                }
            }
            else {
                MessageBox.Show("Nu s-a selectat un element!");
            }
        }

        private void btnStergere_Click(object sender, EventArgs e) {
            if (lvPacienti.SelectedItems.Count > 0) {
                int poz = lvPacienti.SelectedItems[0].Index;
                m.ListaPacienti.RemoveAt(poz);
                lvPacienti.SelectedItems[0].Remove();
            }
            else {
                MessageBox.Show("Nu s-a selectat un element!");
            }
        }

        private void calculeazaVenitMedicToolStripMenuItem_Click(object sender, EventArgs e) {
            tbVenit.Text = $"Venitul medicului este: {m.calculeazaVenit()}";
        }
    }
}
