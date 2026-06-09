using pryRomoApeERP.Base_de_Datos;
using pryRomoApeERP.Funciones.Login;
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

namespace pryRomoApeERP.Funciones
{
    public partial class frmAcercaDe : Form
    {
        private Archivo archivoBD;
        private ConexionDB conexionBD;

        public frmAcercaDe()
        {
            InitializeComponent();
            InterfazHelper.AplicarEstiloProfesional(this);
            InterfazHelper.ConfigurarEnterComoTab(this);
        }       
    }
}
