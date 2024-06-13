//

namespace exam
{
    public class Cheatsheet
    {
        // Error provider trebuie sa pui mai intai in programul principal Error provider din toolbox
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

    }
}