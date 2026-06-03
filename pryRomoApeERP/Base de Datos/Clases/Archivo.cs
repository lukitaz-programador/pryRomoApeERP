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
                string rutaBD =
                Path.Combine(
                Application.StartupPath,
                @"..\..\Base de Datos\Bases",
                 NombreArchivo);

                rutaBD = Path.GetFullPath(rutaBD);

                if (!File.Exists(rutaBD))
                {
                    MessageBox.Show(
                        $"No se encontró la base de datos:\n{rutaBD}");
                    return;
                }

                conexionDB = new ConexionDB();
                conexionDB.Conectar(rutaBD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}