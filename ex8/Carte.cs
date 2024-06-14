using System.Collections.Generic;

namespace ex8 {
    public class Carte : Publicatie {

        private readonly string _ISBN;
        private string _categorie;
        private List<Autor> _autori;

        public Carte(string titlu, double pret, string categorie, string ISBN) : base(titlu, pret) {
            _categorie = categorie;
            _autori = new List<Autor>();
            _ISBN = ISBN;
        }

        public string Categorie { get => _categorie; set => _categorie = value; }
        public List<Autor> Autori { get => _autori; set => _autori = value; }

        public string ISBN => _ISBN;

        public override string genereazaReferinta() {
            return string.Join(",", _autori) + " - " + Titlu + "," + ISBN;
        }
    }
}
