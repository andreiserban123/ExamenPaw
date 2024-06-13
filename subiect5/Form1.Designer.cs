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
            this.btnAdaugaAngj = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeAngajatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.lvAngajati.Location = new System.Drawing.Point(533, 69);
            this.lvAngajati.Name = "lvAngajati";
            this.lvAngajati.Size = new System.Drawing.Size(414, 256);
            this.lvAngajati.TabIndex = 1;
            this.lvAngajati.UseCompatibleStateImageBehavior = false;
            this.lvAngajati.View = System.Windows.Forms.View.Details;
            this.lvAngajati.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAngajati_MouseDoubleClick);
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
            // btnAdaugaAngj
            // 
            this.btnAdaugaAngj.Location = new System.Drawing.Point(292, 399);
            this.btnAdaugaAngj.Name = "btnAdaugaAngj";
            this.btnAdaugaAngj.Size = new System.Drawing.Size(166, 51);
            this.btnAdaugaAngj.TabIndex = 2;
            this.btnAdaugaAngj.Text = "Adauga Angajat";
            this.btnAdaugaAngj.UseVisualStyleBackColor = true;
            this.btnAdaugaAngj.Click += new System.EventHandler(this.btnAdaugaAngj_Click);
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
            this.stergeAngajatToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.stergeAngajatToolStripMenuItem.Text = "Sterge Angajat";
            this.stergeAngajatToolStripMenuItem.Click += new System.EventHandler(this.stergeAngajatToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
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
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.salvareToolStripMenuItem.Text = "Salvare";
            // 
            // salvareXMLToolStripMenuItem
            // 
            this.salvareXMLToolStripMenuItem.Name = "salvareXMLToolStripMenuItem";
            this.salvareXMLToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salvareXMLToolStripMenuItem.Text = "Salvare XML";
            this.salvareXMLToolStripMenuItem.Click += new System.EventHandler(this.salvareXMLToolStripMenuItem_Click_1);
            // 
            // salvareBinarToolStripMenuItem
            // 
            this.salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            this.salvareBinarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salvareBinarToolStripMenuItem.Text = "Salvare Binar";
            this.salvareBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareBinarToolStripMenuItem_Click);
            // 
            // restaurareXMLToolStripMenuItem
            // 
            this.restaurareXMLToolStripMenuItem.Name = "restaurareXMLToolStripMenuItem";
            this.restaurareXMLToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.restaurareXMLToolStripMenuItem.Text = "Restaurare XML";
            this.restaurareXMLToolStripMenuItem.Click += new System.EventHandler(this.restaurareXMLToolStripMenuItem_Click);
            // 
            // restaurareBinarToolStripMenuItem
            // 
            this.restaurareBinarToolStripMenuItem.Name = "restaurareBinarToolStripMenuItem";
            this.restaurareBinarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.restaurareBinarToolStripMenuItem.Text = "Restaurare Binar";
            this.restaurareBinarToolStripMenuItem.Click += new System.EventHandler(this.restaurareBinarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 595);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAdaugaAngj);
            this.Controls.Add(this.lvAngajati);
            this.Controls.Add(this.lvCompanii);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

