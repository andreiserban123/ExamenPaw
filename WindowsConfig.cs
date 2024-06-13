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
        // Citire txt
        private void btnIncarcaDinFisier_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Fișiere text|*.txt",
                Title = "Selectează fișierul cu angajați"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                angajati = CitesteAngajatiDinFisier(filePath);
                ActualizeazaListView();
            }
        }

        private List<Angajat> CitesteAngajatiDinFisier(string filePath)
        {
            List<Angajat> angajati = new List<Angajat>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string nume = parts[0];
                        DateTime dataNasterii = DateTime.Parse(parts[1]);
                        int idCompanie = int.Parse(parts[2]);

                        Angajat angajat = new Angajat(nume, dataNasterii, idCompanie);
                        angajati.Add(angajat);
                    }
                }
            }

            return angajati;
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
        // Salvare binar
        private void salvareBinaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere medic (*.med)|*.med";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                fd.FileName = "g:\\test.med";
                List<Medic> lista = new List<Medic>();
                foreach (ListViewItem lvi in lvMedici.Items)
                    lista.Add((Medic)lvi.Tag);

                //linia 1
                try
                {
                    BinaryFormatter serializator = new BinaryFormatter();
                    Stream fisier = File.Create(fd.FileName);

                    //linia 2
                    serializator.Serialize(fisier, lista);
                    fisier.Close();
                    MessageBox.Show("Lista de medici a fost serializata!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        // citire binar

        private void restaurareBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere medic (*.med)|*.med";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Medic> lista = new List<Medic>();

                Stream fisier = File.OpenRead(fd.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                lista.AddRange((List<Medic>)serializator.Deserialize(fisier));

                if (lvMedici.Items.Count > 0)
                {
                    if (MessageBox.Show("Sunt medici in lista. Doriti sa sterg lista existenta?",
                        "Intrebare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        lvMedici.Items.Clear();
                }

                foreach (Medic m in lista)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                {m.Nume,m.Cnp,m.AnAbsolvire.ToString(),
        m.Specializare,m.DataNastere.ToString()});
                    lvi.Tag = m;
                    lvMedici.Items.Add(lvi);
                }
                fisier.Close();
            }
        }

        // citire din db + insert DATABASE 
        static Random random = new Random();
        public List<Angajat> getAngajati()
        {
            List<Angajat> angajati = new List<Angajat>();
            using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=X:\\facultate\\paw\\subiect5\\db.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();


                using (var command = new SqlCommand("INSERT INTO ANGAJATI(Nume, data_nastere, id_companie) values(@n, @d, @i)", connection))
                {
                    command.Parameters.Add("n", "Bob Cat");
                    command.Parameters.Add("d", DateTime.Parse("05.03.2000"));
                    command.Parameters.Add("i", random.Next(1, 4));
                    command.ExecuteNonQuery();
                }


                using (var command = new SqlCommand("Select * from Angajati", connection))
                {

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        Angajat a = new Angajat();
                        a.Name = reader.GetString(1);
                        a.Data_nasterii = reader.GetDateTime(2);
                        a.Id_companie = reader.GetInt32(3);

                        angajati.Add(a);
                    }
                }

            }
            return angajati;
        }


        // Drag and drop

        //1. Prima oara mouseDown
        private void lvAngajati_MouseDown(object sender, MouseEventArgs e)
        {
            if (lvAngajati.SelectedItems.Count > 0)
            {
                lvAngajati.DoDragDrop((Angajat)lvAngajati.SelectedItems[0].Tag, DragDropEffects.Copy);
            }
        }
        //2. DragEnter
        private void tvAngajati_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(new Angajat().GetType().ToString()))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        //3. DragDrop
        private void tvAngajati_DragDrop(object sender, DragEventArgs e)
        {
            Point punctDinTreeview = tvAngajati.PointToClient(new Point(e.X, e.Y));
            TreeNode tn = tvAngajati.GetNodeAt(punctDinTreeview);
            if (tn != null && e.Effect == DragDropEffects.Copy && e.Data.GetDataPresent(typeof(Angajat)))
            {
                Angajat a = (Angajat)e.Data.GetData(typeof(Angajat));
                TreeNode t = new TreeNode(a.Name);
                t.Tag = a;
                tn.Nodes.Add(t);
                tn.Expand();
            }
        }

        // Grafic in constructor faci tot, ai in designer de redenumit si atat
        public ChartForm(List<Companie> companies)
        {
            InitializeComponent();
            List<Angajat> angajati = repo.getAngajati();

            var series = chartCompanii.Series.First();

            series.Name = "Nr angajati";
            foreach (var companie in companies)
            {

                int nr = angajati.FindAll(a => a.Id_companie == companie.Id).Count;

                series.Points.AddXY(companie.Name, nr);
            }
        }

    }
}