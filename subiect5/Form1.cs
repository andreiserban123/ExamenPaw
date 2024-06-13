using subiect5.Entities;
using subiect5.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace subiect5 {
    public partial class Form1 : Form {

        public List<Companie> companies = new List<Companie>();

        private AngajatiRepository repo = new AngajatiRepository();

        public Form1() {
            InitializeComponent();
            Companie c1 = new Companie(1, "Amazon");
            Companie c2 = new Companie(2, "Microsoft");
            Companie c3 = new Companie(3, "Netflix");
            companies.Add(c1);
            companies.Add(c2);
            companies.Add(c3);

            lvCompanii.Items.Clear();

            foreach (Companie c in companies) {

                ListViewItem item = new ListViewItem(new string[] { c.Id.ToString(), c.Name });
                lvCompanii.Items.Add(item);
                item.Tag = c;
            }

            /*   Angajat angajat = new Angajat("Dorel Georgescu", DateTime.Parse("02.05,2002"), 1);
               Angajat angajat2 = new Angajat("Francesco Bernouli", DateTime.Parse("02.05,2002"), 2);
               Angajat angajat3 = new Angajat("Iosif Stalin", DateTime.Parse("03.04.1903"), 2);
               c1.Angajati.Add(angajat);
               c2.Angajati.Add(angajat2);
               c2.Angajati.Add(angajat3);*/

            List<Angajat> angajati = repo.getAngajati();

            foreach (var angajat in angajati) {
                var com = companies.Find(c => c.Id == angajat.Id_companie);
                com.Angajati.Add(angajat);
            }


            foreach (var companie in companies) {

                TreeNode treeNode = new TreeNode();
                treeNode.Tag = companie;
                treeNode.Text = companie.Name;
                tvAngajati.Nodes.Add(treeNode);
            }
        }

        private void btnAdaugaAngj_Click(object sender, System.EventArgs e) {

            Angajat angj = null;
            FormAngajat form = new FormAngajat(angj, companies);
            if (form.ShowDialog() == DialogResult.OK) {

                angj = form.cAngajat;
                foreach (Companie c in companies) {
                    if (c.Id == angj.Id_companie) {
                        c.Angajati.Add(angj);
                    }
                }
                MessageBox.Show("Angajat adaugat");
            }
        }

        private void lvCompanii_SelectedIndexChanged(object sender, System.EventArgs e) {

            if (lvCompanii.SelectedItems.Count > 0) {

                lvAngajati.Items.Clear();
                var itm = lvCompanii.SelectedItems[0];
                var c = itm.Tag as Companie;
                foreach (var angj in c.Angajati) {

                    ListViewItem item = new ListViewItem(new string[] {
                        angj.Name,
                        angj.Data_nasterii.ToString("d")
                    });
                    item.Tag = angj;
                    lvAngajati.Items.Add(item);
                }
            }
        }

        private void lvAngajati_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lvAngajati.SelectedItems.Count > 0) {
                FormAngajat formAngajat = new FormAngajat(lvAngajati.SelectedItems[0].Tag as Angajat, companies);
                if (formAngajat.ShowDialog() == DialogResult.OK) {
                    var angj = formAngajat.cAngajat;
                    foreach (Companie c in companies) {
                        if (c.Id == angj.Id_companie) {
                            c.Angajati.Add(angj);
                        }
                    }
                    MessageBox.Show("Angajat modificat");
                }
            }
            else {
                MessageBox.Show("te rog selecteaza un angajat pentru a putea edita ");
            }
        }

        private void stergeAngajatToolStripMenuItem_Click(object sender, EventArgs e) {
            if (lvAngajati.SelectedItems.Count == 1) {

                var angj = lvAngajati.SelectedItems[0].Tag as Angajat;
                foreach (Companie c in companies) {
                    if (c.Id == angj.Id_companie) {
                        c.Angajati.Remove(angj);
                    }
                }
                lvAngajati.Items.Remove(lvAngajati.SelectedItems[0]);
            }
            else {
                MessageBox.Show("Sterge cate un angajat pe rand!");
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            if (lvAngajati.Items.Count <= 0) {
                stergeAngajatToolStripMenuItem.Enabled = false;
            }
            else {
                stergeAngajatToolStripMenuItem.Enabled = true;
            }
        }

        private void salvareXMLToolStripMenuItem_Click_1(object sender, EventArgs e) {
            List<Angajat> angajati = new List<Angajat>();

            foreach (var comp in companies) {
                foreach (var angj in comp.Angajati) {
                    angajati.Add(angj);
                }
            }

            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "|*.xml";

            if (fd.ShowDialog() == DialogResult.OK) {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Angajat>));
                serializer.Serialize(File.Create(fd.FileName), angajati);

                MessageBox.Show("Au fost serializati cu success!");
            }
        }

        private void restaurareXMLToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();

            if (
                MessageBox.Show("Esti sigur ca vrei sa continui, toti angajatii vor fi inlocuiti", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK) {

                foreach (var comp in companies) {
                    comp.Angajati.Clear();
                }

                fd.Filter = "|*.xml";
                fd.CheckFileExists = true;
                if (fd.ShowDialog() == DialogResult.OK) {
                    List<Angajat> angajati = new List<Angajat>();
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Angajat>));
                    var fisier = File.OpenRead(fd.FileName);
                    angajati = (List<Angajat>)serializer.Deserialize(fisier);

                    foreach (var angj in angajati) {
                        foreach (var comp in companies) {
                            if (comp.Id == angj.Id_companie) {
                                comp.Angajati.Add(angj);
                            }
                        }
                    }
                }
            }
        }

        private void salvareBinarToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog fd = new SaveFileDialog();

            fd.Filter = "|*.bin";

            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK) {
                List<Angajat> angajati = new List<Angajat>();

                foreach (var comp in companies) {
                    foreach (var angj in comp.Angajati) {
                        angajati.Add(angj);
                    }
                }

                try {
                    BinaryFormatter serializator = new BinaryFormatter();
                    var f = File.Create(fd.FileName);
                    serializator.Serialize(f, angajati);

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void restaurareBinarToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "|*.bin";

            if (fd.ShowDialog() == DialogResult.OK) {
                if (MessageBox.Show("Esti sigur ca vrei sa continui, toti angajatii vor fi inlocuiti", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    foreach (var comp in companies) {
                        comp.Angajati.Clear();
                    }
                    List<Angajat> angajati = new List<Angajat>();
                    BinaryFormatter serializator = new BinaryFormatter();
                    Stream fisier = File.OpenRead(fd.FileName);

                    angajati = (List<Angajat>)serializator.Deserialize(fisier);

                    foreach (var angj in angajati) {
                        foreach (var comp in companies) {
                            if (comp.Id == angj.Id_companie) {
                                comp.Angajati.Add(angj);
                            }
                        }
                    }
                }
            }
        }

        private void lvAngajati_MouseDown(object sender, MouseEventArgs e) {
            if (lvAngajati.SelectedItems.Count > 0) {
                lvAngajati.DoDragDrop((Angajat)lvAngajati.SelectedItems[0].Tag, DragDropEffects.Copy);
            }
        }

        private void tvAngajati_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(new Angajat().GetType().ToString()))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void tvAngajati_DragDrop(object sender, DragEventArgs e) {
            Point punctDinTreeview = tvAngajati.PointToClient(new Point(e.X, e.Y));
            TreeNode tn = tvAngajati.GetNodeAt(punctDinTreeview);
            if (tn != null && e.Effect == DragDropEffects.Copy && e.Data.GetDataPresent(typeof(Angajat))) {
                Angajat a = (Angajat)e.Data.GetData(typeof(Angajat));
                TreeNode t = new TreeNode(a.Name);
                t.Tag = a;
                tn.Nodes.Add(t);
                tn.Expand();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'dbDataSet.Angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.dbDataSet.Angajati);

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {

                var chartForm = new ChartForm(companies);
                chartForm.ShowDialog();
            }
        }
    }
}
