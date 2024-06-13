namespace ex3 {
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
            this.btnAdaugaExtras = new System.Windows.Forms.Button();
            this.lvTranzactii = new System.Windows.Forms.ListView();
            this.tbExtrasDetalii = new System.Windows.Forms.TextBox();
            this.lvExtraseCont = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvareFisierTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdaugaExtras
            // 
            this.btnAdaugaExtras.Location = new System.Drawing.Point(108, 422);
            this.btnAdaugaExtras.Name = "btnAdaugaExtras";
            this.btnAdaugaExtras.Size = new System.Drawing.Size(142, 39);
            this.btnAdaugaExtras.TabIndex = 0;
            this.btnAdaugaExtras.Text = "Adauga Extras";
            this.btnAdaugaExtras.UseVisualStyleBackColor = true;
            this.btnAdaugaExtras.Click += new System.EventHandler(this.btnAdaugaExtras_Click);
            // 
            // lvTranzactii
            // 
            this.lvTranzactii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvTranzactii.FullRowSelect = true;
            this.lvTranzactii.GridLines = true;
            this.lvTranzactii.HideSelection = false;
            this.lvTranzactii.Location = new System.Drawing.Point(500, 143);
            this.lvTranzactii.Name = "lvTranzactii";
            this.lvTranzactii.Size = new System.Drawing.Size(470, 184);
            this.lvTranzactii.TabIndex = 1;
            this.lvTranzactii.UseCompatibleStateImageBehavior = false;
            this.lvTranzactii.View = System.Windows.Forms.View.Details;
            // 
            // tbExtrasDetalii
            // 
            this.tbExtrasDetalii.Location = new System.Drawing.Point(197, 64);
            this.tbExtrasDetalii.Name = "tbExtrasDetalii";
            this.tbExtrasDetalii.ReadOnly = true;
            this.tbExtrasDetalii.Size = new System.Drawing.Size(479, 26);
            this.tbExtrasDetalii.TabIndex = 2;
            this.tbExtrasDetalii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvExtraseCont
            // 
            this.lvExtraseCont.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvExtraseCont.ContextMenuStrip = this.contextMenuStrip1;
            this.lvExtraseCont.FullRowSelect = true;
            this.lvExtraseCont.GridLines = true;
            this.lvExtraseCont.HideSelection = false;
            this.lvExtraseCont.Location = new System.Drawing.Point(64, 143);
            this.lvExtraseCont.Name = "lvExtraseCont";
            this.lvExtraseCont.Size = new System.Drawing.Size(272, 184);
            this.lvExtraseCont.TabIndex = 3;
            this.lvExtraseCont.UseCompatibleStateImageBehavior = false;
            this.lvExtraseCont.View = System.Windows.Forms.View.Details;
            this.lvExtraseCont.SelectedIndexChanged += new System.EventHandler(this.lvExtraseCont_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adresa";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IBAN";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Detalii";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Suma";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data efectuarii";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareFisierTxtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvareFisierTxtToolStripMenuItem
            // 
            this.salvareFisierTxtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareBinarToolStripMenuItem,
            this.salvareXMLToolStripMenuItem,
            this.salvareTXTToolStripMenuItem,
            this.saveDBToolStripMenuItem});
            this.salvareFisierTxtToolStripMenuItem.Name = "salvareFisierTxtToolStripMenuItem";
            this.salvareFisierTxtToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.salvareFisierTxtToolStripMenuItem.Text = "Salvare";
            // 
            // salvareBinarToolStripMenuItem
            // 
            this.salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            this.salvareBinarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salvareBinarToolStripMenuItem.Text = "Salvare Binar";
            // 
            // salvareXMLToolStripMenuItem
            // 
            this.salvareXMLToolStripMenuItem.Name = "salvareXMLToolStripMenuItem";
            this.salvareXMLToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salvareXMLToolStripMenuItem.Text = "Salvare XML";
            this.salvareXMLToolStripMenuItem.Click += new System.EventHandler(this.salvareXMLToolStripMenuItem_Click);
            // 
            // salvareTXTToolStripMenuItem
            // 
            this.salvareTXTToolStripMenuItem.Name = "salvareTXTToolStripMenuItem";
            this.salvareTXTToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salvareTXTToolStripMenuItem.Text = "Salvare TXT";
            this.salvareTXTToolStripMenuItem.Click += new System.EventHandler(this.salvareTXTToolStripMenuItem_Click);
            // 
            // saveDBToolStripMenuItem
            // 
            this.saveDBToolStripMenuItem.Name = "saveDBToolStripMenuItem";
            this.saveDBToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveDBToolStripMenuItem.Text = "Save DB";
            this.saveDBToolStripMenuItem.Click += new System.EventHandler(this.saveDBToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 36);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(515, 408);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(380, 132);
            this.treeView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 694);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lvExtraseCont);
            this.Controls.Add(this.tbExtrasDetalii);
            this.Controls.Add(this.lvTranzactii);
            this.Controls.Add(this.btnAdaugaExtras);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaExtras;
        private System.Windows.Forms.ListView lvTranzactii;
        private System.Windows.Forms.TextBox tbExtrasDetalii;
        private System.Windows.Forms.ListView lvExtraseCont;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareFisierTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDBToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
    }
}

