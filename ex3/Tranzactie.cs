using System;

namespace ex3 {
    public class Tranzactie {
        public readonly int idTranzactie;
        public String contIban;
        public String detaliiTranzactie;
        public double suma;
        public String dataTranzactie;

        public String ContIban {
            get { return contIban; }
            set { contIban = value; }
        }
        public String ContDetalii { get; set; }
        public String DetaliiTranzactie { get; set; }
        public double Suma { get; set; }
        public String DataTranzactiei { get; set; }

        public Tranzactie() { }

        public Tranzactie(int idTranzactie, String contIban, String detaliiTranzactie, double suma, String dataTranzactiei) {
            this.idTranzactie = idTranzactie;
            this.contIban = contIban;
            this.detaliiTranzactie = detaliiTranzactie;
            this.suma = suma;
            this.dataTranzactie = dataTranzactie;
        }

        public String ToString() {
            return this.idTranzactie.ToString();
        }
    }
}