namespace ex3 {
    public class Tranzactie : ITranzactie {
        public const int idTranzactie = 0;
        public string contIBAN;
        public string detaliiTranzactie;
        public double suma;
        public string dataTranzactie;

        Tranzactie() {

        }

        public Tranzactie(string contIBAN, string detaliiTranzactie, double suma, string dataTranzactie) {
            this.contIBAN = contIBAN;
            this.detaliiTranzactie = detaliiTranzactie;
            this.suma = suma;
            this.dataTranzactie = dataTranzactie;
        }

        public void afisareTranzactie() {
            System.Console.WriteLine(ToString());
        }

        public override string ToString() {
            return idTranzactie + " " + contIBAN + " " + detaliiTranzactie
                + " " + suma + " " + dataTranzactie;
        }
    }
}
