using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoltAir.Domains;
using VoltAir.Interfaces;
using VoltAir.Repositories;
using VoltAir.Contexts;

namespace VoltAir.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaRepository marcaRepository;

        public MarcaController(VoltaireContext context)
        {
            marcaRepository = new MarcaRepository(context);
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

        [HttpGet("BuscarPorId")]
        public IActionResult GetBrandById(Guid idMarca)
        {
            try
            {
                return Ok(marcaRepository.GetBrandById(idMarca));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }
    }
}
