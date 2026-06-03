using pryRomoApeERP.Base_de_Datos;
using pryRomoApeERP.Utilidades;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryRomoApeERP
{
    public partial class frmInformacionAuditoria : Form
    {
        private Archivo archivoBD;
        private ConexionDB conexionBD;
        private string mailUsuario;

        public frmInformacionAuditoria(string mail = "")
        {
            InitializeComponent();
            mailUsuario = mail;
        }

        private void frmInformacionAuditoria_Load(object sender, EventArgs e)
        {
            try
            {
                archivoBD = new Archivo("Romo.accdb");
                conexionBD = archivoBD.Conexion;

                if (conexionBD != null &&
                    conexionBD.EstaConectado)
                {
                    CargarUsuarios();
                    CargarAcciones();
                    CargarTodo();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo conectar a la base de datos"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n" +
                    ex.Message
                );
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                string consulta =
                "SELECT DISTINCT MailUsuario " +
                "FROM tablaRegistroAuditoria " +
                "ORDER BY MailUsuario";

                OleDbCommand cmd =
                new OleDbCommand(
                    consulta,
                    conexionBD.Conexion
                );

                OleDbDataReader lector =
                cmd.ExecuteReader();

                cmbUsuario.Items.Clear();

                cmbUsuario.Items.Add("Todos");

                while (lector.Read())
                {
                    if (!lector.IsDBNull(0))
                    {
                        cmbUsuario.Items.Add(
                            lector["MailUsuario"].ToString()
                        );
                    }
                }

                lector.Close();

                cmbUsuario.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error usuarios:\n" +
                    ex.Message
                );
            }
        }

        private void CargarAcciones()
        {
            try
            {
                string consulta =
                "SELECT DISTINCT Accion " +
                "FROM tablaRegistroAuditoria " +
                "ORDER BY Accion";

                OleDbCommand cmd =
                new OleDbCommand(
                    consulta,
                    conexionBD.Conexion
                );

                OleDbDataReader lector =
                cmd.ExecuteReader();

                cmbAccion.Items.Clear();

                cmbAccion.Items.Add("Todas");

                while (lector.Read())
                {
                    if (!lector.IsDBNull(0))
                    {
                        cmbAccion.Items.Add(
                            lector["Accion"].ToString()
                        );
                    }
                }

                lector.Close();

                cmbAccion.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error acciones:\n" +
                    ex.Message
                );
            }
        }

        private void CargarTodo()
        {
            try
            {
                string consulta =
                "SELECT FechaHora, MailUsuario, Accion " +
                "FROM tablaRegistroAuditoria " +
                "ORDER BY FechaHora DESC";

                OleDbDataAdapter da =
                new OleDbDataAdapter(
                    consulta,
                    conexionBD.Conexion
                );

                DataTable dt =
                new DataTable();

                da.Fill(dt);

                dgvAuditoria.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n" +
                    ex.Message
                );
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta =
                "SELECT FechaHora, MailUsuario, Accion " +
                "FROM tablaRegistroAuditoria " +
                "WHERE 1=1";

                OleDbCommand cmd =
                new OleDbCommand();

                cmd.Connection =
                conexionBD.Conexion;

                if (cmbUsuario.Text != "Todos")
                {
                    consulta +=
                    " AND MailUsuario=?";

                    cmd.Parameters.AddWithValue(
                        "@MailUsuario",
                        cmbUsuario.Text
                    );
                }

                if (cmbAccion.Text != "Todas")
                {
                    consulta +=
                    " AND Accion=?";

                    cmd.Parameters.AddWithValue(
                        "@Accion",
                        cmbAccion.Text
                    );
                }

                consulta +=
                " ORDER BY FechaHora DESC";

                cmd.CommandText =
                consulta;

                OleDbDataAdapter da =
                new OleDbDataAdapter(cmd);

                DataTable dt =
                new DataTable();

                da.Fill(dt);

                dgvAuditoria.DataSource =
                dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error consulta:\n" +
                    ex.Message
                );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Desea salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                frmPrincipal paso =
                new frmPrincipal(mailUsuario);

                paso.Show();

                this.Hide();
            }
        }
    }
}