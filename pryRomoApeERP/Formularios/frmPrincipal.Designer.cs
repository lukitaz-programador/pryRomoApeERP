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
            this.btnInfoAuditoria = new System.Windows.Forms.Button();
            this.btnGestionarPerfiles = new System.Windows.Forms.Button();
            this.btnSalirApp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeDatosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInformaciónDeAuditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDePerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.btnGestionDatosPersonales.Text = "Gestionar datos personales";
            this.btnGestionDatosPersonales.UseVisualStyleBackColor = false;
            this.btnGestionDatosPersonales.Click += new System.EventHandler(this.btnGestionDatosPersonales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(170, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÚ PRINCIPAL";
            // 
            // btnInfoAuditoria
            // 
            this.btnInfoAuditoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInfoAuditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnInfoAuditoria.Location = new System.Drawing.Point(252, 91);
            this.btnInfoAuditoria.Name = "btnInfoAuditoria";
            this.btnInfoAuditoria.Size = new System.Drawing.Size(152, 49);
            this.btnInfoAuditoria.TabIndex = 2;
            this.btnInfoAuditoria.Text = "Ver información de auditoria";
            this.btnInfoAuditoria.UseVisualStyleBackColor = false;
            this.btnInfoAuditoria.Click += new System.EventHandler(this.btnInfoAuditoria_Click);
            // 
            // btnGestionarPerfiles
            // 
            this.btnGestionarPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGestionarPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnGestionarPerfiles.Location = new System.Drawing.Point(480, 91);
            this.btnGestionarPerfiles.Name = "btnGestionarPerfiles";
            this.btnGestionarPerfiles.Size = new System.Drawing.Size(152, 49);
            this.btnGestionarPerfiles.TabIndex = 3;
            this.btnGestionarPerfiles.Text = "Gestionar Perfiles ";
            this.btnGestionarPerfiles.UseVisualStyleBackColor = false;
            this.btnGestionarPerfiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalirApp
            // 
            this.btnSalirApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalirApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSalirApp.Location = new System.Drawing.Point(569, 476);
            this.btnSalirApp.Name = "btnSalirApp";
            this.btnSalirApp.Size = new System.Drawing.Size(79, 28);
            this.btnSalirApp.TabIndex = 4;
            this.btnSalirApp.Text = "Salir";
            this.btnSalirApp.UseVisualStyleBackColor = false;
            this.btnSalirApp.Click += new System.EventHandler(this.btnSalirApp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.gestiónDeDatosPersonalesToolStripMenuItem,
            this.verInformaciónDeAuditoriaToolStripMenuItem,
            this.gestiónDePerfilesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // gestiónDeDatosPersonalesToolStripMenuItem
            // 
            this.gestiónDeDatosPersonalesToolStripMenuItem.Name = "gestiónDeDatosPersonalesToolStripMenuItem";
            this.gestiónDeDatosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.gestiónDeDatosPersonalesToolStripMenuItem.Text = "Gestión de datos personales";
            this.gestiónDeDatosPersonalesToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeDatosPersonalesToolStripMenuItem_Click);
            // 
            // verInformaciónDeAuditoriaToolStripMenuItem
            // 
            this.verInformaciónDeAuditoriaToolStripMenuItem.Name = "verInformaciónDeAuditoriaToolStripMenuItem";
            this.verInformaciónDeAuditoriaToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.verInformaciónDeAuditoriaToolStripMenuItem.Text = "Ver información de auditoria";
            // 
            // gestiónDePerfilesToolStripMenuItem
            // 
            this.gestiónDePerfilesToolStripMenuItem.Name = "gestiónDePerfilesToolStripMenuItem";
            this.gestiónDePerfilesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.gestiónDePerfilesToolStripMenuItem.Text = "Gestión de perfiles";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(660, 516);
            this.Controls.Add(this.btnSalirApp);
            this.Controls.Add(this.btnGestionarPerfiles);
            this.Controls.Add(this.btnInfoAuditoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGestionDatosPersonales);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestionDatosPersonales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfoAuditoria;
        private System.Windows.Forms.Button btnGestionarPerfiles;
        private System.Windows.Forms.Button btnSalirApp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeDatosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInformaciónDeAuditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDePerfilesToolStripMenuItem;
    }
}