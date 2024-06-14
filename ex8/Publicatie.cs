namespace ex8 {
    public abstract class Publicatie {
        private string _titlu;
        private double _pret;

        public Publicatie(string titlu, double pret) {
            _titlu = titlu;
            _pret = pret;
        }

        // Proprietăți pentru accesarea câmpurilor private
        public string Titlu {
            get { return _titlu; }
            set { _titlu = value; }
        }

        public double Pret {
            get { return _pret; }
            set { _pret = value; }
        }
        public abstract string genereazaReferinta();
    }
}
