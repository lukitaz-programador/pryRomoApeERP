using pryRomoApeERP.Base_de_Datos;
using pryRomoApeERP.Funciones.Login;
using System;
using System.Collections.Generic;
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
            try
            {
                if (conexionBD == null)
                {
                    MessageBox.Show("Error: ConexionBD es null");
                    return;
                }

                if (!conexionBD.EstaConectado)
                {
                    MessageBox.Show("Error: La conexión no está abierta");
                    return;
                }

                string mail = string.IsNullOrWhiteSpace(mailUsuario) ? Sesion.MailUsuario : mailUsuario.Trim();

                if (string.IsNullOrWhiteSpace(mail))
                {
                    mail = "SinMail";
                }
                string acc = string.IsNullOrEmpty(accion) ? "SinAccion" : accion.Trim();
                DateTime fecha = DateTime.Now;

                string sql = "INSERT INTO [tablaRegistroAuditoria] ([FechaHora], [MailUsuario], [Accion]) VALUES (?, ?, ?)";

                List<object> parametros = new List<object>();
                parametros.Add(fecha.ToString("yyyy-MM-dd HH:mm:ss.fffffff"));
                parametros.Add(mail);
                parametros.Add(acc);

                int rowsAffected = conexionBD.ExecuteNonQuery(sql, parametros);

                if (rowsAffected > 0)
                {
                    System.Diagnostics.Debug.WriteLine($"? Auditoría registrada: {mail} | {acc} | {fecha:yyyy-MM-dd HH:mm:ss}");
                }
                else
                {
                    MessageBox.Show($"Advertencia: No se insertaron filas.\nMail: {mail}\nAccion: {acc}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar auditoría:\n{ex.GetType().Name}\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"? Error: {ex.Message}");
            }
        }
        public void RegistrarAlta(string usuario,string entidad)
        {
            RegistrarAccion(
                usuario,
                $"Alta de {entidad}");
        }
        public void RegistrarModificacion( string usuario,string entidad)
        {
            RegistrarAccion(
                usuario,
                $"Modificación de {entidad}");
        }
        public void RegistrarBaja(string usuario,string entidad)
        {
            RegistrarAccion(
                usuario,
                $"Baja de {entidad}");
        }
    }
}
