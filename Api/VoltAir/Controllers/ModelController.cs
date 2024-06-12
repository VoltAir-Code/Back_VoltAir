using Microsoft.AspNetCore.Mvc;
using VoltAir.Contexts;
using VoltAir.Interfaces;
using VoltAir.Repositories;

namespace VoltAir.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {

        private readonly IModelRepository modelRepository;

        public ModelController(VoltaireContext context)
        {
            modelRepository = new ModelRepository(context);
        }


        [HttpGet]
        public IActionResult GetModel()
        {
            try
            {
                return Ok(modelRepository.GetModel());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException);
            }
        }

        [HttpGet("BuscarPorId")]
        public IActionResult GetModelById(Guid idModelo)
        {
            try
            {
                return Ok(modelRepository.GetModelById(idModelo));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }
    }
}
