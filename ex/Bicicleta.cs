using System;

namespace ex {

    [Serializable]
    public class Bicicleta {
        private int codB;
        private string denumireStatieParcare;
        int kmParcursi;

        public Bicicleta() {

        }
        public Bicicleta(int codB, string denumireStatieParcare, int kmParcursi) {
            this.CodB = codB;
            this.DenumireStatieParcare = denumireStatieParcare;
            this.KmParcursi = kmParcursi;
        }

        public int CodB { get => codB; set => codB = value; }
        public string DenumireStatieParcare { get => denumireStatieParcare; set => denumireStatieParcare = value; }
        public int KmParcursi { get => kmParcursi; set => kmParcursi = value; }
    }
}
