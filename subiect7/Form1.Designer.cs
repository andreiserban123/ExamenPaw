﻿namespace subiect7 {
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
            this.dgvCredite = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbCredite = new System.Windows.Forms.ListBox();
            this.copiazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.btnCalcul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredite)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCredite
            // 
            this.dgvCredite.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCredite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredite.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCredite.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCredite.Location = new System.Drawing.Point(0, 242);
            this.dgvCredite.MultiSelect = false;
            this.dgvCredite.Name = "dgvCredite";
            this.dgvCredite.RowHeadersWidth = 62;
            this.dgvCredite.RowTemplate.Height = 28;
            this.dgvCredite.Size = new System.Drawing.Size(1251, 541);
            this.dgvCredite.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaToolStripMenuItem,
            this.copiazaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 68);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem});
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.creditToolStripMenuItem.Text = "Credit";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // lbCredite
            // 
            this.lbCredite.FormattingEnabled = true;
            this.lbCredite.ItemHeight = 20;
            this.lbCredite.Location = new System.Drawing.Point(804, 50);
            this.lbCredite.Name = "lbCredite";
            this.lbCredite.Size = new System.Drawing.Size(363, 144);
            this.lbCredite.TabIndex = 2;
            this.lbCredite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbCredite_KeyPress);
            // 
            // copiazaToolStripMenuItem
            // 
            this.copiazaToolStripMenuItem.Name = "copiazaToolStripMenuItem";
            this.copiazaToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
            this.copiazaToolStripMenuItem.Text = "Copiaza";
            this.copiazaToolStripMenuItem.Click += new System.EventHandler(this.copiazaToolStripMenuItem_Click);
            // 
            // tbRate
            // 
            this.tbRate.Location = new System.Drawing.Point(156, 123);
            this.tbRate.Name = "tbRate";
            this.tbRate.ReadOnly = true;
            this.tbRate.Size = new System.Drawing.Size(318, 26);
            this.tbRate.TabIndex = 3;
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(246, 170);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(119, 51);
            this.btnCalcul.TabIndex = 4;
            this.btnCalcul.Text = "calculeaza credit lunar";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 948);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.tbRate);
            this.Controls.Add(this.lbCredite);
            this.Controls.Add(this.dgvCredite);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredite)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCredite;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ListBox lbCredite;
        private System.Windows.Forms.ToolStripMenuItem copiazaToolStripMenuItem;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Button btnCalcul;
    }
}

