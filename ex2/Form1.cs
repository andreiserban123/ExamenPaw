using ex2.Database;
using ex2.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ex2 {
    public partial class Form1 : Form {

        private CamionRepository _camionRepository = new CamionRepository();

        public Form1() {
            InitializeComponent();

            lvCamioane.CheckBoxes = true;
            lvCamioane.View = View.Details;


            lvCamioane.Columns.Add("Name");
            lvCamioane.Columns.Add("Tonaj");
            lvCamioane.Columns.Add("Id");

            camioaneDataGridView.DataSource = FakeDatabase.CamioaneBidingList;
            camioaneDataGridView.AutoGenerateColumns = true;

        }

        private void IntializeListView() {

            lvCamioane.Items.Clear();

            var camioane = _camionRepository.GetCamioane();
            foreach (var camion in camioane) {
                var item = new ListViewItem();
                item.Text = camion.Name;

                item.SubItems.Add(camion.Tonaj.ToString());
                item.SubItems.Add(camion.Id.ToString());
                lvCamioane.Items.Add(item);

            }

        }

        private void optiuniToolStripMenuItem_Click(object sender, System.EventArgs e) {
            IntializeListView();
        }

        private void btnSelectedItemsDelete_Click(object sender, System.EventArgs e) {

            var selectedItems = new List<int>();

            foreach (var item in lvCamioane.CheckedItems) {
                var listViewItem = (ListViewItem)item;
                var value = listViewItem.SubItems[2].Text;
                selectedItems.Add(int.Parse(value));
            }

            _camionRepository.StergeCamioane(selectedItems);
            IntializeListView();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var chartForm = new ChartForm();
                chartForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, System.EventArgs e) {
            var selectedItems = new List<string>();

            foreach (var item in lvCamioane.CheckedItems) {
                var listViewItem = (ListViewItem)item;
                var value = listViewItem.SubItems[1].Text;
                selectedItems.Add(value);
            }


            foreach (var item in selectedItems) {
                var productsForm = new ProductsForm();
                productsForm.Show();
            }
        }
    }
}
