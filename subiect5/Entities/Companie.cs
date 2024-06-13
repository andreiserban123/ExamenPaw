using System;
using System.Collections.Generic;

namespace subiect5.Entities {
    [Serializable]
    public class Companie {
        private int _id;
        private string _name;
        private List<Angajat> _angajati;


        public Companie(int id, string name) {
            _id = id;
            _name = name;
            Angajati = new List<Angajat>();
        }

        public Companie() {
            Angajati = new List<Angajat>();
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public List<Angajat> Angajati { get => _angajati; set => _angajati = value; }
    }
}
