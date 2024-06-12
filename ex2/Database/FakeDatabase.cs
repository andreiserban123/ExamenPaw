using ex2.Entities;
using System.Collections.Generic;
using System.ComponentModel;

namespace ex2.Database {
    public class FakeDatabase {
        public static List<Camion> Camioane = new List<Camion>() {
            new Camion(1, "ABC", 12),
            new Camion(2, "Test", 30)
        };

        public static BindingList<Camion> CamioaneBidingList = new BindingList<Camion>
            () {
            new Camion(1, "ABC", 12),
            new Camion(2, "Test", 30)
        };
    }
}
