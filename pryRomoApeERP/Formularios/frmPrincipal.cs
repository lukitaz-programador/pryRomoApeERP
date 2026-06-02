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

            try
            {
                archivoBD = new Archivo("Romo.accdb");
                conexionBD = archivoBD.Conexion;
                registroAuditoria = new RegistroAuditoria(conexionBD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n" + ex.Message
                );
            }
        }

        private void btnGestionDatosPersonales_Click(object sender, EventArgs e)
        {
            try
            {
                registroAuditoria.RegistrarAccion(
                    mailUsuario,
                    "Gestionar Datos Personales"
                );

                frmGestionDatosPersonales paso = new frmGestionDatosPersonales(mailUsuario);
                paso.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n" + ex.Message
                );
            }
        }

        private void btnInfoAuditoria_Click(object sender, EventArgs e)
        {
            try
            {
                registroAuditoria.RegistrarAccion(
                    mailUsuario,
                    "Ver Información de Auditoría"
                );

                frmInformacionAuditoria paso = new frmInformacionAuditoria(mailUsuario);
                paso.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n" + ex.Message
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                registroAuditoria.RegistrarAccion(
                    mailUsuario,
                    "Gestionar Perfiles"
                );

                frmGestionPerfiles paso = new frmGestionPerfiles(mailUsuario);
                paso.Show();
                this.Hide();
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

        private void gestiónDeDatosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionDatosPersonales x = new frmGestionDatosPersonales(mailUsuario);
            x.Show();
        }
        private void verInformacionDeAuditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformacionAuditoria x = new frmInformacionAuditoria(mailUsuario);
            x.Show();
        }
    }
}
