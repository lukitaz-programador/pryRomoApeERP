using pryRomoApeERP.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRomoApeERP
{
    public partial class frmInformacionAuditoria : Form
    {
        private Archivo archivoBD;
        private ConexionDB conexionBD;

        public frmInformacionAuditoria()
        {
            InitializeComponent();
        }

        private void frmInformacionAuditoria_Load(object sender, EventArgs e)
        {
            try
            {
                archivoBD = new Archivo("Romo.accdb");
                conexionBD = archivoBD.Conexion;

                if (conexionBD != null && conexionBD.EstaConectado)
                {
                    CargarUsuarios();
                    CargarAcciones();
                }
                else
                {
                    MessageBox.Show("No se pudo conectar a la base de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario:\n" + ex.Message);
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                string consulta = "SELECT DISTINCT Usuario FROM tablaRegistroAuditoria ORDER BY Usuario";
                OleDbCommand cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                OleDbDataReader lector = cmd.ExecuteReader();

                cmbUsuario.Items.Clear();

                while (lector.Read())
                {
                    if (!lector.IsDBNull(0))
                    {
                        cmbUsuario.Items.Add(lector["Usuario"].ToString());
                    }
                }

                lector.Close();
                cmbUsuario.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios:\n" + ex.Message);
            }
        }

        private void CargarAcciones()
        {
            try
            {
                string consulta = "SELECT DISTINCT Accion FROM tablaRegistroAuditoria ORDER BY Accion";
                OleDbCommand cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                OleDbDataReader lector = cmd.ExecuteReader();

                cmbAccion.Items.Clear();

                while (lector.Read())
                {
                    if (!lector.IsDBNull(0))
                    {
                        cmbAccion.Items.Add(lector["Accion"].ToString());
                    }
                }

                lector.Close();
                cmbAccion.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar acciones:\n" + ex.Message);
            }
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
