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
    public partial class frmGestionPerfiles : Form
    {
        private string mailUsuario;

        public frmGestionPerfiles(string mail = "")
        {
            InitializeComponent();
            mailUsuario = mail;
        }

        private void btnGuardarPerfiles_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la gestión de datos personales?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmPrincipal paso = new frmPrincipal(mailUsuario);
                paso.Show();
                this.Hide();
            }
        }

        private void txtMailAniadirPerfil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
