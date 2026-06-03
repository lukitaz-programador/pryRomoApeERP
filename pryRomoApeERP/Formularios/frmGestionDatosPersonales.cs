using pryRomoApeERP.Base_de_Datos;
using pryRomoApeERP.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRomoApeERP
{
    public partial class frmGestionDatosPersonales : Form
    {
        private string mailUsuario;
        private Archivo archivoBD;
        private ConexionDB conexionBD;
        private RegistroAuditoria registroAuditoria;

        private void frmGestionDatosPersonales_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            chkEstado.Checked = false;
            chkEstado.Text = "Inactivo";

            chkResidencia.Checked = false;
            chkResidencia.Text = "No, no reside";

            btnGuardarPer.Enabled = false;

            this.AcceptButton = btnGuardarPer;
            this.CancelButton = btnSalir;
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
                ValidarDNI() &&
                txtDireccion.Text.Trim() != "" &&
                txtGeo.Text.Trim() != "" &&
                cmbProvincia.SelectedIndex != -1 &&
                cmbLocalidad.SelectedIndex != -1 &&
                (
                    txtMail.Text.Trim() != "" ||
                    txtTelefono.Text.Trim() != ""
                );

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

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
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

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
        }

        private void txtTelegram_TextChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
        }

        private void txtInstagram_TextChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
        }

        private void txtTikTok_TextChanged(object sender, EventArgs e)
        {
            ComprobarDatos();
        }

        private void txtFacebook_TextChanged(object sender, EventArgs e)
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

                txtMail.Clear();
                txtTelefono.Clear();

                txtTelegram.Clear();
                txtX.Clear();
                txtInstagram.Clear();
                txtTikTok.Clear();
                txtFacebook.Clear();

                cmbProvincia.SelectedIndex = -1;

                cmbLocalidad.Items.Clear();
                cmbLocalidad.SelectedIndex = -1;

                chkEstado.Checked = false;
                chkResidencia.Checked = false;

                todosLosDatos = false;
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

        
    }
}
