namespace pryRomoApeERP
{
    partial class frmPersonal
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
            this.grpDomicilio = new System.Windows.Forms.GroupBox();
            this.txtGeo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblGeo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.grpDatosPer = new System.Windows.Forms.GroupBox();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnGuardarPer = new System.Windows.Forms.Button();
            this.grpContacto = new System.Windows.Forms.GroupBox();
            this.grpRedes = new System.Windows.Forms.GroupBox();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.txtTikTok = new System.Windows.Forms.TextBox();
            this.txtInstagram = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtTelegram = new System.Windows.Forms.TextBox();
            this.lblTikTok = new System.Windows.Forms.Label();
            this.lblTelegram = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblInstagram = new System.Windows.Forms.Label();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.lblEstadoUsuario = new System.Windows.Forms.Label();
            this.grpDomicilio.SuspendLayout();
            this.grpDatosPer.SuspendLayout();
            this.grpContacto.SuspendLayout();
            this.grpRedes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDomicilio
            // 
            this.grpDomicilio.Controls.Add(this.txtGeo);
            this.grpDomicilio.Controls.Add(this.txtDireccion);
            this.grpDomicilio.Controls.Add(this.lblGeo);
            this.grpDomicilio.Controls.Add(this.lblDireccion);
            this.grpDomicilio.Controls.Add(this.cmbLocalidad);
            this.grpDomicilio.Controls.Add(this.cmbProvincia);
            this.grpDomicilio.Controls.Add(this.lblProvincia);
            this.grpDomicilio.Controls.Add(this.lblLocalidad);
            this.grpDomicilio.Location = new System.Drawing.Point(16, 174);
            this.grpDomicilio.Name = "grpDomicilio";
            this.grpDomicilio.Size = new System.Drawing.Size(311, 189);
            this.grpDomicilio.TabIndex = 6;
            this.grpDomicilio.TabStop = false;
            this.grpDomicilio.Text = "Domicilio";
            // 
            // txtGeo
            // 
            this.txtGeo.Location = new System.Drawing.Point(97, 151);
            this.txtGeo.Name = "txtGeo";
            this.txtGeo.Size = new System.Drawing.Size(196, 20);
            this.txtGeo.TabIndex = 22;
            this.txtGeo.TextChanged += new System.EventHandler(this.txtGeo_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(97, 112);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(196, 20);
            this.txtDireccion.TabIndex = 21;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblGeo
            // 
            this.lblGeo.AutoSize = true;
            this.lblGeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblGeo.Location = new System.Drawing.Point(12, 156);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Size = new System.Drawing.Size(36, 16);
            this.lblGeo.TabIndex = 20;
            this.lblGeo.Text = "Geo:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDireccion.Location = new System.Drawing.Point(12, 117);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 16);
            this.lblDireccion.TabIndex = 19;
            this.lblDireccion.Text = "Dirección:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(97, 70);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(196, 21);
            this.cmbLocalidad.TabIndex = 18;
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "Buenos Aires",
            "",
            "Catamarca",
            "",
            "Chaco",
            "",
            "Chubut",
            "",
            "Córdoba",
            "",
            "Corrientes",
            "",
            "Entre Ríos",
            "",
            "Formosa",
            "",
            "Jujuy",
            "",
            "La Pampa",
            "",
            "La Rioja",
            "",
            "Mendoza",
            "",
            "Misiones",
            "",
            "Neuquén",
            "",
            "Río Negro",
            "",
            "Salta",
            "",
            "San Juan",
            "",
            "San Luis",
            "",
            "Santa Cruz",
            "",
            "Santa Fe",
            "",
            "Santiago del Estero",
            "",
            "Tierra del Fuego, Antártida e Islas del Atlántico Sur",
            "",
            "Tucumán"});
            this.cmbProvincia.Location = new System.Drawing.Point(97, 29);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(196, 21);
            this.cmbProvincia.TabIndex = 17;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblProvincia.Location = new System.Drawing.Point(12, 34);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(66, 16);
            this.lblProvincia.TabIndex = 14;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLocalidad.Location = new System.Drawing.Point(12, 75);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(70, 16);
            this.lblLocalidad.TabIndex = 13;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // grpDatosPer
            // 
            this.grpDatosPer.Controls.Add(this.mskDNI);
            this.grpDatosPer.Controls.Add(this.lblNombre);
            this.grpDatosPer.Controls.Add(this.lblApellido);
            this.grpDatosPer.Controls.Add(this.txtNombre);
            this.grpDatosPer.Controls.Add(this.txtApellido);
            this.grpDatosPer.Controls.Add(this.lblDNI);
            this.grpDatosPer.Location = new System.Drawing.Point(16, 12);
            this.grpDatosPer.Name = "grpDatosPer";
            this.grpDatosPer.Size = new System.Drawing.Size(311, 156);
            this.grpDatosPer.TabIndex = 7;
            this.grpDatosPer.TabStop = false;
            this.grpDatosPer.Text = "Datos Personales";
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(97, 113);
            this.mskDNI.Mask = "99999999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(65, 20);
            this.mskDNI.TabIndex = 14;
            this.mskDNI.ValidatingType = typeof(int);
            this.mskDNI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDNI_MaskInputRejected);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblNombre.Location = new System.Drawing.Point(13, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblApellido.Location = new System.Drawing.Point(13, 32);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 20);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(97, 31);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(196, 20);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDNI.Location = new System.Drawing.Point(13, 111);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 16);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "DNI:";
            // 
            // btnGuardarPer
            // 
            this.btnGuardarPer.Location = new System.Drawing.Point(550, 380);
            this.btnGuardarPer.Name = "btnGuardarPer";
            this.btnGuardarPer.Size = new System.Drawing.Size(94, 23);
            this.btnGuardarPer.TabIndex = 8;
            this.btnGuardarPer.Text = "Guardar Datos";
            this.btnGuardarPer.UseVisualStyleBackColor = true;
            this.btnGuardarPer.Click += new System.EventHandler(this.btnGuardarPer_Click);
            // 
            // grpContacto
            // 
            this.grpContacto.Controls.Add(this.grpRedes);
            this.grpContacto.Controls.Add(this.txtTelefono);
            this.grpContacto.Controls.Add(this.lblTelefono);
            this.grpContacto.Controls.Add(this.txtMail);
            this.grpContacto.Controls.Add(this.lblMail);
            this.grpContacto.Location = new System.Drawing.Point(333, 12);
            this.grpContacto.Name = "grpContacto";
            this.grpContacto.Size = new System.Drawing.Size(311, 351);
            this.grpContacto.TabIndex = 9;
            this.grpContacto.TabStop = false;
            this.grpContacto.Text = "Contacto";
            // 
            // grpRedes
            // 
            this.grpRedes.Controls.Add(this.txtFacebook);
            this.grpRedes.Controls.Add(this.txtTikTok);
            this.grpRedes.Controls.Add(this.txtInstagram);
            this.grpRedes.Controls.Add(this.txtX);
            this.grpRedes.Controls.Add(this.txtTelegram);
            this.grpRedes.Controls.Add(this.lblTikTok);
            this.grpRedes.Controls.Add(this.lblTelegram);
            this.grpRedes.Controls.Add(this.lblX);
            this.grpRedes.Controls.Add(this.lblInstagram);
            this.grpRedes.Controls.Add(this.lblFacebook);
            this.grpRedes.Location = new System.Drawing.Point(19, 103);
            this.grpRedes.Name = "grpRedes";
            this.grpRedes.Size = new System.Drawing.Size(269, 230);
            this.grpRedes.TabIndex = 4;
            this.grpRedes.TabStop = false;
            this.grpRedes.Text = "Redes Sociales";
            // 
            // txtFacebook
            // 
            this.txtFacebook.Location = new System.Drawing.Point(92, 175);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(159, 20);
            this.txtFacebook.TabIndex = 9;
            this.txtFacebook.TextChanged += new System.EventHandler(this.txtFacebook_TextChanged);
            // 
            // txtTikTok
            // 
            this.txtTikTok.Location = new System.Drawing.Point(92, 139);
            this.txtTikTok.Name = "txtTikTok";
            this.txtTikTok.Size = new System.Drawing.Size(159, 20);
            this.txtTikTok.TabIndex = 8;
            this.txtTikTok.TextChanged += new System.EventHandler(this.txtTikTok_TextChanged);
            // 
            // txtInstagram
            // 
            this.txtInstagram.Location = new System.Drawing.Point(92, 103);
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.Size = new System.Drawing.Size(159, 20);
            this.txtInstagram.TabIndex = 7;
            this.txtInstagram.TextChanged += new System.EventHandler(this.txtInstagram_TextChanged);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(92, 69);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(159, 20);
            this.txtX.TabIndex = 6;
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // txtTelegram
            // 
            this.txtTelegram.Location = new System.Drawing.Point(92, 32);
            this.txtTelegram.Name = "txtTelegram";
            this.txtTelegram.Size = new System.Drawing.Size(159, 20);
            this.txtTelegram.TabIndex = 5;
            this.txtTelegram.TextChanged += new System.EventHandler(this.txtTelegram_TextChanged);
            // 
            // lblTikTok
            // 
            this.lblTikTok.AutoSize = true;
            this.lblTikTok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblTikTok.Location = new System.Drawing.Point(16, 140);
            this.lblTikTok.Name = "lblTikTok";
            this.lblTikTok.Size = new System.Drawing.Size(53, 16);
            this.lblTikTok.TabIndex = 4;
            this.lblTikTok.Text = "TikTok:";
            // 
            // lblTelegram
            // 
            this.lblTelegram.AutoSize = true;
            this.lblTelegram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblTelegram.Location = new System.Drawing.Point(16, 35);
            this.lblTelegram.Name = "lblTelegram";
            this.lblTelegram.Size = new System.Drawing.Size(69, 16);
            this.lblTelegram.TabIndex = 3;
            this.lblTelegram.Text = "Telegram:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblX.Location = new System.Drawing.Point(17, 70);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(65, 16);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X (Twiter):";
            // 
            // lblInstagram
            // 
            this.lblInstagram.AutoSize = true;
            this.lblInstagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblInstagram.Location = new System.Drawing.Point(17, 104);
            this.lblInstagram.Name = "lblInstagram";
            this.lblInstagram.Size = new System.Drawing.Size(69, 16);
            this.lblInstagram.TabIndex = 1;
            this.lblInstagram.Text = "Instagram:";
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblFacebook.Location = new System.Drawing.Point(17, 179);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(72, 16);
            this.lblFacebook.TabIndex = 0;
            this.lblFacebook.Text = "Facebook:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(87, 65);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(201, 20);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblTelefono.Location = new System.Drawing.Point(16, 69);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 16);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(87, 29);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(201, 20);
            this.txtMail.TabIndex = 1;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblMail.Location = new System.Drawing.Point(16, 30);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 16);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(388, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(469, 380);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.chkEstado.Location = new System.Drawing.Point(160, 380);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(72, 20);
            this.chkEstado.TabIndex = 23;
            this.chkEstado.Text = "Inactivo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblEstadoUsuario
            // 
            this.lblEstadoUsuario.AutoSize = true;
            this.lblEstadoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblEstadoUsuario.Location = new System.Drawing.Point(29, 380);
            this.lblEstadoUsuario.Name = "lblEstadoUsuario";
            this.lblEstadoUsuario.Size = new System.Drawing.Size(125, 16);
            this.lblEstadoUsuario.TabIndex = 24;
            this.lblEstadoUsuario.Text = "Estado del Usuario:";
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 415);
            this.Controls.Add(this.lblEstadoUsuario);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpContacto);
            this.Controls.Add(this.btnGuardarPer);
            this.Controls.Add(this.grpDatosPer);
            this.Controls.Add(this.grpDomicilio);
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal";
            this.grpDomicilio.ResumeLayout(false);
            this.grpDomicilio.PerformLayout();
            this.grpDatosPer.ResumeLayout(false);
            this.grpDatosPer.PerformLayout();
            this.grpContacto.ResumeLayout(false);
            this.grpContacto.PerformLayout();
            this.grpRedes.ResumeLayout(false);
            this.grpRedes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDomicilio;
        private System.Windows.Forms.GroupBox grpDatosPer;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.TextBox txtGeo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblGeo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.MaskedTextBox mskDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnGuardarPer;
        private System.Windows.Forms.GroupBox grpContacto;
        private System.Windows.Forms.GroupBox grpRedes;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblInstagram;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.Label lblTikTok;
        private System.Windows.Forms.Label lblTelegram;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtInstagram;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtTelegram;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.TextBox txtTikTok;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lblEstadoUsuario;
    }
}