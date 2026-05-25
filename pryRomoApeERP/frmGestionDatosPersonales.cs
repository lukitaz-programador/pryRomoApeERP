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
        public frmGestionDatosPersonales()
        {
            InitializeComponent();
        }

        bool todosLosDatos = false;

        private void ComprobarDatos()
        {
            if (txtApellido.Text != "" && txtNombre.Text != "" 
                && mskDNI.Text != "" && txtDireccion.Text != "" 
                && txtTelefono.Text != "" && txtGeo.Text != ""
                && txtMail.Text != ""
                && cmbLocalidad.SelectedIndex != -1
                &&cmbProvincia.SelectedIndex != -1
                && (txtFacebook.Text != "" || txtInstagram.Text != ""
                || txtTelegram.Text != "" || txtTikTok.Text != ""
                || txtX.Text != ""))
            {
                todosLosDatos = true;
            }
            else
            {
                todosLosDatos = false;
            }
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

            switch (cmbProvincia.SelectedIndex)
            {
                case 0:
                    cmbLocalidad.Items.Clear();
                    cmbLocalidad.Items.Add("La Plata");
                    cmbLocalidad.Items.Add("Berisso");
                    cmbLocalidad.Items.Add("Ensenada");
                    break;
                case 1:
                    cmbLocalidad.Items.Clear();
                    cmbLocalidad.Items.Add("Mar del Plata");
                    cmbLocalidad.Items.Add("Miramar");
                    cmbLocalidad.Items.Add("Pinamar");
                    break;
                case 2:
                    cmbLocalidad.Items.Clear();
                    cmbLocalidad.Items.Add("Bahía Blanca");
                    cmbLocalidad.Items.Add("Tornquist");
                    cmbLocalidad.Items.Add("Coronel Suárez");
                    break;
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
            if (todosLosDatos == true)
            {
                if (chkEstado.Checked == false)
                {
                    if (MessageBox.Show("¿Desea guardar los datos con el estado 'Inactivo'?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Guardar datos con estado 'Inactivo'
                        MessageBox.Show("Datos guardados con estado 'Inactivo'");
                    }
                    else
                    {
                        // No guardar datos
                    }
                }

            }
            else
            {
                MessageBox.Show("Faltan datos por completar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar el ingreso de datos?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea limpiar los datos ingresados?", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                cmbLocalidad.SelectedIndex = -1;
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
            if (chkEstado.Checked)
            {
                chkEstado.Text = "Si, reside.";
            }
            else
            {
                chkEstado.Text = "No, no reside.";
            }
        }
    }
}
