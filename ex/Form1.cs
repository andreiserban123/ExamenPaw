﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ex {
    public partial class Form1 : Form {
        List<Bicicleta> lstBiciclete = new List<Bicicleta>();
        List<Utilizator> lstUtilizatori = new List<Utilizator>();
        public Form1() {
            InitializeComponent();
            lstBiciclete.Add(new Bicicleta(1, "Bucuresti Gara", 120));
            lstBiciclete.Add(new Bicicleta(2, "Bucuresti MC Romana", 40));
            lstBiciclete.Add(new Bicicleta(3, "CSIE - ASE", 300));

            lstUtilizatori.Add(new Utilizator("Sabin", 1, 120));
            lstUtilizatori.Add(new Utilizator("Andrei", 1, 230));
            lstUtilizatori.Add(new Utilizator("Vlad", 2, 150));
            lstUtilizatori.Add(new Utilizator("Maria", 2, 202));
            lstUtilizatori.Add(new Utilizator("Grigore", 2, 143));
            lstUtilizatori.Add(new Utilizator("Gigel", 3, 354));

            foreach (Bicicleta b in lstBiciclete) {
                ListViewItem itm = new ListViewItem(b.CodB.ToString());
                itm.SubItems.Add(b.DenumireStatieParcare);
                itm.SubItems.Add(b.KmParcursi.ToString());

                lvBiciclete.Items.Add(itm);
            }
        }

        private void lvBiciclete_MouseClick(object sender, MouseEventArgs e) {
            if (lvBiciclete.SelectedItems.Count > 0) {
                lvUtilizatori.Items.Clear();

                float sumaIncasata = 0;
                float tarif = 0.2f;

                ListViewItem itm = lvBiciclete.SelectedItems[0];
                int codB = Convert.ToInt32(itm.SubItems[0].Text);
                Utilizator[] users = lstUtilizatori.Where(x => x.CodB == codB).ToArray();

                for (int i = 0; i < users.Length; i++) {
                    var itm2 = new ListViewItem(users[i].Nume.ToString());
                    itm2.SubItems.Add(users[i].CodB.ToString());
                    itm2.SubItems.Add(users[i].DurataUtilizare.ToString());

                    sumaIncasata += (users[i].DurataUtilizare - 30) * tarif;

                    lvUtilizatori.Items.Add(itm2);
                }
                textBox1.Text = sumaIncasata.ToString();
            }
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e) {
            GraficForm form = new GraficForm(lstBiciclete, lstUtilizatori);
            form.ShowDialog();
        }
        private string getUtilizatori(int codB) {
            string rezultat = "";

            foreach (Utilizator user in lstUtilizatori)
                if (user.CodB == codB)
                    rezultat += user.Nume + ", ";

            return rezultat;

        }

        private void pd_print(object sender, PrintPageEventArgs e) {
            Graphics gr = e.Graphics;



            string antet = "Cod                 Utilizatori";

            gr.DrawString(antet, new Font(Font.FontFamily, 20), new SolidBrush(Color.Green), e.PageBounds.X + 170, e.PageBounds.Y + 50);
            gr.DrawLine(new Pen(new SolidBrush(Color.Green)), e.PageBounds.X + 170, e.PageBounds.Y + 85, e.PageBounds.X + 730, e.PageBounds.Y + 85);


            for (int i = 0; i < lstBiciclete.Count; i++) {
                gr.DrawString(lstBiciclete[i].CodB.ToString(), new Font(Font.FontFamily, 15), new SolidBrush(Color.Green), e.PageBounds.X + 185, e.PageBounds.Y + 95 + i * 40);
                gr.DrawString(getUtilizatori(lstBiciclete[i].CodB), new Font(Font.FontFamily, 15), new SolidBrush(Color.Green), e.PageBounds.X + 355, e.PageBounds.Y + 95 + i * 40);

            }
        }

        private void printViewToolStripMenuItem_Click(object sender, EventArgs e) {

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            BinaryFormatter bf = new BinaryFormatter();
            BinaryFormatter bf2 = new BinaryFormatter();

            FileStream fs = new FileStream("utilizatori.dat", FileMode.Create, FileAccess.Write);
            FileStream fs2 = new FileStream("biciclete.dat", FileMode.Create, FileAccess.Write);

            bf.Serialize(fs, lstUtilizatori);
            bf2.Serialize(fs2, lstBiciclete);

            fs.Close();
            fs2.Close();
        }
    }
}
