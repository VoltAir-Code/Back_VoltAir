using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoltAir.Domains;
using VoltAir.Utils.OCR;

namespace VoltAir.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrcController : ControllerBase
    {
        private readonly OcrService _ocrService;

        public OrcController(OcrService orcService)
        {
            _ocrService = orcService;
        }

        [HttpPost]
        public async Task<IActionResult> RecognizeText([FromForm] FileUploadModel fileUploadModel)
        {
            try
            {
                if (fileUploadModel == null || fileUploadModel.Image == null)
                {
                    return BadRequest("Nenhuma imagem fornecida");
                }

                using (var stream = fileUploadModel.Image.OpenReadStream())
                {
                    var result = await _ocrService.RecognizeTextAsync(stream);

                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao processar a imagem" + ex.Message);
            }
        }
    }
}
    