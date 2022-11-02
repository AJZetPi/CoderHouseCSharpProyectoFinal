using CoderHouse_CSharp_API.Model;
using CoderHouse_CSharp_API.Repository;
using CoderHouseCSharp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoderHouseCSharp.Controllers
{
    [Route("api/{Controller}")]
    [ApiController]
    public class NombreController : ControllerBase
    {
        [HttpGet]
        [Route("/NombrePorId/{id}")]
        public List<Usuario> GetNombrePorId([FromRoute] long id)
        {
            return ADO_Nombre.DevolverNombrePorId(id);
        }
        [HttpGet]
        [Route("/NombrePorNombreUsuario/{NombreUsuario}")]
        public List<Usuario> GetNombrePorNombreUsuario([FromRoute] string NombreUsuario)
        {
            return ADO_Nombre.DevolverNombrePorNombreUsuario(NombreUsuario);
        }
    }
}
