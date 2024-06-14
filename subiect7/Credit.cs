using System;
using System.Collections.Generic;

namespace subiect7 {
    public delegate double[] AlgoritmDesfasurator(Credit credit);
    public class Credit {
        public string Client { get; set; }
        public double ValoareCredit { get; set; }
        public double Dobanda { get; set; }
        public DateTime DataAcordarii { get; set; }
        public int Perioada { get; set; }
        public AlgoritmDesfasurator AlgoritmDes { get; set; }
        public Credit() {
        }

        public Credit(string client, double valoareCredit, double dobanda, DateTime dataAcordarii, int perioada) {
            Client = client;
            ValoareCredit = valoareCredit;
            Dobanda = dobanda;
            DataAcordarii = dataAcordarii;
            Perioada = perioada;
        }

        public double[] CalculDesfasurator() {
            if (AlgoritmDes != null) {
                return AlgoritmDes(this);
            }
            else {
                throw new InvalidOperationException("Algoritm nespecificat pentru calcul desfasurator.");
            }
        }

        public override string ToString() {
            return $"{Client}, {ValoareCredit} lei, {Dobanda}% dobândă, acordat la {DataAcordarii.ToShortDateString()}, pe o perioadă de {Perioada} luni";
        }

        public override bool Equals(object obj) {
            return obj is Credit credit &&
                   Client == credit.Client &&
                   ValoareCredit == credit.ValoareCredit &&
                   Dobanda == credit.Dobanda &&
                   DataAcordarii == credit.DataAcordarii &&
                   Perioada == credit.Perioada;
        }

        public override int GetHashCode() {
            int hashCode = -1267479131;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Client);
            hashCode = hashCode * -1521134295 + ValoareCredit.GetHashCode();
            hashCode = hashCode * -1521134295 + Dobanda.GetHashCode();
            hashCode = hashCode * -1521134295 + DataAcordarii.GetHashCode();
            hashCode = hashCode * -1521134295 + Perioada.GetHashCode();
            return hashCode;
        }
    }
}
