using pryRomoApeERP.Base_de_Datos;
using pryRomoApeERP.Utilidades;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms; 
using pryRomoApeERP.Funciones.Login;

namespace pryRomoApeERP
{
    public partial class frmInformacionAuditoria : Form
    {
        private Archivo archivoBD;
        private ConexionDB conexionBD;
        private string mailUsuario;
        private CheckBox chkFiltrarFecha;
        private DateTimePicker dtpFechaDesde;
        private DateTimePicker dtpHoraDesde;
        private DateTimePicker dtpFechaHasta;
        private DateTimePicker dtpHoraHasta;

        public frmInformacionAuditoria(string mail = "")
        {
            InitializeComponent();
            mailUsuario =
                string.IsNullOrWhiteSpace(mail)
                ? Sesion.MailUsuario
                : mail;

            CrearFiltrosFechaHora();
            InterfazHelper.AplicarEstiloProfesional(this);
            InterfazHelper.ConfigurarEnterComoTab(this);
            InicializarBarraEstado();
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
        }

        private void CrearFiltrosFechaHora()
        {
            Calendario.Visible = false;

            chkFiltrarFecha = new CheckBox();
            chkFiltrarFecha.Text = "Filtrar por fecha y hora";
            chkFiltrarFecha.Location = new Point(382, 34);
            chkFiltrarFecha.AutoSize = true;
            chkFiltrarFecha.Checked = false;

            Label lblDesde = new Label();
            lblDesde.Text = "Desde:";
            lblDesde.Location = new Point(382, 70);
            lblDesde.AutoSize = true;

            dtpFechaDesde = new DateTimePicker();
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(435, 66);
            dtpFechaDesde.Width = 95;
            dtpFechaDesde.Value = DateTime.Today;

            dtpHoraDesde = new DateTimePicker();
            dtpHoraDesde.Format = DateTimePickerFormat.Time;
            dtpHoraDesde.ShowUpDown = true;
            dtpHoraDesde.Location = new Point(536, 66);
            dtpHoraDesde.Width = 85;
            dtpHoraDesde.Value = DateTime.Today;

            Label lblHasta = new Label();
            lblHasta.Text = "Hasta:";
            lblHasta.Location = new Point(382, 106);
            lblHasta.AutoSize = true;

            dtpFechaHasta = new DateTimePicker();
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(435, 102);
            dtpFechaHasta.Width = 95;
            dtpFechaHasta.Value = DateTime.Today;

            dtpHoraHasta = new DateTimePicker();
            dtpHoraHasta.Format = DateTimePickerFormat.Time;
            dtpHoraHasta.ShowUpDown = true;
            dtpHoraHasta.Location = new Point(536, 102);
            dtpHoraHasta.Width = 85;
            dtpHoraHasta.Value = DateTime.Today
                .AddHours(23)
                .AddMinutes(59)
                .AddSeconds(59);

            Controls.Add(chkFiltrarFecha);
            Controls.Add(lblDesde);
            Controls.Add(dtpFechaDesde);
            Controls.Add(dtpHoraDesde);
            Controls.Add(lblHasta);
            Controls.Add(dtpFechaHasta);
            Controls.Add(dtpHoraHasta);
        }

        private DateTime CombinarFechaHora(
            DateTimePicker fecha,
            DateTimePicker hora)
        {
            return fecha.Value.Date
                .AddHours(hora.Value.Hour)
                .AddMinutes(hora.Value.Minute)
                .AddSeconds(hora.Value.Second);
        }

        private void frmInformacionAuditoria_Load(object sender, EventArgs e)
        {
            try
            {
                archivoBD = new Archivo("RomoBD.accdb");
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

                if (chkFiltrarFecha.Checked)
                {
                    DateTime desde =
                        CombinarFechaHora(
                            dtpFechaDesde,
                            dtpHoraDesde);

                    DateTime hasta =
                        CombinarFechaHora(
                            dtpFechaHasta,
                            dtpHoraHasta);

                    if (desde > hasta)
                    {
                        MessageBox.Show(
                            "La fecha desde no puede ser mayor que la fecha hasta.",
                            "Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    consulta +=
                    " AND FechaHora >= ? AND FechaHora <= ?";

                    cmd.Parameters.AddWithValue(
                        "@FechaDesde",
                        desde.ToString("yyyy-MM-dd HH:mm:ss") +
                        ".0000000");

                    cmd.Parameters.AddWithValue(
                        "@FechaHasta",
                        hasta.ToString("yyyy-MM-dd HH:mm:ss") +
                        ".9999999");
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
