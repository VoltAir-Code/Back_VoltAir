using Microsoft.EntityFrameworkCore;
using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;
using VoltAir.Utils;
using VoltAir.ViewModels;

namespace VoltAir.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        VoltaireContext ctx = new VoltaireContext();

        public bool ChangePassword(string email, string newPassword)
        {
            try
            {
                var user = ctx.Usuarios.FirstOrDefault(x => x.Email == email);

                if (user == null)
                    return false;

                user.Senha = Criptografia.CreateHash(newPassword);

                ctx.Update(user);

                ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario GetByEmailPassword(string email, string password)
        {
            try
            {

                var userSearch = ctx.Usuarios.FirstOrDefault(x => x.Email == email);

                if (userSearch == null)
                    return null!;


                if (!Criptografia.CompararHash(password, userSearch.Senha!))
                    return null!;


                return userSearch;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Usuario GetById(Guid id)
        {
            return ctx.Usuarios.FirstOrDefault(x => x.IdUsuario == id)!;
        }

        public void PutFoto(Guid id, string newUrl)
        {
            try
            {
                Usuario searchUser = ctx.Usuarios.FirstOrDefault(x => x.IdUsuario == id)!;



                if (searchUser != null)
                {
                    searchUser.Foto = newUrl;
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario PutUser(Guid id, UsuarioViewModel usuario)
        {
            try
            {

                var searchUser = ctx.Usuarios.FirstOrDefault(x => x.IdUsuario == id);


                if (searchUser == null)
                    return null;


        


                ctx.Usuarios.Update(searchUser);

                ctx.SaveChanges();
                return searchUser;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UserRegister(Usuario usuario)
        {
            try
            {

                var userSearch = ctx.Usuarios.FirstOrDefault(x => x.Email == usuario.Email);

                if (userSearch != null)
                {

                    return;
                }

                usuario.Senha = Criptografia.CreateHash(usuario.Senha!);
                ctx.Add(usuario);
                ctx.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
