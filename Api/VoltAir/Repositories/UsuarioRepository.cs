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
             
                var userSearch = ctx.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == password);

                if (userSearch == null) return null!;

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
