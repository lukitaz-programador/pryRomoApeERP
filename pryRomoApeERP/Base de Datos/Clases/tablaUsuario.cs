using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryRomoApeERP.Base_de_Datos
{
    public class tablaUsuario
    {
        private ConexionDB conexionBD;

        public tablaUsuario(ConexionDB conexion)
        {
            conexionBD = conexion;
        }

        /// <summary>
        /// Verifica si un usuario existe por mail
        /// </summary>
        public bool UsuarioExiste(string mail)
        {
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return false;
                }

                string consulta = @"
                    SELECT COUNT(*) as cantidad 
                    FROM tablaUsuario 
                    WHERE mail = ?";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@mail", OleDbType.VarChar).Value = mail;

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int cantidad = (int)reader["cantidad"];
                    return cantidad > 0;
                }

                return false;
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error en la consulta de usuario:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar usuario:\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error general: {ex.Message}");
                return false;
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                if (cmd != null)
                    cmd.Dispose();
            }
        }

        /// <summary>
        /// Obtiene todos los usuarios
        /// </summary>
        public List<UsuarioInfo> ObtenerTodosUsuarios()
        {
            List<UsuarioInfo> listaUsuarios = new List<UsuarioInfo>();
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return listaUsuarios;
                }

                string consulta = @"
                    SELECT idUsuario, nombre, apellido, mail 
                    FROM tablaUsuario 
                    ORDER BY nombre, apellido";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.CommandType = CommandType.Text;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaUsuarios.Add(new UsuarioInfo
                    {
                        IdUsuario = Convert.ToInt32(reader["idUsuario"]),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Mail = reader["mail"].ToString()
                    });
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error en la consulta de usuarios:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener usuarios:\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error general: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                if (cmd != null)
                    cmd.Dispose();
            }

            return listaUsuarios;
        }

        /// <summary>
        /// Obtiene un usuario por mail
        /// </summary>
        public UsuarioInfo ObtenerUsuarioPorMail(string mail)
        {
            UsuarioInfo usuario = null;
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return usuario;
                }

                string consulta = @"
                    SELECT idUsuario, nombre, apellido, mail 
                    FROM tablaUsuario 
                    WHERE mail = ?";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@mail", OleDbType.VarChar).Value = mail;

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new UsuarioInfo
                    {
                        IdUsuario = Convert.ToInt32(reader["idUsuario"]),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Mail = reader["mail"].ToString()
                    };
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error en la consulta de usuario:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener usuario:\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error general: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                if (cmd != null)
                    cmd.Dispose();
            }

            return usuario;
        }
    }

    /// <summary>
    /// Clase para representar la información de un usuario
    /// </summary>
    public class UsuarioInfo
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} ({Mail})";
        }
    }
}
