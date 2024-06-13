using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace subiect6 {
    public partial class Form1 : Form {

        public List<Candidat> candidati = new List<Candidat>();
        public List<ProgramStudiu> programeDeStudiu = new List<ProgramStudiu>();
        public Form1() {
            InitializeComponent();

            ProgramStudiu p1 = new ProgramStudiu(1, "DICE", 100, 20);
            ProgramStudiu p2 = new ProgramStudiu(2, "E-BUSINESS", 50, 5);
            ProgramStudiu p3 = new ProgramStudiu(3, "Data Science", 100, 24);
            ProgramStudiu p4 = new ProgramStudiu(4, "Informatica Economica", 200, 30);

            programeDeStudiu.Add(p1);
            programeDeStudiu.Add(p2);
            programeDeStudiu.Add(p3);
            programeDeStudiu.Add(p4);

            lbPrograme.Items.Add(p1);
            lbPrograme.Items.Add(p2);
            lbPrograme.Items.Add(p3);
            lbPrograme.Items.Add(p4);

            Candidat c1 = new Candidat(1, "Marius Popescu", 8.3f, new int[] { 1, 3 });
            Candidat c2 = new Candidat(2, "Andrei Serban", 9.0f, new int[] { 2, 4 });
            Candidat c3 = new Candidat(3, "Toma Tomescu", 7.6f, new int[] { 2, 3 });

            candidati.Add(c1);
            candidati.Add(c2);
            candidati.Add(c3);

            var it1 = new ListViewItem(new string[] {
                c1.CodCandidat.ToString(),
                c1.NumeCandidat,
                c1.MedieConcurs.ToString(),
                string.Join (",", c1.VectorOptiuni)
            });

            it1.Tag = c1;


            var it2 = new ListViewItem(new string[] {
                c2.CodCandidat.ToString(),
                c2.NumeCandidat,
                c2.MedieConcurs.ToString(),
                string.Join(",", c2.VectorOptiuni)
            });
            it2.Tag = c2;

            var it3 = new ListViewItem(new string[] {
                c3.CodCandidat.ToString(),
                c3.NumeCandidat,
                c3.MedieConcurs.ToString(),
                string.Join(",", c3.VectorOptiuni),
            });
            it3.Tag = c3;

            lvCandidati.Items.Add(it1);
            lvCandidati.Items.Add(it2);
            lvCandidati.Items.Add(it3);

        }

        private void lbPrograme_SelectedIndexChanged(object sender, System.EventArgs e) {
            if (lbPrograme.Items.Count > 0 && lvCandidati.SelectedItems.Count > 0) {
                var itm = lvCandidati.SelectedItems[0];
                Candidat cand = itm.Tag as Candidat;
                ProgramStudiu p = lbPrograme.SelectedItem as ProgramStudiu;
                /*MessageBox.Show(p.ToString());*/
                //cand.VectorOptiuni
                int cod = p.CodProgram;

                bool ok = false;

                for (int i = 0; i < cand.VectorOptiuni.Length; i++) {
                    if (cand.VectorOptiuni[i] == cod) {
                        ok = true; break;
                    }
                }
                if (!ok) {
                    int[] nou = new int[cand.VectorOptiuni.Length + 1];
                    for (int i = 0; i < nou.Length - 1; i++) {
                        nou[i] = cand.VectorOptiuni[i];
                    }
                    nou[nou.Length - 1] = cod;
                    cand.VectorOptiuni = nou;

                    itm.Tag = cand;
                    itm.SubItems[3].Text = string.Join(",", nou);
                }
            }
        }

        private void btnAdauga_Click(object sender, System.EventArgs e) {
            Candidat c = null;
            FormCandidat form = new FormCandidat(c);
            if (form.ShowDialog() == DialogResult.OK) {
                c = form.fCandidat;

                var itm = new ListViewItem(new string[] { c.CodCandidat.ToString(),
                    c.NumeCandidat,
                    c.MedieConcurs.ToString(),
                    string.Join(",", c.VectorOptiuni)
                });
                itm.Tag = c;
                lvCandidati.Items.Add(itm);
                candidati.Add(c);
            }

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            if (lvCandidati.SelectedItems.Count <= 0) {
                editareToolStripMenuItem.Enabled = false;
                stergereToolStripMenuItem.Enabled = false;
            }
            else {
                editareToolStripMenuItem.Enabled = true;
                stergereToolStripMenuItem.Enabled = true;
            }
        }

        private void editareToolStripMenuItem_Click(object sender, System.EventArgs e) {
            var it = lvCandidati.SelectedItems[0];

            Candidat c = it.Tag as Candidat;
            FormCandidat form = new FormCandidat(c);
            if (form.ShowDialog() == DialogResult.OK) {

                c = form.fCandidat;
                it.Tag = c;
                it.Text = c.CodCandidat.ToString();
                it.SubItems[1].Text = c.NumeCandidat.ToString();
                it.SubItems[2].Text = c.MedieConcurs.ToString();
                it.SubItems[3].Text = string.Join(",", c.VectorOptiuni);
            }
        }

        private void stergereToolStripMenuItem_Click(object sender, System.EventArgs e) {
            var it = lvCandidati.SelectedItems[0];
            Candidat c = it.Tag as Candidat;
            lvCandidati.SelectedItems[0].Remove();
            candidati.Remove(c);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {

                FormChart form = new FormChart(programeDeStudiu, candidati);
                form.ShowDialog();
            }
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e) {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e) {
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            string line = null;

            // Header
            Font printFont = new Font("Arial", 12, FontStyle.Bold);
            e.Graphics.DrawString("Raport Candidati", printFont, Brushes.Black, leftMargin, yPos);
            yPos += printFont.GetHeight(e.Graphics);

            // Content
            printFont = new Font("Arial", 10);
            foreach (Candidat c in candidati) {
                line = $"Nume:  {c.NumeCandidat}, Medie: {c.MedieConcurs}, Optiuni: {string.Join(",", c.VectorOptiuni)}";
                yPos += printFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos);
            }
        }
    }
}
