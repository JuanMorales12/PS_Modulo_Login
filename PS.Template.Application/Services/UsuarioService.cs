using PS.Template.Domain.DTOs;
using PS.Template.Domain.Commands;
using PS.Template.Domain.Entities;
using System.Collections.Generic;
using PS.Template.Domain.Queries;

namespace PS.Template.Application.Services
{
    
    public class UsuarioService : IUsuarioService
    {
        private readonly IGenericsRepository _repository;
        private readonly IAutenticationQuery _query;

        

        public UsuarioService(IGenericsRepository repository, IAutenticationQuery query)
        {
            _repository = repository;
            _query = query;
        }
        public Usuario CreateUsuario(UsuarioDTO usuario)
        {
            var entity = new Usuario
            {
                TipoId = usuario.TipoId,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                NombreUsuario = usuario.NombreUsuario,
                Contraseña = usuario.Contraseña,
                Dni = usuario.Dni,
                Correo = usuario.Correo,
                Telefono = usuario.Telefono,

            };
            _repository.Add<Usuario>(entity);

            return entity;
        }

        public Usuario GetUserByEmail(string email)
        {
            return _query.GetUserByEmail(email);
        }

        public Usuario GetUserByDNI(int dni)
        {
            return _query.GetUserByDNI(dni);
        }

        public IList<UsuarioDTO> GetAll()
        {
            return _query.GetAll();
        }

    }
}
