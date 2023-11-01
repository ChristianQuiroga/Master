using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioAccesoController : ControllerBase
    {
        //GET
        //[HttpGet(Name = "ListarNombreUsuario")]
        [HttpGet]
        [Route("ListarNombreUsuario")]
        public IEnumerable<Usuario> get(string user, string password)
        {
            return UsuarioBussiness.TraerNombre(user, password).ToArray();

        }

        //Get
        [HttpGet]
        [Route("ValidarUsuario")]
        public bool Get(string user, string password)
        {
            return UsuarioBussiness.ValidarUsuario(user, password);
        }

        //Get nombre
        //[HttpGet(Name = "ListarNombreUsuario")]
        //public void Get([FromBody] int Id)
        //public IEnumerable<Usuario> get(int Id)
        //{
        //    return UsuarioBussiness.ObtenerNombreUsuario(Id).ToArray();

        //}
    }
}
