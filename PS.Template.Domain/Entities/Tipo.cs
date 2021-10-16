using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public class Tipo
    {
        public int TipoId { get; set; }

        public string Descripcion { get; set; }

        public virtual IList<Usuario> Usuarios { get; set; }
    }
}
