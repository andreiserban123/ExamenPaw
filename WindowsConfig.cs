namespace exam
{
    public class WindowsConfig
    {
        // Error provider trebuie sa pui mai intai in programul principal Error provider din toolbox
        //Event: validating pe campul pe care faci validarea
        private void tbAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (tbAdresa.Text.Length < 8)
            {
                errorProviderAn.SetError(tbAdresa, "Adresa este prea scurta!");
                e.Cancel = true;
            }
            else
            {
                errorProviderAn.SetError(tbAdresa, "");
            }
        }
        // supraincarcare operatori

        // operator de conversie int 
        public static explicit operator int(ExtrasCont extrasCont)
        {
            int nrTranzactii = 0;
            foreach (Tranzactie tranzactie in extrasCont.tranzactii)
            {
                nrTranzactii++;
            }
            return nrTranzactii;
        }
        // Scriere in txt
        private void salvareTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Fisiere txt: extrase cont |*.txt";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter sw = new StreamWriter(fd.FileName))
                {
                    foreach (var extras in extrase)
                    {
                        sw.WriteLine(extras.numeClient + " " + extras.adresa);
                        foreach (var tranz in extras.tranzactii)
                        {
                            sw.WriteLine("\t\t" + tranz);
                        }
                    }

                    MessageBox.Show("Scrierea s-a realizat cu success!");
                }
            }
        }
        // xml salvare
        private void salvareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere XM: extrase cont | *.xml";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<ExtrasCont> listaLV = new List<ExtrasCont>();
                foreach (ListViewItem item in lvExtraseCont.Items)
                {
                    listaLV.Add(item.Tag as ExtrasCont);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<ExtrasCont>));
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, listaLV);
                fisier.Close();
            }
        }

        // xml restaureare
        private void restaurareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisere XML estras cont | *.xml";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<ExtrasCont> listaFisier = new List<ExtrasCont>();
                XmlSerializer serializer = new XmlSerializer(typeof(List<ExtrasCont>));
                Stream fiser = File.OpenRead(fd.FileName);
                listaFisier = (List<ExtrasCont>)serializer.Deserialize(fiser);

                if (lvExtraseCont.Items.Count > 0)
                {
                    if (MessageBox.Show("Vrei sa stergi extrasele existente?",
                        "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lvExtraseCont.Items.Clear();
                    }
                }

                foreach (ExtrasCont extras in listaFisier)
                {
                    String tranzactii = "";
                    foreach (Tranzactie tranzactie in extras.tranzactii)
                    {
                        tranzactii += " " + tranzactie.idTranzactie;
                    }

                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        extras.numeClient, extras.adresa, tranzactii
                    });
                    lvi.Tag = extras;
                    lvExtraseCont.Items.Add(lvi);
                }
            }
        }

    }
}