namespace subiect6 {
    public class ProgramStudiu {
        private int _codProgram;
        private string _denumireProgram;
        private int _numarLocuriBuget;
        private int _numarLocuritTaxa;

        public ProgramStudiu() {
        }

        public override string ToString() {
            return $"{CodProgram},{DenumireProgram},{NumarLocuriBuget},{NumarLocuritTaxa}";
        }

        public ProgramStudiu(int codProgram, string denumireProgram, int numarLocuriBuget, int numarLocuritTaxa) {
            _codProgram = codProgram;
            _denumireProgram = denumireProgram;
            _numarLocuriBuget = numarLocuriBuget;
            _numarLocuritTaxa = numarLocuritTaxa;
        }

        public int CodProgram {
            get => _codProgram;
            set => _codProgram = value;
        }
        public string DenumireProgram { get => _denumireProgram; set => _denumireProgram = value; }
        public int NumarLocuriBuget { get => _numarLocuriBuget; set => _numarLocuriBuget = value; }
        public int NumarLocuritTaxa { get => _numarLocuritTaxa; set => _numarLocuritTaxa = value; }

    }
}
