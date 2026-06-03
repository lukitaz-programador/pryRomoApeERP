using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRomoApeERP.Funciones.Login
{
    public static class Seguridad
    {
        public static bool EsAdmin()
        {
            return Sesion.IdPerfil == Perfiles.Admin;
        }
    }
}
