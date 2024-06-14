namespace ex8 {
    partial class FormCarte {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titlu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categorie";
            // 
            // btnFinish
            // 
            this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinish.Location = new System.Drawing.Point(247, 316);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(228, 86);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "Adauga";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(233, 28);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(298, 26);
            this.tbTitlu.TabIndex = 5;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(233, 88);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(298, 26);
            this.tbPret.TabIndex = 6;
            this.tbPret.Validating += new System.ComponentModel.CancelEventHandler(this.tbPret_Validating);
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(233, 153);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(298, 26);
            this.tbISBN.TabIndex = 7;
            this.tbISBN.Validating += new System.ComponentModel.CancelEventHandler(this.tbISBN_Validating);
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(233, 225);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(298, 28);
            this.cbCategorie.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbTitlu);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCarte";
            this.Text = "FormCarte";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}