using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryRomoApeERP.Base_de_Datos
{
    public class tablaRUP
    {
        private ConexionDB conexionBD;

        public tablaRUP(ConexionDB conexion)
        {
            conexionBD = conexion;
        }

        /// <summary>
        /// Obtiene todos los registros RUP
        /// </summary>
        public List<RUPInfo> ObtenerTodosRegistros()
        {
            List<RUPInfo> listaRUP = new List<RUPInfo>();
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return listaRUP;
                }

                string consulta = @"
                    SELECT id, idUsuario, idPerfil 
                    FROM tablaRUP 
                    ORDER BY id";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.CommandType = CommandType.Text;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaRUP.Add(new RUPInfo
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        IdUsuario = Convert.ToInt32(reader["idUsuario"]),
                        IdPerfil = Convert.ToInt32(reader["idPerfil"])
                    });
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error en la consulta de RUP:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener registros RUP:\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error general: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                if (cmd != null)
                    cmd.Dispose();
            }

            return listaRUP;
        }

        /// <summary>
        /// Obtiene registros RUP por usuario
        /// </summary>
        public List<RUPInfo> ObtenerRegistrosPorUsuario(int idUsuario)
        {
            List<RUPInfo> listaRUP = new List<RUPInfo>();
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return listaRUP;
                }

                string consulta = @"
                    SELECT id, idUsuario, idPerfil 
                    FROM tablaRUP 
                    WHERE idUsuario = ? 
                    ORDER BY id";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@idUsuario", OleDbType.Integer).Value = idUsuario;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaRUP.Add(new RUPInfo
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        IdUsuario = Convert.ToInt32(reader["idUsuario"]),
                        IdPerfil = Convert.ToInt32(reader["idPerfil"])
                    });
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error en la consulta de RUP:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener registros RUP:\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error general: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                if (cmd != null)
                    cmd.Dispose();
            }

            return listaRUP;
        }

        /// <summary>
        /// Obtiene registros RUP por perfil
        /// </summary>
        public List<RUPInfo> ObtenerRegistrosPorPerfil(int idPerfil)
        {
            List<RUPInfo> listaRUP = new List<RUPInfo>();
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return listaRUP;
                }

                string consulta = @"
                    SELECT id, idUsuario, idPerfil 
                    FROM tablaRUP 
                    WHERE idPerfil = ? 
                    ORDER BY id";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@idPerfil", OleDbType.Integer).Value = idPerfil;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaRUP.Add(new RUPInfo
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        IdUsuario = Convert.ToInt32(reader["idUsuario"]),
                        IdPerfil = Convert.ToInt32(reader["idPerfil"])
                    });
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error en la consulta de RUP:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener registros RUP:\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error general: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                if (cmd != null)
                    cmd.Dispose();
            }

            return listaRUP;
        }

        /// <summary>
        /// Obtiene un registro RUP específico
        /// </summary>
        public RUPInfo ObtenerRegistro(int id)
        {
            RUPInfo rup = null;
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return rup;
                }

                string consulta = @"
                    SELECT id, idUsuario, idPerfil 
                    FROM tablaRUP 
                    WHERE id = ?";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = id;

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    rup = new RUPInfo
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        IdUsuario = Convert.ToInt32(reader["idUsuario"]),
                        IdPerfil = Convert.ToInt32(reader["idPerfil"])
                    };
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error en la consulta de RUP:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el registro RUP:\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error general: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                if (cmd != null)
                    cmd.Dispose();
            }

            return rup;
        }

        /// <summary>
        /// Inserta un nuevo registro RUP
        /// </summary>
        public bool InsertarRegistro(RUPInfo rup)
        {
            OleDbCommand cmd = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return false;
                }

                if (rup == null || rup.IdUsuario <= 0 || rup.IdPerfil <= 0)
                {
                    MessageBox.Show("Error: Los datos del RUP son incompletos.");
                    return false;
                }

                string consulta = @"
                    INSERT INTO tablaRUP (idUsuario, idPerfil) 
                    VALUES (?, ?)";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@idUsuario", OleDbType.Integer).Value = rup.IdUsuario;
                cmd.Parameters.Add("@idPerfil", OleDbType.Integer).Value = rup.IdPerfil;

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    System.Diagnostics.Debug.WriteLine($"? Registro RUP insertado: Usuario {rup.IdUsuario} - Perfil {rup.IdPerfil}");
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
                MessageBox.Show($"Error al insertar registro RUP:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar registro RUP:\n{ex.Message}");
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
        /// Actualiza un registro RUP existente
        /// </summary>
        public bool ActualizarRegistro(RUPInfo rup)
        {
            OleDbCommand cmd = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return false;
                }

                if (rup == null || rup.Id <= 0)
                {
                    MessageBox.Show("Error: El ID del RUP es requerido.");
                    return false;
                }

                string consulta = @"
                    UPDATE tablaRUP 
                    SET idUsuario = ?, idPerfil = ? 
                    WHERE id = ?";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@idUsuario", OleDbType.Integer).Value = rup.IdUsuario;
                cmd.Parameters.Add("@idPerfil", OleDbType.Integer).Value = rup.IdPerfil;
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = rup.Id;

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    System.Diagnostics.Debug.WriteLine($"? Registro RUP {rup.Id} actualizado correctamente.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Advertencia: No se actualizaron registros.");
                    return false;
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error al actualizar registro RUP:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar registro RUP:\n{ex.Message}");
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
        /// Elimina un registro RUP
        /// </summary>
        public bool EliminarRegistro(int id)
        {
            OleDbCommand cmd = null;

            try
            {
                if (conexionBD?.Conexion == null || conexionBD.Conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error: La conexión a la base de datos no está disponible.");
                    return false;
                }

                if (id <= 0)
                {
                    MessageBox.Show("Error: El ID del RUP es inválido.");
                    return false;
                }

                string consulta = "DELETE FROM tablaRUP WHERE id = ?";

                cmd = new OleDbCommand(consulta, conexionBD.Conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = id;

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    System.Diagnostics.Debug.WriteLine($"? Registro RUP {id} eliminado correctamente.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Advertencia: No se eliminaron registros.");
                    return false;
                }
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show($"Error al eliminar registro RUP:\n{oleDbEx.Message}");
                System.Diagnostics.Debug.WriteLine($"Error OleDb: {oleDbEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar registro RUP:\n{ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error general: {ex.Message}");
                return false;
            }
            finally
            {
                if (cmd != null)
                    cmd.Dispose();
            }
        }
    }

    /// <summary>
    /// Clase para representar la información de un RUP
    /// </summary>
    public class RUPInfo
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdPerfil { get; set; }

        public override string ToString()
        {
            return $"RUP #{Id} - Usuario: {IdUsuario}, Perfil: {IdPerfil}";
        }
    }
}
