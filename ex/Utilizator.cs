using System;

namespace ex {
    [Serializable]
    public class Utilizator {
        private string nume;
        private int codB;
        private int durataUtilizare;

        public Utilizator() {

        }
        public Utilizator(string nume, int codB, int durataUtilizare) {
            this.Nume = nume;
            this.CodB = codB;
            this.DurataUtilizare = durataUtilizare;
        }

        public string Nume { get => nume; set => nume = value; }
        public int CodB { get => codB; set => codB = value; }
        public int DurataUtilizare { get => durataUtilizare; set => durataUtilizare = value; }
    }
}
