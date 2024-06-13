namespace subiect5 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lvCompanii = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAngajati = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeAngajatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdaugaAngj = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvAngajati = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbDataSet = new subiect5.dbDataSet();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angajatiTableAdapter = new subiect5.dbDataSetTableAdapters.AngajatiTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanastereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcompanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lvCompanii
            // 
            this.lvCompanii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvCompanii.FullRowSelect = true;
            this.lvCompanii.HideSelection = false;
            this.lvCompanii.Location = new System.Drawing.Point(40, 69);
            this.lvCompanii.Name = "lvCompanii";
            this.lvCompanii.Size = new System.Drawing.Size(199, 256);
            this.lvCompanii.TabIndex = 0;
            this.lvCompanii.UseCompatibleStateImageBehavior = false;
            this.lvCompanii.View = System.Windows.Forms.View.Details;
            this.lvCompanii.SelectedIndexChanged += new System.EventHandler(this.lvCompanii_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume";
            // 
            // lvAngajati
            // 
            this.lvAngajati.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvAngajati.ContextMenuStrip = this.contextMenuStrip1;
            this.lvAngajati.FullRowSelect = true;
            this.lvAngajati.HideSelection = false;
            this.lvAngajati.Location = new System.Drawing.Point(490, 69);
            this.lvAngajati.Name = "lvAngajati";
            this.lvAngajati.Size = new System.Drawing.Size(414, 256);
            this.lvAngajati.TabIndex = 1;
            this.lvAngajati.UseCompatibleStateImageBehavior = false;
            this.lvAngajati.View = System.Windows.Forms.View.Details;
            this.lvAngajati.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAngajati_MouseDoubleClick);
            this.lvAngajati.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvAngajati_MouseDown);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nume";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DataNast";
            this.columnHeader4.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeAngajatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 36);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // stergeAngajatToolStripMenuItem
            // 
            this.stergeAngajatToolStripMenuItem.Name = "stergeAngajatToolStripMenuItem";
            this.stergeAngajatToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.stergeAngajatToolStripMenuItem.Text = "Sterge Angajat";
            this.stergeAngajatToolStripMenuItem.Click += new System.EventHandler(this.stergeAngajatToolStripMenuItem_Click);
            // 
            // btnAdaugaAngj
            // 
            this.btnAdaugaAngj.Location = new System.Drawing.Point(262, 69);
            this.btnAdaugaAngj.Name = "btnAdaugaAngj";
            this.btnAdaugaAngj.Size = new System.Drawing.Size(166, 51);
            this.btnAdaugaAngj.TabIndex = 2;
            this.btnAdaugaAngj.Text = "Adauga Angajat";
            this.btnAdaugaAngj.UseVisualStyleBackColor = true;
            this.btnAdaugaAngj.Click += new System.EventHandler(this.btnAdaugaAngj_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareXMLToolStripMenuItem,
            this.salvareBinarToolStripMenuItem,
            this.restaurareXMLToolStripMenuItem,
            this.restaurareBinarToolStripMenuItem});
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(84, 32);
            this.salvareToolStripMenuItem.Text = "Salvare";
            // 
            // salvareXMLToolStripMenuItem
            // 
            this.salvareXMLToolStripMenuItem.Name = "salvareXMLToolStripMenuItem";
            this.salvareXMLToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.salvareXMLToolStripMenuItem.Text = "Salvare XML";
            this.salvareXMLToolStripMenuItem.Click += new System.EventHandler(this.salvareXMLToolStripMenuItem_Click_1);
            // 
            // salvareBinarToolStripMenuItem
            // 
            this.salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            this.salvareBinarToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.salvareBinarToolStripMenuItem.Text = "Salvare Binar";
            this.salvareBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareBinarToolStripMenuItem_Click);
            // 
            // restaurareXMLToolStripMenuItem
            // 
            this.restaurareXMLToolStripMenuItem.Name = "restaurareXMLToolStripMenuItem";
            this.restaurareXMLToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.restaurareXMLToolStripMenuItem.Text = "Restaurare XML";
            this.restaurareXMLToolStripMenuItem.Click += new System.EventHandler(this.restaurareXMLToolStripMenuItem_Click);
            // 
            // restaurareBinarToolStripMenuItem
            // 
            this.restaurareBinarToolStripMenuItem.Name = "restaurareBinarToolStripMenuItem";
            this.restaurareBinarToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.restaurareBinarToolStripMenuItem.Text = "Restaurare Binar";
            this.restaurareBinarToolStripMenuItem.Click += new System.EventHandler(this.restaurareBinarToolStripMenuItem_Click);
            // 
            // tvAngajati
            // 
            this.tvAngajati.AllowDrop = true;
            this.tvAngajati.Location = new System.Drawing.Point(681, 389);
            this.tvAngajati.Name = "tvAngajati";
            this.tvAngajati.Size = new System.Drawing.Size(252, 136);
            this.tvAngajati.TabIndex = 5;
            this.tvAngajati.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvAngajati_DragDrop);
            this.tvAngajati.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvAngajati_DragEnter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.datanastereDataGridViewTextBoxColumn,
            this.idcompanieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.angajatiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 443);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(634, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "Angajati";
            this.angajatiBindingSource.DataSource = this.dbDataSet;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 150;
            // 
            // datanastereDataGridViewTextBoxColumn
            // 
            this.datanastereDataGridViewTextBoxColumn.DataPropertyName = "data_nastere";
            this.datanastereDataGridViewTextBoxColumn.HeaderText = "data_nastere";
            this.datanastereDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datanastereDataGridViewTextBoxColumn.Name = "datanastereDataGridViewTextBoxColumn";
            this.datanastereDataGridViewTextBoxColumn.Width = 150;
            // 
            // idcompanieDataGridViewTextBoxColumn
            // 
            this.idcompanieDataGridViewTextBoxColumn.DataPropertyName = "id_companie";
            this.idcompanieDataGridViewTextBoxColumn.HeaderText = "id_companie";
            this.idcompanieDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idcompanieDataGridViewTextBoxColumn.Name = "idcompanieDataGridViewTextBoxColumn";
            this.idcompanieDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 595);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tvAngajati);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAdaugaAngj);
            this.Controls.Add(this.lvAngajati);
            this.Controls.Add(this.lvCompanii);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCompanii;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvAngajati;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnAdaugaAngj;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeAngajatToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareBinarToolStripMenuItem;
        private System.Windows.Forms.TreeView tvAngajati;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private dbDataSetTableAdapters.AngajatiTableAdapter angajatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanastereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcompanieDataGridViewTextBoxColumn;
    }
}

