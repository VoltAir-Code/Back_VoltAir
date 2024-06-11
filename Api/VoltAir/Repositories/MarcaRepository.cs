using Microsoft.EntityFrameworkCore;
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
                return ctx.Marcas.Include(x => x.Carros).ToList();
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
