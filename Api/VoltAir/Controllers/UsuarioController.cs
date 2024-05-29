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
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository usuarioRepository {  get; set; }

        public UsuarioController()
        {
            usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(UsuarioViewModel userModel)
        {
            try
            {
                Usuario newUser = new Usuario();

                newUser.Email = userModel.Email!;
                newUser.Senha = userModel.Senha;
                newUser.Nome = userModel.Nome;
                newUser.IdCarro = userModel.IdCarro;
                newUser.Foto = userModel.Foto;

                usuarioRepository.UserRegister(newUser);
                return Ok();

            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException);
            }
        }

        [HttpPut("AlterarSenha")]
        public IActionResult UpdatePassword(string email, AlterarSenhaViewModel passWord)
        {
            try
            {
                usuarioRepository.ChangePassword(email, passWord.SenhaNova!);

                return Ok("Senha alterada com sucesso !");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
