using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;
using VoltAir.Utils;

namespace VoltAir.Repositories
{
    public class UsuarioRepository : IUsuario
    {
		VoltaireContext ctx = new VoltaireContext();
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
