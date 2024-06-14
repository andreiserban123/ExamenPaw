namespace ex8 {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvCarti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAutori = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbAutori = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1537, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaManualToolStripMenuItem});
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.dateToolStripMenuItem.Text = "Date";
            // 
            // adaugaManualToolStripMenuItem
            // 
            this.adaugaManualToolStripMenuItem.Name = "adaugaManualToolStripMenuItem";
            this.adaugaManualToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.adaugaManualToolStripMenuItem.Text = "Adauga Manual";
            this.adaugaManualToolStripMenuItem.Click += new System.EventHandler(this.adaugaManualToolStripMenuItem_Click);
            // 
            // lvCarti
            // 
            this.lvCarti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvCarti.FullRowSelect = true;
            this.lvCarti.GridLines = true;
            this.lvCarti.HideSelection = false;
            this.lvCarti.Location = new System.Drawing.Point(23, 96);
            this.lvCarti.Name = "lvCarti";
            this.lvCarti.Size = new System.Drawing.Size(562, 338);
            this.lvCarti.TabIndex = 1;
            this.lvCarti.UseCompatibleStateImageBehavior = false;
            this.lvCarti.View = System.Windows.Forms.View.Details;
            this.lvCarti.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvCarti_ColumnClick);
            this.lvCarti.SelectedIndexChanged += new System.EventHandler(this.lvCarti_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titlu";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pret";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ISBN";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Categorie";
            this.columnHeader4.Width = 77;
            // 
            // lvAutori
            // 
            this.lvAutori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvAutori.HideSelection = false;
            this.lvAutori.Location = new System.Drawing.Point(765, 96);
            this.lvAutori.Name = "lvAutori";
            this.lvAutori.Size = new System.Drawing.Size(534, 351);
            this.lvAutori.TabIndex = 2;
            this.lvAutori.UseCompatibleStateImageBehavior = false;
            this.lvAutori.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nume";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Grad";
            this.columnHeader6.Width = 98;
            // 
            // tbAutori
            // 
            this.tbAutori.Location = new System.Drawing.Point(23, 503);
            this.tbAutori.Name = "tbAutori";
            this.tbAutori.Size = new System.Drawing.Size(291, 26);
            this.tbAutori.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 857);
            this.Controls.Add(this.tbAutori);
            this.Controls.Add(this.lvAutori);
            this.Controls.Add(this.lvCarti);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaManualToolStripMenuItem;
        private System.Windows.Forms.ListView lvCarti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvAutori;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox tbAutori;
    }
}

