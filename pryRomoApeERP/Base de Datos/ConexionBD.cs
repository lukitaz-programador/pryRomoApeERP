using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRomoApeERP.Base_de_Datos
{
    public class ConexionDB
    {
        private string _rutaArchivo;

        public string CadenaConexion { get; private set; }
        public bool EstaConectado { get; private set; }

        /// Establece la ruta del archivo .accdb/.mdb y construye la cadena de conexión.
        public void Conectar(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
                throw new ArgumentException("La ruta del archivo no puede estar vacía.");

            _rutaArchivo = rutaArchivo;
            CadenaConexion = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={_rutaArchivo};Persist Security Info=False;";
            EstaConectado = true;
        }

        /// Desconecta limpiando la cadena de conexión.
        public void Desconectar()
        {
            CadenaConexion = null;
            _rutaArchivo = null;
            EstaConectado = false;
        }
    }
}

