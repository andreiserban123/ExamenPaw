namespace ex4 {
    internal class Pacient {
        string nume;
        int varsta;
        float tarif_consultatie;

        public Pacient(string nume, int varsta, float tarif_consultatie) {
            this.nume = nume;
            this.varsta = varsta;
            this.tarif_consultatie = tarif_consultatie;
        }

        public string Nume { get => nume; set => nume = value; }
        public int Varsta { get => varsta; set => varsta = value; }
        public float Tarif_consultatie { get => tarif_consultatie; set => tarif_consultatie = value; }

        public override string ToString() {
            return "Pacientul " + nume + "in varsta de " + varsta + " plateste " + tarif_consultatie;
        }
    }
}
