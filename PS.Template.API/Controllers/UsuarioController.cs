using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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



        [HttpPost("create")]
        public IActionResult CreateUsuario([FromBody] UsuarioDTO usuarioNuevo)
        {

            UsuarioDTO_data userData; //Aca despues va lo del token
            Usuario usuario;

            usuario = _service.GetUsuarioByUsernameAndPasswd(usuarioNuevo.NombreUsuario);

            if (usuario == null)
            {
                usuario = _service.CreateUsuario(usuarioNuevo);

                if (usuario != null)
                {
                    userData = new UsuarioDTO_data
                    {
                        UsuarioId = usuario.UsuarioId,
                        TipoId = usuario.TipoId
                    };

                    return StatusCode(201, userData);
                }
                else
                {
                    userData = new UsuarioDTO_data
                    {
                        UsuarioId = -1,
                        TipoId = -1
                    };

                    return StatusCode(404, userData);
                }
            }
            else
            {
                userData = new UsuarioDTO_data
                {
                    UsuarioId = -1,
                    TipoId = -2
                };

                return StatusCode(400, userData);
            }
        }

        /*
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
        }*/

        [HttpPost]
        public IActionResult GetUsuarioByUsernameAndPasswd([FromBody] UsuarioDTO_login usuarioDTO_login)
        {

            UsuarioDTO_data userData; //Aca despues va lo del token
            Usuario usuario;

            if (usuarioDTO_login.NombreUsuario == null || usuarioDTO_login.Clave == null)
            {
                return StatusCode(400);
            }
            else
            {
                usuario = _service.GetUsuarioByUsernameAndPasswd(usuarioDTO_login.NombreUsuario);
            }

            if (usuario != null)
            {
                userData = new UsuarioDTO_data{
                    UsuarioId = usuario.UsuarioId,
                    TipoId = usuario.TipoId
                };

                return StatusCode(200, userData);
            }
            else
            {
                userData = new UsuarioDTO_data{
                    UsuarioId = -1,
                    TipoId = 0
                };
                
                return StatusCode(404,userData);
            }

        }

    }
}
