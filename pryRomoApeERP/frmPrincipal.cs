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
    public partial class frmPrincipal : Form
    {
        //Objeto para administrar archivo BD
        private Archivo archivoBD;

        //Objeto de conexión
        private ConexionDB conexionBD;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = true;

            try
            {
                //Carga la BD
                archivoBD = new Archivo("Romo.accdb");

                //Obtiene la conexión
                conexionBD = archivoBD.Conexion;

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
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }
        }

        private void txtConrtasenia_TextChanged(object sender, EventArgs e)
        {

            if (txtMail.Text != "" && txtContrasenia.Text != "")
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
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
                bool ingresoExitoso = false;

                string consulta =
                "SELECT * FROM tablaUsuario " +
                "WHERE Mail = ? AND Contrasenia = ?";

                OleDbCommand cmd = new OleDbCommand(
                    consulta,
                    conexionBD.Conexion
                );

                // IMPORTANTE: Access usa el orden de parámetros
                cmd.Parameters.AddWithValue(
                    "@Mail",
                    txtMail.Text
                );

                cmd.Parameters.AddWithValue(
                    "@Contrasenia",
                    txtContrasenia.Text
                );

                OleDbDataReader lector =
                cmd.ExecuteReader();

                if (lector.Read())
                {
                    ingresoExitoso = true;
                }

                lector.Close();

                if (ingresoExitoso)
                {
                    MessageBox.Show(
                        "Ingreso exitoso"
                    );

                    //Abrir otro formulario si querés
                    //frmMenu menu = new frmMenu();
                    //menu.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n" + ex.Message
                );
            }
        }
    }
}