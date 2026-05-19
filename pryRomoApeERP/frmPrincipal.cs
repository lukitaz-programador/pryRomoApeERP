using pryRomoApeERP.Base_de_Datos;
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

        public ConexionDB EstaConectado;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (EstaConectado == true)
            {

            }
        }
    }
}
