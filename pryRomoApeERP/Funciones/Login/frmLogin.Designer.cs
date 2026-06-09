namespace pryRomoApeERP
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblMail = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblVerCon = new System.Windows.Forms.Label();
            this.chkVer = new System.Windows.Forms.CheckBox();
            this.lblAcl = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblMail.Location = new System.Drawing.Point(169, 210);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(37, 17);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Mail:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblContrasenia.Location = new System.Drawing.Point(169, 260);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(85, 17);
            this.lblContrasenia.TabIndex = 3;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(212, 210);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(244, 20);
            this.txtMail.TabIndex = 0;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.Enabled = false;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnLogin.Location = new System.Drawing.Point(369, 332);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(260, 260);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(196, 20);
            this.txtContrasenia.TabIndex = 1;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtConrtasenia_TextChanged);
            // 
            // lblVerCon
            // 
            this.lblVerCon.AutoSize = true;
            this.lblVerCon.Location = new System.Drawing.Point(340, 287);
            this.lblVerCon.Name = "lblVerCon";
            this.lblVerCon.Size = new System.Drawing.Size(82, 13);
            this.lblVerCon.TabIndex = 8;
            this.lblVerCon.Text = "Ver contraseña:";
            // 
            // chkVer
            // 
            this.chkVer.AutoSize = true;
            this.chkVer.Location = new System.Drawing.Point(428, 287);
            this.chkVer.Name = "chkVer";
            this.chkVer.Size = new System.Drawing.Size(15, 14);
            this.chkVer.TabIndex = 5;
            this.chkVer.UseVisualStyleBackColor = true;
            this.chkVer.CheckedChanged += new System.EventHandler(this.chkVer_CheckedChanged);
            // 
            // lblAcl
            // 
            this.lblAcl.AutoSize = true;
            this.lblAcl.Location = new System.Drawing.Point(315, 237);
            this.lblAcl.Name = "lblAcl";
            this.lblAcl.Size = new System.Drawing.Size(128, 13);
            this.lblAcl.TabIndex = 10;
            this.lblAcl.Text = "(Ingrese su ID de usuario)";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnLimpiar.Location = new System.Drawing.Point(288, 332);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSalir.Location = new System.Drawing.Point(207, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblConexion,
            this.lblFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(660, 26);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(157, 21);
            this.lblUsuario.Text = "toolStripStatusLabel1";
            // 
            // lblConexion
            // 
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(157, 21);
            this.lblConexion.Text = "toolStripStatusLabel3";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(157, 21);
            this.lblFecha.Text = "toolStripStatusLabel4";
            // 
            // tmrReloj
            // 
            this.tmrReloj.Interval = 1000;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 516);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblAcl);
            this.Controls.Add(this.chkVer);
            this.Controls.Add(this.lblVerCon);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblMail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ape ERP";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblVerCon;
        private System.Windows.Forms.CheckBox chkVer;
        private System.Windows.Forms.Label lblAcl;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblConexion;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.Timer tmrReloj;
    }
}

