using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;

namespace VoltAir.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        VoltaireContext ctx = new VoltaireContext();
        public Usuario GetByEmailPassword(string email, string password)
        {
            try
            {
                var userSearch = ctx.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == password);

                return userSearch;
            }
            catch (Exception)
            {

                throw;
            }
   
        }



    }
}
