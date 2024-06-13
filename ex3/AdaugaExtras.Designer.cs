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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.errorProviderAn = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkLBTranzactii = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAn)).BeginInit();
            this.SuspendLayout();
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(70, 135);
            this.Nume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(51, 20);
            this.Nume.TabIndex = 0;
            this.Nume.Text = "Nume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tranzactii";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(211, 135);
            this.tbNume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(266, 26);
            this.tbNume.TabIndex = 3;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(211, 212);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(266, 26);
            this.tbAdresa.TabIndex = 4;
            this.tbAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdresa_Validating);
            // 
            // btnAdauga
            // 
            this.btnAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdauga.Location = new System.Drawing.Point(211, 550);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(126, 80);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // errorProviderAn
            // 
            this.errorProviderAn.ContainerControl = this;
            // 
            // checkLBTranzactii
            // 
            this.checkLBTranzactii.CheckOnClick = true;
            this.checkLBTranzactii.FormattingEnabled = true;
            this.checkLBTranzactii.Location = new System.Drawing.Point(211, 279);
            this.checkLBTranzactii.Name = "checkLBTranzactii";
            this.checkLBTranzactii.Size = new System.Drawing.Size(266, 119);
            this.checkLBTranzactii.TabIndex = 7;
            // 
            // AdaugaExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 848);
            this.Controls.Add(this.checkLBTranzactii);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nume);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ErrorProvider errorProviderAn;
        private System.Windows.Forms.CheckedListBox checkLBTranzactii;
    }
}