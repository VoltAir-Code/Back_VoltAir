using System.Linq;
using Microsoft.EntityFrameworkCore;
using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;

namespace VoltAir.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly VoltaireContext ctx;

        public MarcaRepository(VoltaireContext context)
        {
            ctx = context;
        }

        public List<Marca> GetMarca()
        {
            try
            {
                return ctx.Marcas.Include(m => m.Carros).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Marca GetBrandById(Guid idMarca)
        {
            try
            {
                return ctx.Marcas
                    .Include(m => m.Carros)
                    .FirstOrDefault(c => c.IdMarca == idMarca)!;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}