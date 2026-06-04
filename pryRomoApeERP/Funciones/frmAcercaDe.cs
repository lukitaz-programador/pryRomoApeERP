using pryRomoApeERP.Base_de_Datos;
using pryRomoApeERP.Funciones.Login;
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
            InicializarBarraEstado();
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
        }

        private void InicializarBarraEstado()
        {
            try
            {
                archivoBD = new Archivo("RomoBD.accdb");
                conexionBD = archivoBD.Conexion;

                lblUsuario.Text = $"Usuario: {Sesion.NombreUsuario}";

                if (conexionBD != null &&
                    conexionBD.EstaConectado)
                {
                    lblConexion.Text = "BD: Conectada";
                }
                else
                {
                    lblConexion.Text = "BD: Desconectada";
                }

                lblFecha.Text =
                    DateTime.Now.ToString(
                        "dd/MM/yyyy HH:mm:ss");

                tmrReloj.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la barra de estado:\n" +
                    ex.Message);
            }
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblFecha.Text =
                DateTime.Now.ToString(
                    "dd/MM/yyyy HH:mm:ss");
        }

    }
}
