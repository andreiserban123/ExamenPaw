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

        //operator de indexare
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= vectorOptiuni.Length)
                {
                    throw new IndexOutOfRangeException("Indexul este în afara limitelor.");
                }
                return vectorOptiuni[index];
            }
            set
            {
                if (index < 0 || index >= vectorOptiuni.Length)
                {
                    throw new IndexOutOfRangeException("Indexul este în afara limitelor.");
                }
                vectorOptiuni[index] = value;
            }
        }

        //operator plus
        public static Candidat operator +(Candidat c, int optiuneNoua)
        {
            int[] vectorNou = new int[c.vectorOptiuni.Length + 1];
            for (int i = 0; i < c.vectorOptiuni.Length; i++)
            {
                vectorNou[i] = c.vectorOptiuni[i];
            }
            vectorNou[c.vectorOptiuni.Length] = optiuneNoua;
            c.vectorOptiuni = vectorNou;
            return c;
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

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "date.txt"); // necesar decat daca citesti din root
        private void CitireTxt()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "|*.txt";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(fd.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
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

        // citire din db + insert DATABASE bd
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

                        // index de la 0
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
            series.ChartType = SeriesChartType.Bar;
            series.Name = "Nr angajati";
            foreach (var companie in companies)
            {

                int nr = angajati.FindAll(a => a.Id_companie == companie.Id).Count;

                series.Points.AddXY(companie.Name, nr);
            }
        }
        //Pentru printat document
        // 1. printPreviewDialog pe form        
        // 2. printDocument tot pe form
        // 3. La print previewDialog selectezi atribut document cel de la 2
        // 4. Dupa apesi pe ceva buton sau trigger pentru a lansa  printPreviewDialog1.ShowDialog();
        // 5. Pe printDocument1 ai eventul PrintPage acolo scrii codul de generare foaie
        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            string line = null;

            // Header
            Font printFont = new Font("Arial", 12, FontStyle.Bold);
            e.Graphics.DrawString("Raport Candidati", printFont, Brushes.Black, leftMargin, yPos);
            yPos += printFont.GetHeight(e.Graphics);

            // Content
            printFont = new Font("Arial", 10);
            foreach (Candidat c in candidati)
            {
                line = $"Nume:  {c.NumeCandidat}, Medie: {c.MedieConcurs}, Optiuni: {string.Join(",", c.VectorOptiuni)}";
                yPos += printFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos);
            }

        }

        //delegate
        public delegate double[] AlgoritmDesfasurator(Credit credit);

        public class Algoritmi
        {
            // Metoda 1: Plată fixă pe lună
            public static double[] DesfasuratorRateDescrescatoare(Credit credit)
            {
                int n = credit.Perioada;
                double[] platiLunare = new double[n];
                double sumaRamas = credit.ValoareCredit;
                double principalPlatit = credit.ValoareCredit / n;

                for (int i = 0; i < n; i++)
                {
                    double dobandaLunara = sumaRamas * (credit.Dobanda / 100) / 12;
                    platiLunare[i] = principalPlatit + dobandaLunara;
                    sumaRamas -= principalPlatit;
                }

                return platiLunare;
            }

            // Metoda 2: Desfasurator Rate Constante
            public static double[] DesfasuratorRateConstante(Credit credit)
            {
                int n = credit.Perioada;
                double[] platiLunare = new double[n];
                double dobandaTotala = credit.ValoareCredit * (credit.Dobanda / 100) * (credit.Perioada / 12);
                double valoareTotala = credit.ValoareCredit + dobandaTotala;
                double plataLunara = valoareTotala / n;

                for (int i = 0; i < n; i++)
                {
                    platiLunare[i] = plataLunara;
                }

                return platiLunare;
            }


        }
        public class Credit
        {
            public string Client { get; set; }
            public double ValoareCredit { get; set; }
            public double Dobanda { get; set; }
            public DateTime DataAcordarii { get; set; }
            public int Perioada { get; set; }
            public AlgoritmDesfasurator AlgoritmDes { get; set; }
            public double[] CalculDesfasurator()
            {
                if (AlgoritmDes != null)
                {
                    return AlgoritmDes(this);
                }
                else
                {
                    throw new InvalidOperationException("Algoritm nespecificat pentru calcul desfasurator.");
                }
            }
        }
        //setez efectiv
        fCredit.AlgoritmDes = Algoritmi.DesfasuratorRateDescrescatoare;
        fCredit.AlgoritmDes = Algoritmi.DesfasuratorRateConstante;



        //DataGridView 
        BindingList<Credit> credite = new BindingList<Credit>()
         {
         new Credit("Marcel Ionut", 20000, 3, DateTime.Parse("2003-03-12"), 10),
         new Credit("Ion Popescu", 50000, 5, DateTime.Parse("2010-07-15"), 8),
         new Credit("Maria Ionescu", 100000, 10, DateTime.Parse("2015-09-01"), 7),
         new Credit("Ana Georgescu", 75000, 7, DateTime.Parse("2018-01-20"), 6)
         };


        public Form1()
        {
            InitializeComponent();
            dgvCredite.DataSource = credite;
            dgvCredite.AutoGenerateColumns = true;

        }

        // Clipboard 


        // deschide meniuContextual si copiaza nume medic
        private void copiazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvMedici.SelectedItems.Count > 0)
            {
                Clipboard.SetText((lvMedici.SelectedItems[0].Tag as Medic).Nume);

            }
        }


        // Este event Keypress atunci adauga continutul Clipboard
        private void lbMedici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                lbMedici.Items.Add(Clipboard.GetText());
            }
        }
    }
}