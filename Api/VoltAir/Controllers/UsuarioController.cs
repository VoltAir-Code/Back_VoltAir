using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Signers;
using System.IdentityModel.Tokens.Jwt;
using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;
using VoltAir.Repositories;
using VoltAir.Utils.BlobStorage;
using VoltAir.ViewModels;

namespace VoltAir.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

       VoltaireContext ctx = new VoltaireContext();
        private IUsuarioRepository usuarioRepository {  get; set; }

        public UsuarioController()
        {
            usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post([FromBody] UsuarioViewModel userModel)
        {
            try
            {
                Usuario newUser = new Usuario();


                var userSearch = ctx.Usuarios.FirstOrDefault(x => x.Email == userModel.Email);
                if(userSearch != null)
                {
                    return BadRequest("Email já está registrado!");
                }
                newUser.Email = userModel.Email!;
                newUser.Senha = userModel.Senha!;
                newUser.Nome = userModel.Nome!;
         


                usuarioRepository.UserRegister(newUser);
                return Ok();

            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException);
            }
        }

        [HttpGet("BuscarPorId")]
        public IActionResult GetById(Guid id) 
        {
            try
            {
                return Ok(usuarioRepository.GetById(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }

        [HttpPut("AlterarSenha")]
        public IActionResult UpdatePassword(string email, [FromBody] AlterarSenhaViewModel passWord)
        {
            try
            {
                usuarioRepository.ChangePassword(email, passWord.SenhaNova!);

                return Ok("Senha alterada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("AlterarFotoPerfil")]
        public async Task<IActionResult> UpdateProfileImage(Guid id,  FotoUserViewModel form)
        {
            try
            {
                Usuario searchUser = usuarioRepository.GetById(id);

                if (searchUser == null)
                {
                return NotFound();
                }

                var connectionString = "";
                var containerName = "";

                string fotoUrl = await AzureBlobStorage.UploadImageBlobAsync(form.Arquivo!, connectionString!, containerName!);


              searchUser.Foto = fotoUrl;

                usuarioRepository.PutFoto(id, fotoUrl);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [HttpPut("AlterarPerfil")]
        public IActionResult PutUser([FromBody] UsuarioViewModel user)
        {
            Guid idUsuario = Guid.Parse(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);

            return Ok(usuarioRepository.PutUser(idUsuario, user));
        }


    }
}
