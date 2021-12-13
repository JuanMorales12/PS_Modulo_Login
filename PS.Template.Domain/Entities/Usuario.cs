
namespace PS.Template.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public int TipoId{ get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreUsuario { get; set; }

        public string Contraseña { get; set; }

        public string Direccion { get; set; }

        public int Dni { get; set; }

        public string Correo { get; set; }

        public int Telefono { get; set; }

        public Tipo Tipos { get; set; }
    }
}
