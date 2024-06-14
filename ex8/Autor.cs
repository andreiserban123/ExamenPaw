namespace ex8 {
    public class Autor {
        private int id;
        private string _nume;
        private string _grad_didactic;

        public string Nume { get => _nume; set => _nume = value; }
        public string Grad_didactic { get => _grad_didactic; set => _grad_didactic = value; }
        public int Id { get => id; set => id = value; }

        public Autor(string nume, string grad_didactic) {
            _nume = nume;
            _grad_didactic = grad_didactic;
        }

        public override string ToString() {
            return Nume;
        }

        public Autor(int id, string nume, string grad_didactic) {
            this.id = id;
            _nume = nume;
            _grad_didactic = grad_didactic;
        }
    }
}
