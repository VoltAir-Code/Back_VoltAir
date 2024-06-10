﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Signers;
using System.IdentityModel.Tokens.Jwt;
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

                return Ok("Senha alterada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("AlterarFotoPerfil")]
        public async Task<IActionResult> UpdateProfileImage(Guid id, [FromForm] FotoUserViewModel form)
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
        public IActionResult PutUser(UsuarioViewModel user)
        {
            Guid idUsuario = Guid.Parse(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);

            return Ok(usuarioRepository.PutUser(idUsuario, user));
        }


    }
}
