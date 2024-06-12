namespace ex2.Entities {
    public abstract class Vehicul {
        public int Id { get; set; }
        public string NumarInmatriculare { get; set; }

        protected Vehicul(int id, string numarInmatriculare) {
            Id = id;
            NumarInmatriculare = numarInmatriculare;
        }
    }
}
