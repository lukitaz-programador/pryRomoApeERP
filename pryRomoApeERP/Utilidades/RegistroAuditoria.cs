using pryRomoApeERP.Base_de_Datos;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryRomoApeERP.Utilidades
{
    public class RegistroAuditoria
    {
        private ConexionDB conexionBD;

        public RegistroAuditoria(ConexionDB conexion)
        {
            conexionBD = conexion;
        }

        public void RegistrarAccion(string mailUsuario, string accion)
        {
            OleDbConnection conn = null;
            OleDbCommand cmd = null;
            
            try
            {
                if (conexionBD == null)
                {
                    MessageBox.Show("Error: ConexionBD es null");
                    return;
                }

                conn = conexionBD.Conexion;

                if (conn == null)
                {
                    MessageBox.Show("Error: Conexion es null");
                    return;
                }

                // Verificar el estado de la conexión
                if (conn.State != ConnectionState.Open)
                {
                    MessageBox.Show($"Advertencia: Conexión cerrada. Estado: {conn.State}");
                    return;
                }

                // Validar que no sean nulos los parámetros
                string mail = string.IsNullOrEmpty(mailUsuario) ? "SinMail" : mailUsuario.Trim();
                string acc = string.IsNullOrEmpty(accion) ? "SinAccion" : accion.Trim();
                DateTime fecha = DateTime.Now;

                string consulta =
                "INSERT INTO tablaRegistroAuditoria (FechaHora, MailUsuario, Accion) " +
                "VALUES (?, ?, ?)";

                cmd = new OleDbCommand(consulta, conn);
                cmd.CommandType = CommandType.Text;

                // Agregar los parámetros en el mismo orden que en la consulta
                cmd.Parameters.Add("@FechaHora", OleDbType.DBTimeStamp).Value = fecha;
                cmd.Parameters.Add("@MailUsuario", OleDbType.VarChar).Value = mail;
                cmd.Parameters.Add("@Accion", OleDbType.VarChar).Value = acc;

                // Ejecutar el comando
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    System.Diagnostics.Debug.WriteLine($"? Auditoría registrada: {mail} | {acc} | {fecha:yyyy-MM-dd HH:mm:ss}");
                }
                else
                {
                    MessageBox.Show($"Advertencia: No se insertaron filas.\nMail: {mail}\nAccion: {acc}");
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error OleDb en auditoría:\n{oleDbEx.Message}\n\nNúmero de error: {oleDbEx.Errors[0].NativeError}");
                System.Diagnostics.Debug.WriteLine($"? Error OleDb: {oleDbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar auditoría:\n{ex.GetType().Name}\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"? Error general: {ex.Message}");
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }
    }
}
