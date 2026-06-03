using pryRomoApeERP.Base_de_Datos;
using pryRomoApeERP.Funciones.Login;
using pryRomoApeERP.Utilidades;
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
    public partial class frmLogin : Form
    {
        //Objeto para administrar archivo BD
        private Archivo archivoBD;

        //Objeto de conexión
        private ConexionDB conexionBD;

        //Objeto para registrar auditoría
        private RegistroAuditoria registroAuditoria;

        public frmLogin()
        {
            InitializeComponent();
        }

        int intentosIngresos = 3;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = true;

            try
            {
                //Carga la BD
                archivoBD = new Archivo("RomoBD.accdb");

                //Obtiene la conexión
                conexionBD = archivoBD.Conexion;

                //Inicializa el registro de auditoría
                registroAuditoria = new RegistroAuditoria(conexionBD);

                //Validación
                if (conexionBD != null &&
                    conexionBD.EstaConectado)
                {
                    lblEstado.Text = "Conectado";
                    lblEstado.ForeColor = Color.Green;
                }
                else
                {
                    lblEstado.Text = "Desconectado";
                    lblEstado.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n" + ex.Message
                );
            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (txtMail.Text != "" && txtContrasenia.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void txtConrtasenia_TextChanged(object sender, EventArgs e)
        {

            if (txtMail.Text != "" && txtContrasenia.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void chkVer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVer.Checked)
            {
                txtContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar usuario
                string consulta =
@"SELECT
    U.IdUsuario,
    U.Nombre,
    U.Mail,
    R.IdPerfil
FROM
    tablaUsuario U
INNER JOIN
    tablaRUP R
ON
    U.IdUsuario = R.IdUsuario
WHERE
    U.Mail = ?
    AND U.Contrasenia = ?";

                OleDbCommand cmd = new OleDbCommand(
                    consulta,
                    conexionBD.Conexion
                );

                cmd.Parameters.AddWithValue(
                    "@Mail",
                    txtMail.Text
                );

                cmd.Parameters.AddWithValue(
                    "@Contrasenia",
                    txtContrasenia.Text
                );

                OleDbDataReader lector = cmd.ExecuteReader();

                bool ingresoExitoso = false;

                if (lector.Read())
                {
                    ingresoExitoso = true;

                    Sesion.IdUsuario =
                        Convert.ToInt32(lector["IdUsuario"]);

                    Sesion.IdPerfil =
                        Convert.ToInt32(lector["IdPerfil"]);

                    Sesion.NombreUsuario =
                        lector["Nombre"].ToString();
                }

                lector.Close();

                // Determinar acción
                string accion = ingresoExitoso
                    ? "Login"
                    : "FalloLogin";

                // Registrar auditoría
                registroAuditoria.RegistrarAccion(
                    txtMail.Text,
                    accion
                );

                // Resultado final
                if (ingresoExitoso)
                {
                    
                    MessageBox.Show(
    $"🎉 ¡Bienvenido al sistema! " + Sesion.IdPerfil + " 🎉\n\n" +
    $"Nos alegra verte nuevamente.\n" +
    $"El acceso fue validado correctamente.\n\n" +
    $"¡Que tengas una excelente jornada! 🚀",
    "Acceso concedido",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);

                    frmPrincipal paso =
                    new frmPrincipal(txtMail.Text);

                    paso.Show();

                    this.Hide();
                }
                else
                {
                    intentosIngresos--;

                    txtContrasenia.Clear();
                    txtMail.Clear();

                    if (intentosIngresos <= 0)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Usuario o contraseña incorrectos. Le quedan "
                            + intentosIngresos +
                            " intentos."
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n" + ex.Message
                );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Está seguro que desea salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}