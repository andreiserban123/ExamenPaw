namespace ex2.Entities {
    public abstract class Vehicul {
        private int _id;
        private string _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        protected Vehicul(int id, string name) {
            _id = id;
            _name = name;
        }
    }
}
