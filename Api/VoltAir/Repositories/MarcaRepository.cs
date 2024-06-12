
using Microsoft.EntityFrameworkCore;
using System.Linq;
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
                return ctx.Marcas.ToList();

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
                        .Include(c => c.Modelos)
                    .FirstOrDefault(c => c.IdMarca == idMarca)!;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}