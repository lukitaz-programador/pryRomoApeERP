using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryRomoApeERP.Base_de_Datos
{
    public class tablaPerfil
    {
        private ConexionDB conexionBD;

        public tablaPerfil(ConexionDB conexion)
        {
            conexionBD = conexion;
        }

        /// <summary>
        /// Obtiene todos los perfiles
        /// </summary>
        public List<PerfilInfo> ObtenerTodosPerfiles()
        {
            List<PerfilInfo> listaPerfiles = new List<PerfilInfo>();
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return listaPerfiles;
                }

                string consulta = @"
                    SELECT idPerfil, nombre, descripcion 
                    FROM tablaPerfil 
                    ORDER BY nombre";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.CommandType = CommandType.Text;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaPerfiles.Add(new PerfilInfo
                    {
                        IdPerfil = Convert.ToInt32(reader["idPerfil"]),
                        Nombre = reader["nombre"].ToString(),
                        Descripcion = reader["descripcion"] != DBNull.Value ? reader["descripcion"].ToString() : ""
                    });
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error en la consulta de perfiles:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener perfiles:\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error general: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                if (cmd != null)
                    cmd.Dispose();
            }

            return listaPerfiles;
        }

        /// <summary>
        /// Obtiene los perfiles de un usuario específico
        /// </summary>
        public List<PerfilInfo> ObtenerPerfilesUsuario(string mailUsuario)
        {
            List<PerfilInfo> listaPerfiles = new List<PerfilInfo>();
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return listaPerfiles;
                }

                string consulta = @"
                    SELECT DISTINCT p.idPerfil, p.nombre, p.descripcion 
                    FROM tablaPerfil p
                    INNER JOIN tablaRUP r ON p.idPerfil = r.idPerfil
                    INNER JOIN tablaUsuario u ON r.idUsuario = u.idUsuario
                    WHERE u.mail = ?
                    ORDER BY p.nombre";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@mail", OleDbType.VarChar).Value = mailUsuario;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaPerfiles.Add(new PerfilInfo
                    {
                        IdPerfil = Convert.ToInt32(reader["idPerfil"]),
                        Nombre = reader["nombre"].ToString(),
                        Descripcion = reader["descripcion"] != DBNull.Value ? reader["descripcion"].ToString() : ""
                    });
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error en la consulta de perfiles del usuario:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener perfiles del usuario:\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error general: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                if (cmd != null)
                    cmd.Dispose();
            }

            return listaPerfiles;
        }

        /// <summary>
        /// Asigna un perfil a un usuario
        /// </summary>
        public bool AsignarPerfilUsuario(string mailUsuario, int idPerfil)
        {
            OleDbCommand cmd = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return false;
                }

                if (string.IsNullOrEmpty(mailUsuario) || idPerfil <= 0)
                {
                    MessageBox.Show("Error: Los datos son incompletos.");
                    return false;
                }

                // Obtener el idUsuario del mail
                int idUsuario = ObtenerIdUsuarioByMail(mailUsuario);
                if (idUsuario <= 0)
                {
                    MessageBox.Show("Error: El usuario no existe.");
                    return false;
                }

                // Verificar si ya existe la asignación
                string consultaVerificar = @"
                    SELECT COUNT(*) as cantidad 
                    FROM tablaRUP 
                    WHERE idUsuario = ? AND idPerfil = ?";

                cmd = new OleDbCommand(consultaVerificar, conexionBD.Conexion);
                cmd.Parameters.Add("@idUsuario", OleDbType.Integer).Value = idUsuario;
                cmd.Parameters.Add("@idPerfil", OleDbType.Integer).Value = idPerfil;

                int cantidad = (int)cmd.ExecuteScalar();

                if (cantidad > 0)
                {
                    MessageBox.Show("Error: El usuario ya tiene asignado este perfil.");
                    return false;
                }

                // Insertar la asignación
                string consulta = @"
                    INSERT INTO tablaRUP (idUsuario, idPerfil) 
                    VALUES (?, ?)";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.Parameters.Add("@idUsuario", OleDbType.Integer).Value = idUsuario;
                cmd.Parameters.Add("@idPerfil", OleDbType.Integer).Value = idPerfil;

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    System.Diagnostics.Debug.WriteLine($"? Perfil {idPerfil} asignado al usuario {mailUsuario}");
                    return true;
                }
                else
                {
                    MessageBox.Show("Advertencia: No se insertaron registros.");
                    return false;
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error al asignar perfil:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al asignar perfil:\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error general: {ex.Message}");
                return false;
            }
            finally
            {
                if (cmd != null)
                    cmd.Dispose();
            }
        }

        /// <summary>
        /// Obtiene el IdUsuario por mail
        /// </summary>
        private int ObtenerIdUsuarioByMail(string mail)
        {
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;

            try
            {
                string consulta = "SELECT idUsuario FROM tablaUsuario WHERE mail = ?";
                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.Parameters.Add("@mail", OleDbType.VarChar).Value = mail;

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return Convert.ToInt32(reader["idUsuario"]);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al obtener IdUsuario: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                if (cmd != null)
                    cmd.Dispose();
            }

            return -1;
        }
    }
}
