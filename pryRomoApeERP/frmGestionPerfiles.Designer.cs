namespace pryRomoApeERP
{
    partial class frmGestionPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPerfiles));
            this.lblMailNuevoP = new System.Windows.Forms.Label();
            this.btnGuardarPerfiles = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtMailAniadirPerfil = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMailNuevoP
            // 
            this.lblMailNuevoP.AutoSize = true;
            this.lblMailNuevoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblMailNuevoP.Location = new System.Drawing.Point(36, 215);
            this.lblMailNuevoP.Name = "lblMailNuevoP";
            this.lblMailNuevoP.Size = new System.Drawing.Size(104, 16);
            this.lblMailNuevoP.TabIndex = 0;
            this.lblMailNuevoP.Text = "Mail de Usuario:";
            // 
            // btnGuardarPerfiles
            // 
            this.btnGuardarPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardarPerfiles.Location = new System.Drawing.Point(500, 436);
            this.btnGuardarPerfiles.Name = "btnGuardarPerfiles";
            this.btnGuardarPerfiles.Size = new System.Drawing.Size(127, 34);
            this.btnGuardarPerfiles.TabIndex = 3;
            this.btnGuardarPerfiles.Text = "Guardar Perfiles";
            this.btnGuardarPerfiles.UseVisualStyleBackColor = false;
            this.btnGuardarPerfiles.Click += new System.EventHandler(this.btnGuardarPerfiles_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Location = new System.Drawing.Point(408, 436);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtMailAniadirPerfil
            // 
            this.txtMailAniadirPerfil.Location = new System.Drawing.Point(146, 215);
            this.txtMailAniadirPerfil.Name = "txtMailAniadirPerfil";
            this.txtMailAniadirPerfil.Size = new System.Drawing.Size(220, 20);
            this.txtMailAniadirPerfil.TabIndex = 7;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnActualizar.Location = new System.Drawing.Point(517, 260);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Admin",
            "Logis",
            "Venta",
            "Marke",
            "RRHH",
            "Conta"});
            this.checkedListBox1.Location = new System.Drawing.Point(40, 261);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(587, 169);
            this.checkedListBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmGestionPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(660, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtMailAniadirPerfil);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarPerfiles);
            this.Controls.Add(this.lblMailNuevoP);
            this.Name = "frmGestionPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Perfiles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMailNuevoP;
        private System.Windows.Forms.Button btnGuardarPerfiles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtMailAniadirPerfil;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}