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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestionDatosPersonales_Click(object sender, EventArgs e)
        {
            frmGestionDatosPersonales paso = new frmGestionDatosPersonales();
            paso.Show();
            this.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        /*
        IdPerfil | Nombre
        ------------------
        1 | Admin
        2 | Logis
        3 | Venta
        4 | Marke
        5 | RRHH
        6 | Conta
        */
        
            
        }

        private void btnInfoAuditoria_Click(object sender, EventArgs e)
        {
            frmInformacionAuditoria paso = new frmInformacionAuditoria();
            paso.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGestionPerfiles paso = new frmGestionPerfiles();
            paso.Show();
            this.Hide();
        }
    }
}
