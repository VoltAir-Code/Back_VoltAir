using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoltAir.Domains;
using VoltAir.Interfaces;
using VoltAir.Repositories;

namespace VoltAir.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private IMarcaRepository marcaRepository { get; set; }

        public MarcaController()
        {
            marcaRepository = new MarcaRepository();
        }

        [HttpGet]
        public IActionResult GetMarcas()
        {
            try
            {
                return Ok(marcaRepository.GetMarca());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException);
            }
        }
    }
}
