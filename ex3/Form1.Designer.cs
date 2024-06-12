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
            this.SuspendLayout();
            // 
            // btnAdaugaExtras
            // 
            this.btnAdaugaExtras.Location = new System.Drawing.Point(44, 44);
            this.btnAdaugaExtras.Name = "btnAdaugaExtras";
            this.btnAdaugaExtras.Size = new System.Drawing.Size(142, 39);
            this.btnAdaugaExtras.TabIndex = 0;
            this.btnAdaugaExtras.Text = "Adauga Extras";
            this.btnAdaugaExtras.UseVisualStyleBackColor = true;
            this.btnAdaugaExtras.Click += new System.EventHandler(this.btnAdaugaExtras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdaugaExtras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaExtras;
    }
}

