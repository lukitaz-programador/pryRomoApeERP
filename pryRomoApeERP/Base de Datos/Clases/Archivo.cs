using System;
using System.IO;
using System.Windows.Forms;

namespace pryRomoApeERP.Base_de_Datos
{
    public class Archivo
    {
        public string NombreArchivo { get; set; }

        private ConexionDB conexionDB;
        public ConexionDB Conexion
        {
            get { return conexionDB; }
        }

        public Archivo(string nombreArchivo)
        {
            NombreArchivo = nombreArchivo;

            InicializarConexion();
        }

        private void InicializarConexion()
        {
            try
            {
                // Use the explicit absolute path provided
                string rutaBD =
                Path.Combine(
                 Application.StartupPath,
                 "Base de Datos",
                 "RomoBD.accdb");
                
                rutaBD = Path.GetFullPath(rutaBD);

                if (!File.Exists(rutaBD))
                {
                    MessageBox.Show(
                        $"No se encontró la base de datos:\n{rutaBD}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                conexionDB = new ConexionDB();
                conexionDB.Conectar(rutaBD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n" + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}