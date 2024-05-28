using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoltAir.Domains;
using VoltAir.Interfaces;
using VoltAir.Repositories;

namespace VoltAir.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuario usuarioRepository {  get; set; }

        public UsuarioController()
        {
            usuarioRepository = new UsuarioRepository();
        }


    }
}
