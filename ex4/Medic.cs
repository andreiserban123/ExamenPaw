using System;
using System.Collections.Generic;
using System.Linq;

namespace ex4 {
    internal class Medic : ICalculVenitMedic {
        private string nume;
        private string specializare;
        private List<Pacient> listaPacienti;

        public Medic(string nume, string specializare) {
            this.nume = nume;
            this.specializare = specializare;
            listaPacienti = new List<Pacient>();
        }

        public string Nume { get => nume; set => nume = value; }
        public string Specializare { get => specializare; set => specializare = value; }
        public List<Pacient> ListaPacienti { get => listaPacienti; set => listaPacienti = value; }

        public override string ToString() {
            string mesaj = string.Empty;
            mesaj = $"Medicul {nume} are specializarea {specializare} si pacientii: ";
            foreach (var item in listaPacienti) {
                mesaj += $"\n {item.ToString()}";
            }
            return mesaj;
        }

        public float calculeazaVenit() {
            return listaPacienti.Sum(p => p.Tarif_consultatie);
        }

        public static Medic operator +(Medic m, Pacient p) {

            m.listaPacienti.Add(p);
            return m;
        }

        public Pacient this[int index] {
            get {
                if (index < listaPacienti.Count && index >= 0)
                    return listaPacienti[index];
                else throw new IndexOutOfRangeException();
            }
            set {
                if (index < listaPacienti.Count && index >= 0) listaPacienti[index] = value;
                else throw new IndexOutOfRangeException();
            }
        }
    }
}
