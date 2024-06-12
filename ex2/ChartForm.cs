using ex2.Repositories;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ex2 {
    public partial class ChartForm : Form {

        private CamionRepository _camionRepository = new CamionRepository();

        public ChartForm() {
            InitializeComponent();
            var camioane = _camionRepository.GetCamioane();
            /*
                        tonajChart.ChartAreas.Clear();
                        tonajChart.Series.Clear();

                        var chartArea = new ChartArea();
                        chartArea.Name = "tonajChartArea";
                        tonajChart.ChartAreas.Add(chartArea);


                        var series = new Series();
                        series.ChartArea = "tonajChartArea";
                        series.ChartType = SeriesChartType.Bar;
                        series.Name = "Tonaj";
                        tonajChart.Series.Add(series);*/

            var series = tonajChart.Series.First();
            series.ChartType = SeriesChartType.Bar;
            series.Name = "Tonaj";
            foreach (var camion in camioane) {
                series.Points.AddXY(camion.Name, camion.Tonaj);
            }
        }
    }
}
