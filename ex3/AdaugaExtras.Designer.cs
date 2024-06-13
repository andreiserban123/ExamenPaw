namespace ex3 {
    partial class AdaugaExtras {
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
            this.Nume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.cbTranzactii = new System.Windows.Forms.ComboBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.errorProviderAn = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAn)).BeginInit();
            this.SuspendLayout();
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(93, 169);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(68, 25);
            this.Nume.TabIndex = 0;
            this.Nume.Text = "Nume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tranzactii";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(281, 169);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(353, 31);
            this.tbNume.TabIndex = 3;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(281, 265);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(353, 31);
            this.tbAdresa.TabIndex = 4;
            this.tbAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdresa_Validating);
            // 
            // cbTranzactii
            // 
            this.cbTranzactii.FormattingEnabled = true;
            this.cbTranzactii.Location = new System.Drawing.Point(281, 364);
            this.cbTranzactii.Name = "cbTranzactii";
            this.cbTranzactii.Size = new System.Drawing.Size(353, 33);
            this.cbTranzactii.TabIndex = 5;
            // 
            // btnAdauga
            // 
            this.btnAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdauga.Location = new System.Drawing.Point(98, 506);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(168, 100);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // errorProviderAn
            // 
            this.errorProviderAn.ContainerControl = this;
            // 
            // AdaugaExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 1077);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.cbTranzactii);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nume);
            this.Name = "AdaugaExtras";
            this.Text = "AdaugaExtras";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.ComboBox cbTranzactii;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ErrorProvider errorProviderAn;
    }
}