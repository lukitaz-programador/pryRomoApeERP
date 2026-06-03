namespace pryRomoApeERP
{
    partial class frmGestionDatosPersonales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionDatosPersonales));
            this.grpDomicilio = new System.Windows.Forms.GroupBox();
            this.lstUbicaciones = new System.Windows.Forms.ListBox();
            this.btnAgregarUbicacion = new System.Windows.Forms.Button();
            this.chkResidencia = new System.Windows.Forms.CheckBox();
            this.btnModificarUbicacion = new System.Windows.Forms.Button();
            this.lblResidancia = new System.Windows.Forms.Label();
            this.btnEliminarUbicacion = new System.Windows.Forms.Button();
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
            this.lblEstadoUsuario = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnGuardarPer = new System.Windows.Forms.Button();
            this.grpContacto = new System.Windows.Forms.GroupBox();
            this.grpContactos = new System.Windows.Forms.GroupBox();
            this.btnAgregarContacto = new System.Windows.Forms.Button();
            this.btnModificarContacto = new System.Windows.Forms.Button();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.lstContactos = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTipoContacto = new System.Windows.Forms.Label();
            this.cmbTipoContacto = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValorContacto = new System.Windows.Forms.TextBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.grpDomicilio.SuspendLayout();
            this.grpDatosPer.SuspendLayout();
            this.grpContacto.SuspendLayout();
            this.grpContactos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDomicilio
            // 
            this.grpDomicilio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpDomicilio.Controls.Add(this.lstUbicaciones);
            this.grpDomicilio.Controls.Add(this.btnAgregarUbicacion);
            this.grpDomicilio.Controls.Add(this.chkResidencia);
            this.grpDomicilio.Controls.Add(this.btnModificarUbicacion);
            this.grpDomicilio.Controls.Add(this.lblResidancia);
            this.grpDomicilio.Controls.Add(this.btnEliminarUbicacion);
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
            this.grpDomicilio.Size = new System.Drawing.Size(311, 293);
            this.grpDomicilio.TabIndex = 6;
            this.grpDomicilio.TabStop = false;
            this.grpDomicilio.Text = "Domicilio";
            // 
            // lstUbicaciones
            // 
            this.lstUbicaciones.FormattingEnabled = true;
            this.lstUbicaciones.Location = new System.Drawing.Point(18, 212);
            this.lstUbicaciones.Name = "lstUbicaciones";
            this.lstUbicaciones.Size = new System.Drawing.Size(256, 30);
            this.lstUbicaciones.TabIndex = 4;
            // 
            // btnAgregarUbicacion
            // 
            this.btnAgregarUbicacion.Location = new System.Drawing.Point(222, 253);
            this.btnAgregarUbicacion.Name = "btnAgregarUbicacion";
            this.btnAgregarUbicacion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUbicacion.TabIndex = 6;
            this.btnAgregarUbicacion.Text = "Agregar";
            this.btnAgregarUbicacion.UseVisualStyleBackColor = true;
            this.btnAgregarUbicacion.Click += new System.EventHandler(this.btnAgregarUbicacion_Click);
            // 
            // chkResidencia
            // 
            this.chkResidencia.AutoSize = true;
            this.chkResidencia.Location = new System.Drawing.Point(150, 189);
            this.chkResidencia.Name = "chkResidencia";
            this.chkResidencia.Size = new System.Drawing.Size(89, 17);
            this.chkResidencia.TabIndex = 24;
            this.chkResidencia.Text = "No, no reside";
            this.chkResidencia.UseVisualStyleBackColor = true;
            this.chkResidencia.CheckedChanged += new System.EventHandler(this.chkResidencia_CheckedChanged);
            // 
            // btnModificarUbicacion
            // 
            this.btnModificarUbicacion.Location = new System.Drawing.Point(141, 254);
            this.btnModificarUbicacion.Name = "btnModificarUbicacion";
            this.btnModificarUbicacion.Size = new System.Drawing.Size(75, 23);
            this.btnModificarUbicacion.TabIndex = 5;
            this.btnModificarUbicacion.Text = "Modificar";
            this.btnModificarUbicacion.UseVisualStyleBackColor = true;
            this.btnModificarUbicacion.Click += new System.EventHandler(this.btnModificarUbicacion_Click);
            // 
            // lblResidancia
            // 
            this.lblResidancia.AutoSize = true;
            this.lblResidancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblResidancia.Location = new System.Drawing.Point(13, 189);
            this.lblResidancia.Name = "lblResidancia";
            this.lblResidancia.Size = new System.Drawing.Size(130, 16);
            this.lblResidancia.TabIndex = 23;
            this.lblResidancia.Text = "Reside actualmente:";
            // 
            // btnEliminarUbicacion
            // 
            this.btnEliminarUbicacion.Location = new System.Drawing.Point(60, 254);
            this.btnEliminarUbicacion.Name = "btnEliminarUbicacion";
            this.btnEliminarUbicacion.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUbicacion.TabIndex = 4;
            this.btnEliminarUbicacion.Text = "Eliminar";
            this.btnEliminarUbicacion.UseVisualStyleBackColor = true;
            this.btnEliminarUbicacion.Click += new System.EventHandler(this.btnEliminarUbicacion_Click);
            // 
            // txtGeo
            // 
            this.txtGeo.Location = new System.Drawing.Point(97, 149);
            this.txtGeo.Name = "txtGeo";
            this.txtGeo.Size = new System.Drawing.Size(196, 20);
            this.txtGeo.TabIndex = 22;
            this.txtGeo.TextChanged += new System.EventHandler(this.txtGeo_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(97, 110);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(196, 20);
            this.txtDireccion.TabIndex = 21;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblGeo
            // 
            this.lblGeo.AutoSize = true;
            this.lblGeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblGeo.Location = new System.Drawing.Point(12, 154);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Size = new System.Drawing.Size(36, 16);
            this.lblGeo.TabIndex = 20;
            this.lblGeo.Text = "Geo:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDireccion.Location = new System.Drawing.Point(12, 115);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 16);
            this.lblDireccion.TabIndex = 19;
            this.lblDireccion.Text = "Dirección:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(97, 68);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(196, 21);
            this.cmbLocalidad.TabIndex = 18;
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
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
            this.lblLocalidad.Location = new System.Drawing.Point(12, 73);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(70, 16);
            this.lblLocalidad.TabIndex = 13;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // grpDatosPer
            // 
            this.grpDatosPer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpDatosPer.Controls.Add(this.mskDNI);
            this.grpDatosPer.Controls.Add(this.lblNombre);
            this.grpDatosPer.Controls.Add(this.lblEstadoUsuario);
            this.grpDatosPer.Controls.Add(this.lblApellido);
            this.grpDatosPer.Controls.Add(this.chkEstado);
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
            this.mskDNI.Location = new System.Drawing.Point(97, 104);
            this.mskDNI.Mask = "99999999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(57, 20);
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
            // lblEstadoUsuario
            // 
            this.lblEstadoUsuario.AutoSize = true;
            this.lblEstadoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblEstadoUsuario.Location = new System.Drawing.Point(10, 132);
            this.lblEstadoUsuario.Name = "lblEstadoUsuario";
            this.lblEstadoUsuario.Size = new System.Drawing.Size(125, 16);
            this.lblEstadoUsuario.TabIndex = 24;
            this.lblEstadoUsuario.Text = "Estado del Usuario:";
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
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.chkEstado.Location = new System.Drawing.Point(141, 130);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(72, 20);
            this.chkEstado.TabIndex = 23;
            this.chkEstado.Text = "Inactivo";
            this.chkEstado.UseVisualStyleBackColor = true;
            this.chkEstado.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);
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
            this.lblDNI.Location = new System.Drawing.Point(15, 107);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 16);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "DNI:";
            // 
            // btnGuardarPer
            // 
            this.btnGuardarPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardarPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnGuardarPer.Location = new System.Drawing.Point(501, 473);
            this.btnGuardarPer.Name = "btnGuardarPer";
            this.btnGuardarPer.Size = new System.Drawing.Size(143, 34);
            this.btnGuardarPer.TabIndex = 8;
            this.btnGuardarPer.Text = "Guardar Datos";
            this.btnGuardarPer.UseVisualStyleBackColor = false;
            this.btnGuardarPer.Click += new System.EventHandler(this.btnGuardarPer_Click);
            // 
            // grpContacto
            // 
            this.grpContacto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpContacto.Controls.Add(this.grpContactos);
            this.grpContacto.Location = new System.Drawing.Point(333, 12);
            this.grpContacto.Name = "grpContacto";
            this.grpContacto.Size = new System.Drawing.Size(571, 455);
            this.grpContacto.TabIndex = 9;
            this.grpContacto.TabStop = false;
            this.grpContacto.Text = "Contacto";
            // 
            // grpContactos
            // 
            this.grpContactos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpContactos.Controls.Add(this.lblFormato);
            this.grpContactos.Controls.Add(this.txtValorContacto);
            this.grpContactos.Controls.Add(this.lblValor);
            this.grpContactos.Controls.Add(this.cmbTipoContacto);
            this.grpContactos.Controls.Add(this.lblTipoContacto);
            this.grpContactos.Controls.Add(this.btnAgregarContacto);
            this.grpContactos.Controls.Add(this.btnModificarContacto);
            this.grpContactos.Controls.Add(this.btnEliminarContacto);
            this.grpContactos.Controls.Add(this.lstContactos);
            this.grpContactos.Location = new System.Drawing.Point(19, 19);
            this.grpContactos.Name = "grpContactos";
            this.grpContactos.Size = new System.Drawing.Size(497, 420);
            this.grpContactos.TabIndex = 4;
            this.grpContactos.TabStop = false;
            this.grpContactos.Text = "Contactos";
            // 
            // btnAgregarContacto
            // 
            this.btnAgregarContacto.Location = new System.Drawing.Point(188, 395);
            this.btnAgregarContacto.Name = "btnAgregarContacto";
            this.btnAgregarContacto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarContacto.TabIndex = 3;
            this.btnAgregarContacto.Text = "Agregar";
            this.btnAgregarContacto.UseVisualStyleBackColor = true;
            this.btnAgregarContacto.Click += new System.EventHandler(this.btnAgregarContacto_Click);
            // 
            // btnModificarContacto
            // 
            this.btnModificarContacto.Location = new System.Drawing.Point(107, 395);
            this.btnModificarContacto.Name = "btnModificarContacto";
            this.btnModificarContacto.Size = new System.Drawing.Size(75, 23);
            this.btnModificarContacto.TabIndex = 2;
            this.btnModificarContacto.Text = "Modificar";
            this.btnModificarContacto.UseVisualStyleBackColor = true;
            this.btnModificarContacto.Click += new System.EventHandler(this.btnModificarContacto_Click);
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.Location = new System.Drawing.Point(26, 394);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarContacto.TabIndex = 1;
            this.btnEliminarContacto.Text = "Eliminar";
            this.btnEliminarContacto.UseVisualStyleBackColor = true;
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // lstContactos
            // 
            this.lstContactos.FormattingEnabled = true;
            this.lstContactos.Location = new System.Drawing.Point(7, 111);
            this.lstContactos.Name = "lstContactos";
            this.lstContactos.Size = new System.Drawing.Size(386, 277);
            this.lstContactos.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnLimpiar.Location = new System.Drawing.Point(420, 473);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 34);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSalir.Location = new System.Drawing.Point(339, 473);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTipoContacto
            // 
            this.lblTipoContacto.AutoSize = true;
            this.lblTipoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblTipoContacto.Location = new System.Drawing.Point(26, 20);
            this.lblTipoContacto.Name = "lblTipoContacto";
            this.lblTipoContacto.Size = new System.Drawing.Size(92, 16);
            this.lblTipoContacto.TabIndex = 4;
            this.lblTipoContacto.Text = "Tipo contacto:";
            // 
            // cmbTipoContacto
            // 
            this.cmbTipoContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoContacto.FormattingEnabled = true;
            this.cmbTipoContacto.Location = new System.Drawing.Point(129, 20);
            this.cmbTipoContacto.Name = "cmbTipoContacto";
            this.cmbTipoContacto.Size = new System.Drawing.Size(175, 21);
            this.cmbTipoContacto.TabIndex = 5;
            this.cmbTipoContacto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoContacto_SelectedIndexChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblValor.Location = new System.Drawing.Point(26, 58);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 16);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor:";
            // 
            // txtValorContacto
            // 
            this.txtValorContacto.Location = new System.Drawing.Point(129, 58);
            this.txtValorContacto.Name = "txtValorContacto";
            this.txtValorContacto.Size = new System.Drawing.Size(175, 20);
            this.txtValorContacto.TabIndex = 7;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(126, 81);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(45, 13);
            this.lblFormato.TabIndex = 8;
            this.lblFormato.Text = "Formato";
            // 
            // frmGestionDatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(954, 516);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grpContacto);
            this.Controls.Add(this.btnGuardarPer);
            this.Controls.Add(this.grpDatosPer);
            this.Controls.Add(this.grpDomicilio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionDatosPersonales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de datos personales";
            this.Load += new System.EventHandler(this.frmGestionDatosPersonales_Load);
            this.grpDomicilio.ResumeLayout(false);
            this.grpDomicilio.PerformLayout();
            this.grpDatosPer.ResumeLayout(false);
            this.grpDatosPer.PerformLayout();
            this.grpContacto.ResumeLayout(false);
            this.grpContactos.ResumeLayout(false);
            this.grpContactos.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox grpContactos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lblEstadoUsuario;
        private System.Windows.Forms.Label lblResidancia;
        private System.Windows.Forms.CheckBox chkResidencia;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarContacto;
        private System.Windows.Forms.Button btnModificarContacto;
        private System.Windows.Forms.Button btnEliminarContacto;
        private System.Windows.Forms.ListBox lstContactos;
        private System.Windows.Forms.ListBox lstUbicaciones;
        private System.Windows.Forms.Button btnAgregarUbicacion;
        private System.Windows.Forms.Button btnModificarUbicacion;
        private System.Windows.Forms.Button btnEliminarUbicacion;
        private System.Windows.Forms.TextBox txtValorContacto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cmbTipoContacto;
        private System.Windows.Forms.Label lblTipoContacto;
        private System.Windows.Forms.Label lblFormato;
    }
}