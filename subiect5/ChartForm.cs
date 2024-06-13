using subiect5.Entities;
using subiect5.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace subiect5 {
    public partial class ChartForm : Form {

        private AngajatiRepository repo = new AngajatiRepository();
        public ChartForm(List<Companie> companies) {
            InitializeComponent();
            List<Angajat> angajati = repo.getAngajati();

            var series = chartCompanii.Series.First();

            series.Name = "Nr angajati";
            foreach (var companie in companies) {

                int nr = angajati.FindAll(a => a.Id_companie == companie.Id).Count;

                series.Points.AddXY(companie.Name, nr);
            }
        }
    }
}
