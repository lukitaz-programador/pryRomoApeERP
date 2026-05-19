using System;
using System.Data.OleDb;

namespace pryRomoApeERP.Base_de_Datos
{
    public class ConexionDB
    {
        private OleDbConnection conexion;

        public OleDbConnection Conexion
        {
            get { return conexion; }
        }

        public bool EstaConectado
        {
            get
            {
                return conexion != null &&
                       conexion.State == System.Data.ConnectionState.Open;
            }
        }

        public void Conectar(string rutaArchivo)
        {
            try
            {
                string cadenaConexion =
                $@"Provider=Microsoft.ACE.OLEDB.12.0;
                Data Source={rutaArchivo};
                Persist Security Info=False;";

                conexion = new OleDbConnection(cadenaConexion);

                conexion.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al conectar con la base de datos:\n" +
                    ex.Message);
            }
        }

        public void Desconectar()
        {
            if (conexion != null)
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }

                conexion.Dispose();
                conexion = null;
            }
        }
    }
}