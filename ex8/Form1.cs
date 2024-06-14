using System;
using System.Windows.Forms;

namespace ex8 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            IsMdiContainer = true; // Setăm fereastra principală ca MDI container
        }


        private void openChildFormToolStripMenuItem_Click_1(object sender, EventArgs e) {
            ChildForm childForm = new ChildForm();
            childForm.MdiParent = this; // Setăm fereastra principală ca părinte
            childForm.Show();
        }
    }
}
