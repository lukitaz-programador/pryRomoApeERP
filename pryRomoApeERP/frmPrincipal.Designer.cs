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
            this.SuspendLayout();
            // 
            // btnGestionDatosPersonales
            // 
            this.btnGestionDatosPersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGestionDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.btnGestionDatosPersonales.Name = "btnGestionDatosPersonales";
            this.btnGestionDatosPersonales.Size = new System.Drawing.Size(105, 23);
            this.btnGestionDatosPersonales.TabIndex = 0;
            this.btnGestionDatosPersonales.Text = "Gestion de datos personales";
            this.btnGestionDatosPersonales.UseVisualStyleBackColor = false;
            this.btnGestionDatosPersonales.Click += new System.EventHandler(this.btnGestionDatosPersonales_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(339, 278);
            this.Controls.Add(this.btnGestionDatosPersonales);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionDatosPersonales;
    }
}