namespace ex2.Entities {
    public class Autoturism : Vehicul {
        private string culoare;
        private double[] greutatePeRoata;

        public Autoturism(int id, string nrImatriculare, string culoare, double[] greutatePeRoata)
            : base(id, nrImatriculare) {
            this.culoare = culoare;
            this.greutatePeRoata = greutatePeRoata;
        }
        public string Culoare { get => culoare; set => culoare = value; }
        public double[] GreutatePeRoata { get => greutatePeRoata; set => greutatePeRoata = value; }

        public static Autoturism operator +(Autoturism autoturism, double greutate) {
            double[] newGreutatePeRoate = new double[autoturism.GreutatePeRoata.Length + 1];
            autoturism.greutatePeRoata.CopyTo(newGreutatePeRoate, 0);
            newGreutatePeRoate[newGreutatePeRoate.Length - 1] = greutate;
            return new Autoturism(autoturism.Id, autoturism.NumarInmatriculare, autoturism.culoare, newGreutatePeRoate);
        }

        public static explicit operator double(Autoturism autoturism) {
            if (autoturism.greutatePeRoata.Length == 0) {
                return 0;
            }
            return autoturism.GreutatePeRoata.Average();
        }

    }
}
