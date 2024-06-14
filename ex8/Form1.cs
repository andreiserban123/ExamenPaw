using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ex8 {
    public partial class Form1 : Form {


        public List<Carte> publicatii = new List<Carte>();
        public List<Autor> autori = new List<Autor>();



        public Form1() {
            InitializeComponent();

            // Generarea obiectelor Carte
            Carte c1 = new Carte("Moara cu Noroc", 12.3, "Crime and mistery", "9781234567897");
            Carte c2 = new Carte("Ion", 15.0, "Drama", "9781234567898");
            Carte c3 = new Carte("Enigma Otiliei", 18.5, "Fiction", "9781234567899");
            Carte c4 = new Carte("Mara", 20.1, "Historical Fiction", "9781234567800");
            Carte c5 = new Carte("Ultima noapte de dragoste, întâia noapte de război", 25.0, "Romance", "9781234567801");
            Carte c6 = new Carte("Baltagul", 14.3, "Adventure", "9781234567802");

            publicatii.Add(c1);
            publicatii.Add(c2);
            publicatii.Add(c3);
            publicatii.Add(c4);
            publicatii.Add(c5);
            publicatii.Add(c6);

            // Adăugarea cărților în ListView
            var items = new List<ListViewItem>
            {
                new ListViewItem(new string[] { c1.Titlu, c1.Pret.ToString(), c1.ISBN, c1.Categorie }) { Tag = c1 },
                new ListViewItem(new string[] { c2.Titlu, c2.Pret.ToString(), c2.ISBN, c2.Categorie }) { Tag = c2 },
                new ListViewItem(new string[] { c3.Titlu, c3.Pret.ToString(), c3.ISBN, c3.Categorie }) { Tag = c3 },
                new ListViewItem(new string[] { c4.Titlu, c4.Pret.ToString(), c4.ISBN, c4.Categorie }) { Tag = c4 },
                new ListViewItem(new string[] { c5.Titlu, c5.Pret.ToString(), c5.ISBN, c5.Categorie }) { Tag = c5 },
                new ListViewItem(new string[] { c6.Titlu, c6.Pret.ToString(), c6.ISBN, c6.Categorie }) { Tag = c6 }
             };

            lvCarti.Items.AddRange(items.ToArray());

            Autor a1 = new Autor("Mihai Eminescu", "Conferentiar");
            Autor a2 = new Autor("Ion Creangă", "Profesor");
            Autor a3 = new Autor("Liviu Rebreanu", "Profesor");
            Autor a4 = new Autor("George Călinescu", "Conferentiar");
            Autor a5 = new Autor("Tudor Arghezi", "Profesor");
            Autor a6 = new Autor("Mircea Eliade", "Profesor");

            var autorItems = new List<ListViewItem>
            {
                new ListViewItem(new string[] { a1.Nume, a1.Grad_didactic }) { Tag = a1 },
                new ListViewItem(new string[] { a2.Nume, a2.Grad_didactic }) { Tag = a2 },
                new ListViewItem(new string[] { a3.Nume, a3.Grad_didactic }) { Tag = a3 },
                new ListViewItem(new string[] { a4.Nume, a4.Grad_didactic }) { Tag = a4 },
                new ListViewItem(new string[] { a5.Nume, a5.Grad_didactic }) { Tag = a5 },
                new ListViewItem(new string[] { a6.Nume, a6.Grad_didactic }) { Tag = a6 }
            };

            c1.Autori.Add(a1);
            c1.Autori.Add(a2);
            c2.Autori.Add(a3);
            c3.Autori.Add(a4);
            c4.Autori.Add(a5);
            c5.Autori.Add(a6);
            c6.Autori.Add(a1);
            c6.Autori.Add(a2);

            lvAutori.Items.AddRange(autorItems.ToArray());

            autori.Add(a1);
            autori.Add(a2);
            autori.Add(a3);
            autori.Add(a4);
            autori.Add(a5);
            autori.Add(a6);


        }

        private void adaugaManualToolStripMenuItem_Click(object sender, System.EventArgs e) {
            Carte c = null;
            FormCarte form = new FormCarte(c);
            if (form.ShowDialog() == DialogResult.OK) {
                c = form.fCarte;
                publicatii.Add(c);
                var it = new ListViewItem(new string[] {
                    c.Titlu,
                    c.Pret.ToString(),
                    c.ISBN,
                    c.Categorie
                });
                it.Tag = c;
                lvCarti.Items.Add(it);


            }

        }

        private void lvCarti_ColumnClick(object sender, ColumnClickEventArgs e) {
            SortOrder sortOrder = lvCarti.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;

            // Setează sortatorul pentru ListView
            lvCarti.ListViewItemSorter = new ListViewItemComparer(e.Column, sortOrder);

            // Actualizează direcția sortării
            lvCarti.Sorting = sortOrder;
            lvCarti.Sort();
        }

        private void lvCarti_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvCarti.SelectedItems.Count > 0) {
                var carte = lvCarti.SelectedItems[0].Tag as Carte;
                tbAutori.Text = string.Join(",", carte.Autori);
            }
        }
    }
    public class ListViewItemComparer : IComparer {
        private int col;
        private SortOrder order;

        public ListViewItemComparer() {
            col = 0;
            order = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order) {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y) {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            if (order == SortOrder.Descending)
                returnVal *= -1;
            return returnVal;
        }
    }
}
