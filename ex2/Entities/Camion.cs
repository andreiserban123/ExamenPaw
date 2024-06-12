using System;

namespace ex2.Entities {
    public class Camion : Vehicul, ICloneable, IComparable<Camion> {
        private int _tonaj;
        /*      private int[] _pontaj;*/
        public int Tonaj { get => _tonaj; set => _tonaj = value; }

        public Camion(int id, string nume, int tonaj) : base(id, nume) {
            Tonaj = tonaj;
        }

        public object Clone() {
            return new Camion(Id, Name, Tonaj);
        }

        public int CompareTo(Camion other) {
            return Tonaj.CompareTo(other.Tonaj);
        }
        public override string ToString() {
            return $"ID: {Id}, Name: {Name}, Tonaj:{Tonaj}";
        }
        public static int operator +(Camion a, Camion b) {
            return a.Tonaj + b.Tonaj;
        }

    }
}
