namespace pryRomoApeERP
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblEstadoo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblVerCon = new System.Windows.Forms.Label();
            this.chkVer = new System.Windows.Forms.CheckBox();
            this.lblAcl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstadoo
            // 
            this.lblEstadoo.AutoSize = true;
            this.lblEstadoo.Location = new System.Drawing.Point(6, 242);
            this.lblEstadoo.Name = "lblEstadoo";
            this.lblEstadoo.Size = new System.Drawing.Size(104, 13);
            this.lblEstadoo.TabIndex = 0;
            this.lblEstadoo.Text = "Estado de conexión:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(108, 242);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(86, 13);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Desconectado...";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblMail.Location = new System.Drawing.Point(24, 28);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(37, 17);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Mail:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblContrasenia.Location = new System.Drawing.Point(24, 78);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(85, 17);
            this.lblContrasenia.TabIndex = 3;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(67, 28);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(244, 20);
            this.txtMail.TabIndex = 4;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Enabled = false;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnIngresar.Location = new System.Drawing.Point(224, 146);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(87, 27);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(115, 78);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(196, 20);
            this.txtContrasenia.TabIndex = 7;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtConrtasenia_TextChanged);
            // 
            // lblVerCon
            // 
            this.lblVerCon.AutoSize = true;
            this.lblVerCon.Location = new System.Drawing.Point(195, 105);
            this.lblVerCon.Name = "lblVerCon";
            this.lblVerCon.Size = new System.Drawing.Size(82, 13);
            this.lblVerCon.TabIndex = 8;
            this.lblVerCon.Text = "Ver contraseña:";
            // 
            // chkVer
            // 
            this.chkVer.AutoSize = true;
            this.chkVer.Location = new System.Drawing.Point(283, 105);
            this.chkVer.Name = "chkVer";
            this.chkVer.Size = new System.Drawing.Size(15, 14);
            this.chkVer.TabIndex = 9;
            this.chkVer.UseVisualStyleBackColor = true;
            this.chkVer.CheckedChanged += new System.EventHandler(this.chkVer_CheckedChanged);
            // 
            // lblAcl
            // 
            this.lblAcl.AutoSize = true;
            this.lblAcl.Location = new System.Drawing.Point(170, 55);
            this.lblAcl.Name = "lblAcl";
            this.lblAcl.Size = new System.Drawing.Size(128, 13);
            this.lblAcl.TabIndex = 10;
            this.lblAcl.Text = "(Ingrese su ID de usuario)";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 265);
            this.Controls.Add(this.lblAcl);
            this.Controls.Add(this.chkVer);
            this.Controls.Add(this.lblVerCon);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblEstadoo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ape ERP";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstadoo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblVerCon;
        private System.Windows.Forms.CheckBox chkVer;
        private System.Windows.Forms.Label lblAcl;
    }
}

