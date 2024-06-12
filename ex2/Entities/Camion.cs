using System;

namespace ex2.Entities {
    public class Camion : Vehicul, IComparable<Camion>, ICloneable {
        public string Marca { get; set; }
        public string Model { get; set; }

        public Camion(int id, string numarInmatriculare, string marca, string model) : base(id, numarInmatriculare) {
            Marca = marca;
            Model = model;
        }

        public int CompareTo(Camion other) {
            if (Model.Length < other.Model.Length) return -1;
            if (Model.Length > other.Model.Length) return 1;
            return 0;
        }

        public object Clone() {
            return new Camion(Id, NumarInmatriculare, Marca, Model);
        }
    }
}
