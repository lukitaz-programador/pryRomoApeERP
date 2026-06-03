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
    public partial class frmPrincipal : Form
    {
        private string mailUsuario;
        private Archivo archivoBD;
        private ConexionDB conexionBD;
        private RegistroAuditoria registroAuditoria;

        public frmPrincipal(string mail = "")
        {
            InitializeComponent();
            mailUsuario = mail;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                archivoBD = new Archivo("RomoBD.accdb");
                conexionBD = archivoBD.Conexion;
                registroAuditoria = new RegistroAuditoria(conexionBD);

                lblUsuario.Text = $"Usuario: {mailUsuario}";

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

                this.WindowState =
                    FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n" + ex.Message
                );
            }
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            try
            {
                registroAuditoria?.RegistrarAccion(mailUsuario, "Cerró la aplicación");
            }
            catch { }

            Application.Exit();
        }

        private void gestiónDeDatosPersonalesToolStripMenuItem_Click(object sender,EventArgs e)
        {
            using (frmGestionDatosPersonales frm =
                   new frmGestionDatosPersonales(mailUsuario))
            {
                frm.ShowDialog();
            }
        }
        private void verInformacionDeAuditoriaToolStripMenuItem_Click(object sender,EventArgs e)
        {
            using (frmInformacionAuditoria frm =
                   new frmInformacionAuditoria(mailUsuario))
            {
                frm.ShowDialog();
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                registroAuditoria?.RegistrarAccion(
                    mailUsuario,
                    "Logout");
            }
            catch { }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblFecha.Text =
            DateTime.Now.ToString(
            "dd/MM/yyyy HH:mm:ss");
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionDatosPersonales paso = new frmGestionDatosPersonales();
            paso.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionPerfiles paso = new frmGestionPerfiles();
            paso.ShowDialog();
        }

        private void verAuditoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformacionAuditoria paso = new frmInformacionAuditoria();
            paso.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirApp_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
