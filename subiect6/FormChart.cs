using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace subiect6 {
    public partial class FormChart : Form {
        public FormChart(List<ProgramStudiu> progrem, List<Candidat> candidati) {
            InitializeComponent();

            var series = chPrograme.Series.First();
            series.ChartType = SeriesChartType.Bar;
            series.Name = "Nr de studenti";
            foreach (var program in progrem) {
                int nr = 0;
                foreach (var candidat in candidati) {
                    for (int i = 0; i < candidat.VectorOptiuni.Length; i++) {
                        if (candidat.VectorOptiuni[i] == program.CodProgram) { nr++; }
                    }
                }
                series.Points.AddXY(program.DenumireProgram, nr);
            }
        }
    }
}
