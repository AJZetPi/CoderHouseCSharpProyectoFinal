using CoderHouse_CSharp_API.Model;
using CoderHouse_CSharp_API.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.CompilerServices;

namespace CoderHouse_CSharp_API.Controllers
{

    [DisableCors]
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        
        [HttpGet]
        public List<Usuario> Get()
        {
            return ADO_Usuario.DevolverUsuarios();
        }
        [HttpGet]
        [Route("{NombreUsuario}/{Contraseña}")]
        public List<Usuario> Login([FromRoute]string NombreUsuario, string Contraseña)
        {
            return ADO_Usuario.DevolverLogin(NombreUsuario, Contraseña);
        }

        [HttpDelete]
        public void Eliminar([FromBody] int id) 
        {
            ADO_Usuario.EliminarUsuarios(id);
        }
        
        [HttpPut]
        public void Modificar([FromBody] Usuario usuario)
        {
            ADO_Usuario.ModificarUsuarios(usuario);
        }
        
        [HttpPost]
        public void Agregar([FromBody] Usuario usuario)
        {
            ADO_Usuario.AgregarUsuarios(usuario);
        }
    }
}
