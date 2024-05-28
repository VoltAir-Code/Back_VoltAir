using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;
using VoltAir.Utils;

namespace VoltAir.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        VoltaireContext ctx = new VoltaireContext();
        public Usuario GetByEmailPassword(string email, string password)
        {
            try
            {
             
                var userSearch = ctx.Usuarios.FirstOrDefault(x => x.Email == email);

                if (userSearch == null) return null!;


                if (!Criptografia.CompararHash(password, userSearch.Senha!)) return null!;


                return userSearch;
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
