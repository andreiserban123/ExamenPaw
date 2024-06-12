namespace ex2 {
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
            this.lvCamioane = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectedItemsDelete = new System.Windows.Forms.Button();
            this.camioaneDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camioaneDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lvCamioane
            // 
            this.lvCamioane.HideSelection = false;
            this.lvCamioane.Location = new System.Drawing.Point(58, 191);
            this.lvCamioane.Name = "lvCamioane";
            this.lvCamioane.Size = new System.Drawing.Size(1603, 730);
            this.lvCamioane.TabIndex = 0;
            this.lvCamioane.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optiuniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1777, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optiuniToolStripMenuItem
            // 
            this.optiuniToolStripMenuItem.Name = "optiuniToolStripMenuItem";
            this.optiuniToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.optiuniToolStripMenuItem.Text = "Optiuni";
            this.optiuniToolStripMenuItem.Click += new System.EventHandler(this.optiuniToolStripMenuItem_Click);
            // 
            // btnSelectedItemsDelete
            // 
            this.btnSelectedItemsDelete.Location = new System.Drawing.Point(1538, 97);
            this.btnSelectedItemsDelete.Name = "btnSelectedItemsDelete";
            this.btnSelectedItemsDelete.Size = new System.Drawing.Size(188, 61);
            this.btnSelectedItemsDelete.TabIndex = 2;
            this.btnSelectedItemsDelete.Text = "Sterge Selectate";
            this.btnSelectedItemsDelete.UseVisualStyleBackColor = true;
            this.btnSelectedItemsDelete.Click += new System.EventHandler(this.btnSelectedItemsDelete_Click);
            // 
            // camioaneDataGridView
            // 
            this.camioaneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.camioaneDataGridView.Location = new System.Drawing.Point(137, 949);
            this.camioaneDataGridView.Name = "camioaneDataGridView";
            this.camioaneDataGridView.RowHeadersWidth = 62;
            this.camioaneDataGridView.RowTemplate.Height = 28;
            this.camioaneDataGridView.Size = new System.Drawing.Size(1432, 260);
            this.camioaneDataGridView.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1236, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "view";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 1218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.camioaneDataGridView);
            this.Controls.Add(this.btnSelectedItemsDelete);
            this.Controls.Add(this.lvCamioane);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camioaneDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCamioane;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optiuniToolStripMenuItem;
        private System.Windows.Forms.Button btnSelectedItemsDelete;
        private System.Windows.Forms.DataGridView camioaneDataGridView;
        private System.Windows.Forms.Button button1;
    }
}

