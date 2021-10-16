using Microsoft.AspNetCore.Mvc;
using PS.Template.Application.Services;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Queries;
using System.Collections.Generic;

namespace PS.Template.API.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioService _service;
        
        public UsuarioController(IUsuarioService service)
        {
            _service = service;   
        }

        [HttpPost]
        public Usuario CreateUsuario(UsuarioDTO usuario)
        {
            return _service.CreateUsuario(usuario);
        }

        [HttpGet("{dni:int}")]
        public Usuario GetUserByDNI(int dni)
        {
            return _service.GetUserByDNI(dni);
        }

        [HttpGet("{email:string}")]
        public Usuario GetUserByEmail(string email)
        {
            return _service.GetUserByEmail(email);
        }

        [HttpGet]
        public IList<UsuarioDTO> GetAll()
        {
            return _service.GetAll();
        }

    }
}
