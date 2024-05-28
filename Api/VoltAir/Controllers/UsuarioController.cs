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
        private IUsuarioRepository usuarioRepository {  get; set; }

        public UsuarioController()
        {
            usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(Usuario newUser)
        {
            try
            {
                usuarioRepository.UserRegister(newUser);
                return Ok();

            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException);
            }
        }


    }
}
