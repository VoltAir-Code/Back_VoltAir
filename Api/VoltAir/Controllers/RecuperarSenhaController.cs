using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoltAir.Contexts;
using VoltAir.Utils.Mail;

namespace VoltAir.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecuperarSenhaController : ControllerBase
    {
        private readonly VoltaireContext _context;
        private readonly EmailSendingService _emailSendingService;


        public RecuperarSenhaController(VoltaireContext context, EmailSendingService emailSendingService)
        {
            _context = context;
            _emailSendingService = emailSendingService;

        }

        [HttpPost]
        public async Task<IActionResult> SendRecoveryCodePassword(string email)
        {
            try
            {
                var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.Email == email);

                if (user == null)
                {
                    return BadRequest("Email Inválido!");
                }

                Random random = new Random();
                int recoveryCode = random.Next(1000, 9999);
                user.CodRecupSenha = recoveryCode;

                await _context.SaveChangesAsync();

                await _emailSendingService.SendRecoveryPassword(user!.Email!, recoveryCode);

                return Ok("Código de confirmação enviado com sucesso!");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost("ValidarCodigoDeRecuperacaoSenha")]
        public async Task<IActionResult> ValidatePasswordRecoveryCode(string email, int code)
        {
            try
            {
                var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);

                if (user == null)
                {
                    return NotFound("Usuário não encontrado!");
                }


                if (user.CodRecupSenha != code)
                {
                    return BadRequest("Código de recuperação é inválido");
                }


                user.CodRecupSenha = null;

                await _context.SaveChangesAsync();

                return Ok("Códgio de recuperação está correto!");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
