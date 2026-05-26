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
    public partial class frmInformacionAuditoria : Form
    {
        public frmInformacionAuditoria()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la gestión de datos personales?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmPrincipal paso = new frmPrincipal();
                paso.Show();
                this.Hide();
            }
        }
    }
}
