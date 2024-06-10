using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoltAir.Domains;
using VoltAir.Interfaces;
using VoltAir.Repositories;
using VoltAir.ViewModels;

namespace VoltAir.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        private IRegistroRepository registroRepository { get; set; }

        public RegistroController()
        {
            registroRepository = new RegistroRepository();
        }

        [HttpPost]
        public IActionResult NewRegister(RegistroViewModel registroViewModel)
        {
            try
            {
                Registro newRegistro = new Registro();
                newRegistro.UltimaRecarga = registroViewModel.UltimaRecarga;
                newRegistro.DuracaoRecarga = registroViewModel.DuracaoRecarga;
                registroRepository.NewRegistro(newRegistro);
                return Ok();

            }
            catch (Exception ex)
            {

               return BadRequest(ex.InnerException);
            }
        }
    }
}
