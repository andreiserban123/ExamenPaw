namespace subiect6 {
    public class Candidat {

        private int _codCandidat;
        private string _numeCandidat;
        private float _medieConcurs;
        private int[] _vectorOptiuni;


        public Candidat() {
        }

        public Candidat(int codCandidat, string numeCandidat, float medieConcurs, int[] vectorOptiuni) {
            CodCandidat = codCandidat;
            NumeCandidat = numeCandidat;
            MedieConcurs = medieConcurs;
            VectorOptiuni = vectorOptiuni;
        }

        public int CodCandidat { get => _codCandidat; set => _codCandidat = value; }
        public string NumeCandidat { get => _numeCandidat; set => _numeCandidat = value; }
        public float MedieConcurs { get => _medieConcurs; set => _medieConcurs = value; }
        public int[] VectorOptiuni {
            get => _vectorOptiuni; set => _vectorOptiuni = value;
        }

        public override string ToString() {
            return $"{CodCandidat},{NumeCandidat}, {MedieConcurs}";
        }
    }
}
