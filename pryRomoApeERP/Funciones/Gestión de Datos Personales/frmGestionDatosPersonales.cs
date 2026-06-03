using pryRomoApeERP.Base_de_Datos;
using pryRomoApeERP.Funciones;
using pryRomoApeERP.Funciones.Gestión_de_Datos_Personales;
using pryRomoApeERP.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private RegistroAuditoria registroAuditoria;
        private List<Contacto> contactos = new List<Contacto>();
        private List<Ubicacion> ubicaciones = new List<Ubicacion>();

        private void frmGestionDatosPersonales_Load(object sender,EventArgs e)
        {
            try
            {
                archivoBD =
                new Archivo("RomoBD.accdb");

                conexionBD =
                    archivoBD.Conexion;

                archivoLocalidades =
                    new Archivo("LocalidadesBD.accdb");

                conexionLocalidades =
                    archivoLocalidades.Conexion;

                InicializarControles();

                CargarProvincias();
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
        private void CargarProvincias()
        {
            try
            {
                cmbProvincia.Items.Clear();
                cmbProvincia.SelectedIndex = -1;
                cmbLocalidad.Items.Clear();

                string sql =
                    "SELECT DISTINCT Provincia " +
                    "FROM tablaLocalidades " +
                    "ORDER BY Provincia";

                OleDbCommand cmd =
                    new OleDbCommand(
                        sql,
                        conexionLocalidades.Conexion);

                OleDbDataReader lector =
                    cmd.ExecuteReader();

                while (lector.Read())
                {
                    cmbProvincia.Items.Add(
                        lector["Provincia"].ToString());
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar provincias:\n" +
                    ex.Message);
            }
        }

        private void CargarLocalidades(string provincia)
        {
            try
            {
                cmbLocalidad.Items.Clear();

                string sql =
                    "SELECT Nombre " +
                    "FROM tablaLocalidades " +
                    "WHERE Provincia = ? " +
                    "ORDER BY Nombre";

                OleDbCommand cmd =
                    new OleDbCommand(
                        sql,
                        conexionLocalidades.Conexion);

                cmd.Parameters.AddWithValue(
                    "@Provincia",
                    provincia);

                OleDbDataReader lector =
                    cmd.ExecuteReader();

                while (lector.Read())
                {
                    cmbLocalidad.Items.Add(
                        lector["Nombre"].ToString());
                }

                lector.Close();
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
        }

        public frmGestionDatosPersonales(string mail = "")
        {
            InitializeComponent();

            mailUsuario = mail;

            this.AcceptButton = btnGuardarPer;
        }

        bool todosLosDatos = false;

        private void ComprobarDatos()
        {
            todosLosDatos =
                txtApellido.Text.Trim() != "" &&
                txtNombre.Text.Trim() != "" &&
                ValidarDNI();

            btnGuardarPer.Enabled = todosLosDatos;
        }

        private bool ValidarDNI()
        {
            string dni = mskDNI.Text.Trim();

            if (!long.TryParse(dni, out long numero))
                return false;

            return numero >= 1000000 &&
                   numero <= 99999999;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
        }

        private void mskDNI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ComprobarDatos();
        }

        private void cmbProvincia_SelectedIndexChanged(object sender,EventArgs e)
        {
            ComprobarDatos();

            if (cmbProvincia.SelectedIndex != -1)
            {
                CargarLocalidades(
                    cmbProvincia.Text);
            }
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
        }

        private void txtGeo_TextChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
        }

        private void btnGuardarPer_Click(object sender, EventArgs e)
        {
            ComprobarDatos();

            if (!todosLosDatos)
            {
                MessageBox.Show(
                    "Faltan datos obligatorios por completar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string estado = chkEstado.Checked ? "Activo" : "Inactivo";

            if (MessageBox.Show(
                $"¿Desea guardar los datos con estado '{estado}'?",
                "Guardar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // AQUÍ VA EL GUARDADO EN ACCESS

                MessageBox.Show(
                    "Datos guardados correctamente.",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnGuardarPer.Enabled = false;

                chkEstado.Text = "Inactivo";
                chkResidencia.Text = "No, no reside";
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Desea limpiar los datos ingresados?",
                "Limpiar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtApellido.Clear();
                txtNombre.Clear();
                mskDNI.Clear();

                txtDireccion.Clear();
                txtGeo.Clear();

                cmbProvincia.SelectedIndex = -1;

                cmbLocalidad.Items.Clear();
                cmbLocalidad.SelectedIndex = -1;

                chkEstado.Checked = false;
                chkResidencia.Checked = false;

                todosLosDatos = false;
                btnGuardarPer.Enabled = false;

                chkEstado.Text = "Inactivo";
                chkResidencia.Text = "No, no reside";
            }
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEstado.Checked) 
            { 
                chkEstado.Text = "Activo";
            }
            else
            {
                chkEstado.Text = "Inactivo";
            }
        }

        private void chkResidencia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkResidencia.Checked)
            {
                chkResidencia.Text = "Sí, reside";
            }
            else
            {
                chkResidencia.Text = "No, no reside";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Desea salir de la gestión de datos personales?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mskDNI_TextChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
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

//BOTONES DE UBICACIONES
        private void btnAgregarUbicacion_Click(object sender, EventArgs e)
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

            ubicaciones.Add(nueva);

            ActualizarListaUbicaciones();
        }
        private void lstUbicaciones_SelectedIndexChanged(object sender,EventArgs e)
        {
            if (lstUbicaciones.SelectedItem is Ubicacion ubicacion)
            {
                cmbProvincia.Text = ubicacion.Provincia;

                CargarLocalidades(
                    ubicacion.Provincia);

                cmbLocalidad.Text = ubicacion.Localidad;

                txtDireccion.Text =
                    ubicacion.Direccion;

                txtGeo.Text =
                    ubicacion.Geo;

                chkResidencia.Checked =
                    ubicacion.Residencia;
            }
        }
        private void btnEliminarUbicacion_Click(object sender, EventArgs e)
        {
            if (lstUbicaciones.SelectedItem is Ubicacion ubicacion)
            {
                ubicaciones.Remove(ubicacion);

                ActualizarListaUbicaciones();
            }
        }

        private void btnModificarUbicacion_Click(object sender, EventArgs e)
        {
            if (lstUbicaciones.SelectedItem is Ubicacion ubicacion)
            {
                ubicacion.Provincia =
                    cmbProvincia.Text;

                ubicacion.Localidad =
                    cmbLocalidad.Text;

                ubicacion.Direccion =
                    txtDireccion.Text;

                ubicacion.Geo =
                    txtGeo.Text;

                ubicacion.Residencia =
                    chkResidencia.Checked;

                ActualizarListaUbicaciones();
            }
        }

//BOTONES DE CONTACTOS
        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            if (!ValidarContacto())
            {
                MessageBox.Show(
                    "Formato de contacto inválido.");

                return;
            }

            if (cmbTipoContacto.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un tipo de contacto.");

                return;
            }

            if (txtValorContacto.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese un valor.");

                return;
            }
            Contacto nuevo =
            new Contacto();

            nuevo.TipoContacto =
                cmbTipoContacto.Text;

            nuevo.Valor =
                txtValorContacto.Text;

            contactos.Add(nuevo);

            ActualizarListaContactos();
            
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarContacto_Click(object sender, EventArgs e)
        {

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
        private void cmbTipoContacto_SelectedIndexChanged(
    object sender,
    EventArgs e)
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
                        "Ejemplo: usuario@dominio.com";
                    break;

                case "Teléfono":
                    lblFormato.Text =
                        "Ejemplo: 3511234567";
                    break;

                case "WhatsApp":
                    lblFormato.Text =
                        "Ejemplo: 3511234567";
                    break;

                case "Telegram":
                    lblFormato.Text =
                        "Ejemplo: @usuario";
                    break;

                case "Instagram":
                case "Facebook":
                case "TikTok":
                case "X":
                    lblFormato.Text =
                        "Ejemplo: @usuario";
                    break;

                case "LinkedIn":
                    lblFormato.Text =
                        "Ejemplo: linkedin.com/in/usuario";
                    break;
            }
        }
    }
}
