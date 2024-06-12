using System.Collections.Generic;

namespace ex2.Entities {
    public class ParcAuto {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Camion> Trucks { get; set; }

    }
}
