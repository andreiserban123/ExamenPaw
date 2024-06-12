namespace ex3 {
    partial class FormExtrasCont {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNumeClient;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.ListBox listBoxTranzactii;
        private System.Windows.Forms.Button btnCreazaExtrasCont;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.txtNumeClient = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.listBoxTranzactii = new System.Windows.Forms.ListBox();
            this.btnCreazaExtrasCont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeClient
            // 
            this.txtNumeClient.Location = new System.Drawing.Point(186, 14);
            this.txtNumeClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeClient.Name = "txtNumeClient";
            this.txtNumeClient.Size = new System.Drawing.Size(388, 26);
            this.txtNumeClient.TabIndex = 0;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(186, 54);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(388, 26);
            this.txtAdresa.TabIndex = 1;
            // 
            // listBoxTranzactii
            // 
            this.listBoxTranzactii.FormattingEnabled = true;
            this.listBoxTranzactii.ItemHeight = 20;
            this.listBoxTranzactii.Location = new System.Drawing.Point(186, 100);
            this.listBoxTranzactii.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxTranzactii.Name = "listBoxTranzactii";
            this.listBoxTranzactii.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTranzactii.Size = new System.Drawing.Size(388, 144);
            this.listBoxTranzactii.TabIndex = 2;
            // 
            // btnCreazaExtrasCont
            // 
            this.btnCreazaExtrasCont.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreazaExtrasCont.Location = new System.Drawing.Point(392, 254);
            this.btnCreazaExtrasCont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreazaExtrasCont.Name = "btnCreazaExtrasCont";
            this.btnCreazaExtrasCont.Size = new System.Drawing.Size(182, 35);
            this.btnCreazaExtrasCont.TabIndex = 3;
            this.btnCreazaExtrasCont.Text = "Crează Extras de Cont";
            this.btnCreazaExtrasCont.UseVisualStyleBackColor = true;
            this.btnCreazaExtrasCont.Click += new System.EventHandler(this.btnCreazaExtrasCont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nume Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adresa";
            // 
            // btnRenunta
            // 
            this.btnRenunta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRenunta.Location = new System.Drawing.Point(186, 254);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(150, 35);
            this.btnRenunta.TabIndex = 6;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            // 
            // FormExtrasCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 520);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreazaExtrasCont);
            this.Controls.Add(this.listBoxTranzactii);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNumeClient);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormExtrasCont";
            this.Text = "Creare Extras Cont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRenunta;
    }
}
