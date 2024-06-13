namespace subiect5 {
    partial class FormAngajat {
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.cbCompanie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeDataNast = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalveaza.Location = new System.Drawing.Point(323, 539);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(342, 126);
            this.btnSalveaza.TabIndex = 0;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(323, 109);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(416, 26);
            this.tbNume.TabIndex = 1;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            // 
            // cbCompanie
            // 
            this.cbCompanie.FormattingEnabled = true;
            this.cbCompanie.Location = new System.Drawing.Point(323, 333);
            this.cbCompanie.Name = "cbCompanie";
            this.cbCompanie.Size = new System.Drawing.Size(416, 28);
            this.cbCompanie.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data nasterii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "IdCompanie";
            // 
            // dateTimeDataNast
            // 
            this.dateTimeDataNast.Location = new System.Drawing.Point(323, 219);
            this.dateTimeDataNast.Name = "dateTimeDataNast";
            this.dateTimeDataNast.Size = new System.Drawing.Size(416, 26);
            this.dateTimeDataNast.TabIndex = 7;
            this.dateTimeDataNast.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimeDataNast_Validating);
            // 
            // FormAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 827);
            this.Controls.Add(this.dateTimeDataNast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCompanie);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.btnSalveaza);
            this.Name = "FormAngajat";
            this.Text = "FormAngajat";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.DateTimePicker dateTimeDataNast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCompanie;
    }
}