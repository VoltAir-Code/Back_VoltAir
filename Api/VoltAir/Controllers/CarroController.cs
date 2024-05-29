using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoltAir.Interfaces;
using VoltAir.Repositories;

namespace VoltAir.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        private ICarroRepository carroRepository { get; set; }

        public CarroController()
        {
            carroRepository = new CarroRepository();
        }

        [HttpGet]
        public IActionResult GetCarros()
        {
            try
            {
                return Ok(carroRepository.GetCarro());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }
    }
}
