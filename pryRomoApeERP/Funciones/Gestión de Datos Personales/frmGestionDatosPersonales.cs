using pryRomoApeERP.Base_de_Datos;
using pryRomoApeERP.Funciones;
using pryRomoApeERP.Funciones.Gestión_de_Datos_Personales;
using pryRomoApeERP.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;


namespace pryRomoApeERP
{
    public partial class frmGestionDatosPersonales : Form
    {
        private Archivo archivoLocalidades;
        private ConexionDB conexionLocalidades;
        private string mailUsuario;
        private Archivo archivoBD;
        private ConexionDB conexionBD;

        private List<Contacto> contactos =
            new List<Contacto>();

        private List<Ubicacion> ubicaciones =
            new List<Ubicacion>();

        bool todosLosDatos = false;

        public frmGestionDatosPersonales(string mail = "")
        {
            InitializeComponent();

            mailUsuario = mail;

            this.AcceptButton =
                btnGuardarPer;
        }

        private void frmGestionDatosPersonales_Load(
            object sender,
            EventArgs e)
        {
            try
            {
                archivoBD =
                    new Archivo("RomoBD.accdb");

                conexionBD =
                    archivoBD.Conexion;

                archivoLocalidades =
                    new Archivo("LocalidadBD.accdb");

                conexionLocalidades =
                    archivoLocalidades.Conexion;

                InicializarControles();

                CargarProvincias();

                CargarTiposContacto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InicializarControles()
        {
            chkEstado.Checked = false;
            chkEstado.Text = "Inactivo";

            chkResidencia.Checked = false;
            chkResidencia.Text = "No, no reside";

            txtValorContacto.Enabled = false;

            lblFormato.Text =
                "Seleccione un tipo de contacto";

            btnGuardarPer.Enabled = false;

            this.AcceptButton = btnGuardarPer;
            this.CancelButton = btnSalir;
        }

        private void CargarTiposContacto()
        {
            try
            {
                cmbTipoContacto.Items.Clear();

                string sql =
                    "SELECT Descripcion " +
                    "FROM tablaTipoContacto " +
                    "ORDER BY Descripcion";

                using (OleDbCommand cmd =
                    new OleDbCommand(
                        sql,
                        conexionBD.Conexion))
                {
                    using (OleDbDataReader lector =
                        cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            cmbTipoContacto.Items.Add(
                                lector["Descripcion"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar tipos de contacto\n" +
                    ex.Message);
            }
        }

        private void CargarProvincias()
        {
            try
            {
                cmbProvincia.Items.Clear();
                cmbProvincia.SelectedIndex = -1;

                cmbLocalidad.Items.Clear();

                string sql =
                    @"SELECT DISTINCT Provincia
                    FROM tablaLocalidades
                    WHERE Provincia IS NOT NULL
                    ORDER BY Provincia";

                using (OleDbCommand cmd =
                    new OleDbCommand(
                        sql,
                        conexionLocalidades.Conexion))
                {
                    using (OleDbDataReader lector =
                        cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            cmbProvincia.Items.Add(
                                lector["Provincia"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar provincias:\n" +
                    ex.Message);
            }
        }

        private void CargarLocalidades(
            string provincia)
        {
            try
            {
                cmbLocalidad.Items.Clear();

                string sql =
                    @"SELECT DISTINCT Nombre
                    FROM tablaLocalidades
                    WHERE Provincia = ?
                    ORDER BY Nombre";

                using (OleDbCommand cmd =
                    new OleDbCommand(
                        sql,
                        conexionLocalidades.Conexion))
                {
                    cmd.Parameters.AddWithValue(
                        "@Provincia",
                        provincia);

                    using (OleDbDataReader lector =
                        cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            cmbLocalidad.Items.Add(
                                lector["Nombre"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar localidades:\n" +
                    ex.Message);
            }

            cmbLocalidad.AutoCompleteMode =
                AutoCompleteMode.SuggestAppend;

            cmbLocalidad.AutoCompleteSource =
                AutoCompleteSource.ListItems;

            cmbLocalidad.DropDownStyle =
                ComboBoxStyle.DropDown;
        }

        private void AbrirGoogleMaps()
        {
            try
            {
                if (cmbProvincia.SelectedIndex == -1)
                    return;

                if (cmbLocalidad.SelectedIndex == -1)
                    return;

                if (txtDireccion.Text.Trim() == "")
                    return;

                string direccion =
                    $"{txtDireccion.Text}, " +
                    $"{cmbLocalidad.Text}, " +
                    $"{cmbProvincia.Text}";

                string url =
                    "https://www.google.com/maps/search/?api=1&query=" +
                    Uri.EscapeDataString(direccion);

                Process.Start(url);
            }
            catch
            {
            }
        }

        private void ComprobarDatos()
        {
            todosLosDatos =
                txtApellido.Text.Trim() != "" &&
                txtNombre.Text.Trim() != "" &&
                ValidarDNI();

            btnGuardarPer.Enabled =
                todosLosDatos;
        }

        private bool ValidarDNI()
        {
            string dni =
                mskDNI.Text.Trim();

            if (!long.TryParse(
                dni,
                out long numero))
                return false;

            return numero >= 1000000 &&
                   numero <= 99999999;
        }

        private bool ValidarContacto()
        {
            string valor =
                txtValorContacto.Text.Trim();

            switch (cmbTipoContacto.Text)
            {
                case "Email":
                    return valor.Contains("@");

                case "Teléfono":
                case "WhatsApp":
                    return long.TryParse(
                        valor,
                        out _);

                default:
                    return valor.Length > 0;
            }
        }

        private void ActualizarListaUbicaciones()
        {
            lstUbicaciones.DataSource = null;
            lstUbicaciones.DataSource = ubicaciones;
        }

        private void ActualizarListaContactos()
        {
            lstContactos.DataSource = null;
            lstContactos.DataSource = contactos;
        }

        private void txtApellido_TextChanged(
            object sender,
            EventArgs e)
        {
            ComprobarDatos();
        }

        private void txtNombre_TextChanged(
            object sender,
            EventArgs e)
        {
            ComprobarDatos();
        }

        private void mskDNI_TextChanged(
            object sender,
            EventArgs e)
        {
            ComprobarDatos();
        }

        private void cmbProvincia_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            ComprobarDatos();

            if (cmbProvincia.SelectedIndex != -1)
            {
                CargarLocalidades(
                    cmbProvincia.Text);
            }
        }

        private void cmbLocalidad_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            ComprobarDatos();
        }

        private void txtDireccion_TextChanged(
            object sender,
            EventArgs e)
        {
            ComprobarDatos();
        }

        private void txtDireccion_Leave(
            object sender,
            EventArgs e)
        {
            AbrirGoogleMaps();
        }

        private void txtGeo_TextChanged(
            object sender,
            EventArgs e)
        {
            ComprobarDatos();
        }

        private void btnGuardarPer_Click(
            object sender,
            EventArgs e)
        {
            DialogResult respuesta =
    MessageBox.Show(
        "¿Desea guardar los datos personales?",
        "Guardar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }
            ComprobarDatos();

            if (!todosLosDatos)
            {
                MessageBox.Show(
                    "Faltan datos obligatorios.");
                return;
            }

            string estado =
                chkEstado.Checked
                ? "Activo"
                : "Inactivo";

            if (MessageBox.Show(
                $"¿Desea guardar los datos con estado '{estado}'?",
                "Guardar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Datos guardados correctamente.");
            }
        }

        private void btnLimpiar_Click(
    object sender,
    EventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show(
                    "¿Desea limpiar todos los datos cargados?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            txtApellido.Clear();
            txtNombre.Clear();
            mskDNI.Clear();

            txtDireccion.Clear();
            txtGeo.Clear();

            cmbProvincia.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;

            contactos.Clear();
            ubicaciones.Clear();

            ActualizarListaContactos();
            ActualizarListaUbicaciones();
        }

        private void btnSalir_Click(object sender,EventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show(
                    "¿Desea salir sin guardar los cambios?",
                    "Salir",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void chkEstado_CheckedChanged(
            object sender,
            EventArgs e)
        {
            chkEstado.Text =
                chkEstado.Checked
                ? "Activo"
                : "Inactivo";
        }

        private void chkResidencia_CheckedChanged(
            object sender,
            EventArgs e)
        {
            chkResidencia.Text =
                chkResidencia.Checked
                ? "Sí, reside"
                : "No, no reside";
        }

        // UBICACIONES

        private void btnAgregarUbicacion_Click(
            object sender,
            EventArgs e)
        {
            if (cmbProvincia.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione una provincia");
                return;
            }

            if (cmbLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione una localidad");
                return;
            }

            Ubicacion nueva =
                new Ubicacion();

            nueva.Provincia =
                cmbProvincia.Text;

            nueva.Localidad =
                cmbLocalidad.Text;

            nueva.Direccion =
                txtDireccion.Text;

            nueva.Geo =
                txtGeo.Text;

            nueva.Residencia =
                chkResidencia.Checked;

            if (ubicaciones.Any(x =>
                x.Provincia == nueva.Provincia &&
                x.Localidad == nueva.Localidad &&
                x.Direccion == nueva.Direccion))
            {
                MessageBox.Show(
                    "La ubicación ya existe");
                return;
            }

            ubicaciones.Add(nueva);

            ActualizarListaUbicaciones();

            txtDireccion.Clear();
            txtGeo.Clear();
            chkResidencia.Checked = false;
        }

        private void btnEliminarUbicacion_Click(
            object sender,
            EventArgs e)
        {
            if (lstUbicaciones.SelectedItem is Ubicacion ubicacion)
            {
                ubicaciones.Remove(
                    ubicacion);

                ActualizarListaUbicaciones();
            }
        }

        private void btnModificarUbicacion_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lstUbicaciones_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (lstUbicaciones.SelectedItem is Ubicacion ubicacion)
            {
                cmbProvincia.Text =
                    ubicacion.Provincia;

                CargarLocalidades(
                    ubicacion.Provincia);

                cmbLocalidad.Text =
                    ubicacion.Localidad;

                txtDireccion.Text =
                    ubicacion.Direccion;

                txtGeo.Text =
                    ubicacion.Geo;

                chkResidencia.Checked =
                    ubicacion.Residencia;
            }
        }

        // CONTACTOS

        private void btnAgregarContacto_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarContacto())
            {
                MessageBox.Show(
                    "Formato inválido");
                return;
            }

            if (cmbTipoContacto.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un tipo");
                return;
            }

            if (txtValorContacto.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese un valor");
                return;
            }

            Contacto nuevo =
                new Contacto();

            nuevo.TipoContacto =
                cmbTipoContacto.Text;

            nuevo.Valor =
                txtValorContacto.Text;

            if (contactos.Any(x =>
                x.TipoContacto == nuevo.TipoContacto &&
                x.Valor == nuevo.Valor))
            {
                MessageBox.Show(
                    "El contacto ya existe");
                return;
            }

            contactos.Add(nuevo);

            ActualizarListaContactos();

            cmbTipoContacto.SelectedIndex = -1;
            txtValorContacto.Clear();
        }

        private void btnEliminarContacto_Click(
            object sender,
            EventArgs e)
        {
            if (lstContactos.SelectedItem is Contacto contacto)
            {
                contactos.Remove(contacto);

                ActualizarListaContactos();
            }
        }

        private void btnModificarContacto_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lstContactos_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (lstContactos.SelectedItem is Contacto contacto)
            {
                cmbTipoContacto.Text =
                    contacto.TipoContacto;

                txtValorContacto.Text =
                    contacto.Valor;
            }
        }

        private void cmbLocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (cmbLocalidad.Items.Count > 0)
                {
                    if (cmbLocalidad.SelectedIndex == -1)
                    {
                        cmbLocalidad.SelectedIndex = 0;
                    }
                }

                txtDireccion.Focus();
            }
        }

        private void cmbTipoContacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValorContacto.Clear();

            if (cmbTipoContacto.SelectedIndex == -1)
            {
                txtValorContacto.Enabled = false;

                lblFormato.Text =
                    "Seleccione un tipo de contacto";

                return;
            }

            txtValorContacto.Enabled = true;

            switch (cmbTipoContacto.Text)
            {
                case "Email":
                    lblFormato.Text =
                        "Ej: usuario@gmail.com";
                    break;

                case "Teléfono":
                    lblFormato.Text =
                        "Ej: 3511234567";
                    break;

                case "WhatsApp":
                    lblFormato.Text =
                        "Ej: 3511234567";
                    break;

                case "Telegram":
                    lblFormato.Text =
                        "Ej: @usuario";
                    break;

                case "Instagram":
                    lblFormato.Text =
                        "Ej: @usuario";
                    break;

                case "Facebook":
                    lblFormato.Text =
                        "Ej: usuario";
                    break;

                case "TikTok":
                    lblFormato.Text =
                        "Ej: @usuario";
                    break;

                case "X":
                    lblFormato.Text =
                        "Ej: @usuario";
                    break;

                case "LinkedIn":
                    lblFormato.Text =
                        "Ej: linkedin.com/in/usuario";
                    break;

                default:
                    lblFormato.Text =
                        "Ingrese el valor";
                    break;
            }

            txtValorContacto.Focus();
        }

        private void btnBuscarUbicacion_Click(object sender, EventArgs e)
        {
            if (cmbProvincia.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione una provincia.");
                return;
            }

            if (cmbLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione una localidad.");
                return;
            }

            if (txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese una dirección.");
                return;
            }

            string busqueda =
                $"{txtDireccion.Text}, " +
                $"{cmbLocalidad.Text}, " +
                $"{cmbProvincia.Text}";

            string url =
                "https://www.google.com/maps/search/?api=1&query=" +
                Uri.EscapeDataString(busqueda);

            System.Diagnostics.Process.Start(url);
        }
    }
}