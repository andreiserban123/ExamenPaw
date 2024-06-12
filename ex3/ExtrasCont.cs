using System.Collections.Generic;
using System.Linq;

namespace ex3 {
    public class ExtrasCont {
        private string numeClient;
        private string adresa;
        List<Tranzactie> tranzactii;

        public ExtrasCont(string numeClient, string adresa, List<Tranzactie> tranzactii) {
            this.NumeClient = numeClient;
            this.Adresa = adresa;
            this.Tranzactii = tranzactii;
        }

        public string NumeClient { get => numeClient; set => numeClient = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public List<Tranzactie> Tranzactii { get => tranzactii; set => tranzactii = value; }

        public static explicit operator double(ExtrasCont extrasCont) {
            if (extrasCont.tranzactii.Count == 0) return 0;
            double sumaTotala = extrasCont.tranzactii.Sum(t => t.suma);
            return sumaTotala;
        }

        public static implicit operator int(ExtrasCont extrasCont) {
            return extrasCont.tranzactii.Count;
        }

    }
}
