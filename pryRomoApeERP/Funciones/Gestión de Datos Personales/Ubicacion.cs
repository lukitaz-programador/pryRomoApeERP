using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRomoApeERP.Funciones
{
    public class Ubicacion
    {
        public string Provincia { get; set; }

        public string Localidad { get; set; }

        public string Direccion { get; set; }

        public string Geo { get; set; }

        public bool Residencia { get; set; }

        public override string ToString()
        {
            return $"{Provincia} - {Localidad} - {Direccion}";
        }
    }
}
