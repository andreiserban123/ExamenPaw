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




    }
}