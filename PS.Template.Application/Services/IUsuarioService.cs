using PS.Template.Domain.Entities;
using PS.Template.Domain.DTOs;
using System.Collections.Generic;

namespace PS.Template.Application.Services
{
    public interface IUsuarioService
    {
        Usuario CreateUsuario(UsuarioDTO usuario);

        Usuario GetUserByEmail(string email);

        Usuario GetUserByDNI(int dni);

        IList<UsuarioDTO> GetAll();

        Usuario GetUsuarioByUsernameAndPasswd(string username);
    }
}
