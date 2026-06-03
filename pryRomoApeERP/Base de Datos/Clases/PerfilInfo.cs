namespace pryRomoApeERP.Base_de_Datos
{
    public class PerfilInfo
    {
        public int IdPerfil { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}
