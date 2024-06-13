namespace subiect7 {
    partial class FormCredit {
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.tbDobanda = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbPerioada = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ValoareCredit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dobanda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DataAcordarii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Perioada";
            // 
            // btnFinish
            // 
            this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinish.Location = new System.Drawing.Point(249, 351);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(173, 67);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "adauga";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(234, 41);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(341, 26);
            this.tbClient.TabIndex = 6;
            this.tbClient.Validating += new System.ComponentModel.CancelEventHandler(this.tbClient_Validating);
            // 
            // tbValoare
            // 
            this.tbValoare.Location = new System.Drawing.Point(234, 88);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.Size = new System.Drawing.Size(341, 26);
            this.tbValoare.TabIndex = 7;
            // 
            // tbDobanda
            // 
            this.tbDobanda.Location = new System.Drawing.Point(234, 137);
            this.tbDobanda.Name = "tbDobanda";
            this.tbDobanda.Size = new System.Drawing.Size(341, 26);
            this.tbDobanda.TabIndex = 8;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(234, 200);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(341, 26);
            this.tbData.TabIndex = 9;
            // 
            // tbPerioada
            // 
            this.tbPerioada.Location = new System.Drawing.Point(234, 260);
            this.tbPerioada.Name = "tbPerioada";
            this.tbPerioada.Size = new System.Drawing.Size(341, 26);
            this.tbPerioada.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPerioada);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbDobanda);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCredit";
            this.Text = "FormCredit";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.TextBox tbDobanda;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbPerioada;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}