namespace pryRomoApeERP
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGestionDatosPersonales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGestionDatosPersonales
            // 
            this.btnGestionDatosPersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGestionDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnGestionDatosPersonales.Location = new System.Drawing.Point(26, 91);
            this.btnGestionDatosPersonales.Name = "btnGestionDatosPersonales";
            this.btnGestionDatosPersonales.Size = new System.Drawing.Size(152, 49);
            this.btnGestionDatosPersonales.TabIndex = 0;
            this.btnGestionDatosPersonales.Text = "Gestion de datos personales";
            this.btnGestionDatosPersonales.UseVisualStyleBackColor = false;
            this.btnGestionDatosPersonales.Click += new System.EventHandler(this.btnGestionDatosPersonales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(164, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÚ PRINCIPAL";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(660, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGestionDatosPersonales);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestionDatosPersonales;
        private System.Windows.Forms.Label label1;
    }
}