using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System.Collections.Generic;

namespace PS.Template.Domain.Queries
{
    public interface IUsuarioQueries
    {
        public IList<UsuarioDTO> GetAll();
        public Usuario GetUserByEmail(string email);
        public Usuario GetUserByDNI(int dni);
        public Usuario GetUsuarioByUsernameAndPasswd(string username);

    }
}
