using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using PS.Template.Domain.Entities;
using PS.Template.Domain.Queries;
using PS.Template.Domain.DTOs;
using System.Collections.Generic;

namespace PS.Template.AccessData.Queries
{
    public class UsuarioQuery : IAutenticationQuery
    {
        private readonly DBContext _dbContext;

        public UsuarioQuery(DBContext context)
        {
            _dbContext = context;
        }

        public Usuario GetUserByEmail(string email)
        {
            var usuarios = _dbContext.Usuarios
                .Where(u => u.Correo.Contains(email)).FirstOrDefault();

            return usuarios;
        }
        public Usuario GetUserByDNI(int dni)
        {
            var usuarios = _dbContext.Usuarios
                .Where(u => u.Dni == dni).FirstOrDefault();

            return usuarios;
        }

        public IList<UsuarioDTO> GetAll()
        {
            var usuarios = _dbContext.Usuarios
               .Select(c => new UsuarioDTO
               {
                   TipoId = c.TipoId,
                   Nombre = c.Nombre,
                   Apellido = c.Apellido,
                   NombreUsuario = c.NombreUsuario,
                   Contraseña = c.Contraseña,
                   Dni = c.Dni,
                   Correo = c.Correo,
                   Telefono = c.Telefono,
               })
               .ToList();
            return usuarios;
        }
    }
}
