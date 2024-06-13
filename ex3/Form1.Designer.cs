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
            this.btnAdaugaExtras = new System.Windows.Forms.Button();
            this.lvTranzactii = new System.Windows.Forms.ListView();
            this.tbExtrasDetalii = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdaugaExtras
            // 
            this.btnAdaugaExtras.Location = new System.Drawing.Point(12, 159);
            this.btnAdaugaExtras.Name = "btnAdaugaExtras";
            this.btnAdaugaExtras.Size = new System.Drawing.Size(142, 39);
            this.btnAdaugaExtras.TabIndex = 0;
            this.btnAdaugaExtras.Text = "Adauga Extras";
            this.btnAdaugaExtras.UseVisualStyleBackColor = true;
            this.btnAdaugaExtras.Click += new System.EventHandler(this.btnAdaugaExtras_Click);
            // 
            // lvTranzactii
            // 
            this.lvTranzactii.HideSelection = false;
            this.lvTranzactii.Location = new System.Drawing.Point(179, 159);
            this.lvTranzactii.Name = "lvTranzactii";
            this.lvTranzactii.Size = new System.Drawing.Size(479, 184);
            this.lvTranzactii.TabIndex = 1;
            this.lvTranzactii.UseCompatibleStateImageBehavior = false;
            // 
            // tbExtrasDetalii
            // 
            this.tbExtrasDetalii.Location = new System.Drawing.Point(179, 113);
            this.tbExtrasDetalii.Name = "tbExtrasDetalii";
            this.tbExtrasDetalii.ReadOnly = true;
            this.tbExtrasDetalii.Size = new System.Drawing.Size(479, 26);
            this.tbExtrasDetalii.TabIndex = 2;
            this.tbExtrasDetalii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbExtrasDetalii);
            this.Controls.Add(this.lvTranzactii);
            this.Controls.Add(this.btnAdaugaExtras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaExtras;
        private System.Windows.Forms.ListView lvTranzactii;
        private System.Windows.Forms.TextBox tbExtrasDetalii;
    }
}

