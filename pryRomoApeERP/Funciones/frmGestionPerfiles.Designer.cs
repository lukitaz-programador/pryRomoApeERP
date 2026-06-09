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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPerfiles));
            this.lblMailNuevoP = new System.Windows.Forms.Label();
            this.btnGuardarPerfiles = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboMail = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lstPerfiles = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
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
            this.btnGuardarPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnGuardarPerfiles.Location = new System.Drawing.Point(500, 449);
            this.btnGuardarPerfiles.Name = "btnGuardarPerfiles";
            this.btnGuardarPerfiles.Size = new System.Drawing.Size(127, 34);
            this.btnGuardarPerfiles.TabIndex = 3;
            this.btnGuardarPerfiles.Text = "Guardar Perfiles";
            this.btnGuardarPerfiles.UseVisualStyleBackColor = false;
            this.btnGuardarPerfiles.Click += new System.EventHandler(this.btnGuardarPerfiles_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSalir.Location = new System.Drawing.Point(408, 449);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboMail
            // 
            this.cboMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMail.FormattingEnabled = true;
            this.cboMail.Location = new System.Drawing.Point(146, 215);
            this.cboMail.Name = "cboMail";
            this.cboMail.Size = new System.Drawing.Size(220, 21);
            this.cboMail.TabIndex = 7;
            this.cboMail.SelectedIndexChanged += new System.EventHandler(this.cboMail_SelectedIndexChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnActualizar.Location = new System.Drawing.Point(517, 260);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lstPerfiles
            // 
            this.lstPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lstPerfiles.FormattingEnabled = true;
            this.lstPerfiles.Items.AddRange(new object[] {
            "Admin",
            "Logis",
            "Venta",
            "Marke",
            "RRHH",
            "Conta"});
            this.lstPerfiles.Location = new System.Drawing.Point(40, 261);
            this.lstPerfiles.Name = "lstPerfiles";
            this.lstPerfiles.Size = new System.Drawing.Size(587, 164);
            this.lstPerfiles.TabIndex = 9;
            this.lstPerfiles.SelectedIndexChanged += new System.EventHandler(this.lstPerfiles_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tmrReloj
            // 
            this.tmrReloj.Interval = 1000;
            // 
            // frmGestionPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lstPerfiles);
            this.Controls.Add(this.cboMail);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarPerfiles);
            this.Controls.Add(this.lblMailNuevoP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Perfiles";
            this.Load += new System.EventHandler(this.frmGestionPerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMailNuevoP;
        private System.Windows.Forms.Button btnGuardarPerfiles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboMail;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.CheckedListBox lstPerfiles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrReloj;
    }
}