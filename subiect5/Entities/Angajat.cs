using System;

namespace subiect5.Entities {

    [Serializable]
    public class Angajat {
        private string _name;
        private DateTime _data_nasterii;
        private int _id_companie;

        public string Name { get => _name; set => _name = value; }
        public DateTime Data_nasterii { get => _data_nasterii; set => _data_nasterii = value; }
        public int Id_companie { get => _id_companie; set => _id_companie = value; }

        public Angajat(string name, DateTime data_nasterii, int id_companie) {
            _name = name;
            _data_nasterii = data_nasterii;
            _id_companie = id_companie;
        }

        public Angajat() {
        }

        public static explicit operator bool(Angajat angajat) {
            return angajat.Id_companie < 0;
        }
    }
}
