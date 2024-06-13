namespace ex3 {
    public class Tranzactie {
        public readonly int idTranzactie;
        public string contIban;
        public string detaliiTranzactie;
        public double suma;
        public string dataTranzactie;

        public Tranzactie(int idTranzactie, string contIban, string detaliiTranzactie, double suma, string dataTranzactie) {
            this.idTranzactie = idTranzactie;
            this.contIban = contIban;
            this.detaliiTranzactie = detaliiTranzactie;
            this.suma = suma;
            this.dataTranzactie = dataTranzactie;
        }

        public override string ToString() {
            return $"{idTranzactie} - {contIban} - {detaliiTranzactie} - {suma} - {dataTranzactie}";
        }
    }
}
