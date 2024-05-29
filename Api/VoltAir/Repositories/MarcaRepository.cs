using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;

namespace VoltAir.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        VoltaireContext ctx = new VoltaireContext();
        public List<Marca> GetMarca()
        {
			try
			{
                return ctx.Marcas.ToList();
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
