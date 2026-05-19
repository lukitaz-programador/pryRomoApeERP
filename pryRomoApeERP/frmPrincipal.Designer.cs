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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtConrtasenia = new System.Windows.Forms.TextBox();
            this.lblVerCon = new System.Windows.Forms.Label();
            this.chkVer = new System.Windows.Forms.CheckBox();
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNombre.Location = new System.Drawing.Point(24, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblContrasenia.Location = new System.Drawing.Point(24, 66);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(85, 17);
            this.lblContrasenia.TabIndex = 3;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Enabled = false;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnIngresar.Location = new System.Drawing.Point(211, 135);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(87, 27);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtConrtasenia
            // 
            this.txtConrtasenia.Location = new System.Drawing.Point(115, 66);
            this.txtConrtasenia.Name = "txtConrtasenia";
            this.txtConrtasenia.Size = new System.Drawing.Size(183, 20);
            this.txtConrtasenia.TabIndex = 7;
            this.txtConrtasenia.TextChanged += new System.EventHandler(this.txtConrtasenia_TextChanged);
            // 
            // lblVerCon
            // 
            this.lblVerCon.AutoSize = true;
            this.lblVerCon.Location = new System.Drawing.Point(195, 93);
            this.lblVerCon.Name = "lblVerCon";
            this.lblVerCon.Size = new System.Drawing.Size(82, 13);
            this.lblVerCon.TabIndex = 8;
            this.lblVerCon.Text = "Ver contraseña:";
            // 
            // chkVer
            // 
            this.chkVer.AutoSize = true;
            this.chkVer.Location = new System.Drawing.Point(283, 93);
            this.chkVer.Name = "chkVer";
            this.chkVer.Size = new System.Drawing.Size(15, 14);
            this.chkVer.TabIndex = 9;
            this.chkVer.UseVisualStyleBackColor = true;
            this.chkVer.CheckedChanged += new System.EventHandler(this.chkVer_CheckedChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 265);
            this.Controls.Add(this.chkVer);
            this.Controls.Add(this.lblVerCon);
            this.Controls.Add(this.txtConrtasenia);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblNombre);
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
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtConrtasenia;
        private System.Windows.Forms.Label lblVerCon;
        private System.Windows.Forms.CheckBox chkVer;
    }
}

