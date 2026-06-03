using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRomoApeERP.Funciones.Gestión_de_Datos_Personales
{
    public class Contacto
    {
        public int IdTipoContacto { get; set; }

        public string TipoContacto { get; set; }

        public string Valor { get; set; }

        public override string ToString()
        {
            return $"{TipoContacto}: {Valor}";
        }
    }
}
