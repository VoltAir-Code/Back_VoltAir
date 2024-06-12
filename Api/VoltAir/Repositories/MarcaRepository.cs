
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
                return null;
            }
            catch (Exception)
            {

                try
                {
                    return null;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


            public Marca GetBrandById(Guid idMarca)
            {
                try
                {
                    return ctx.Marcas
                    
                        .FirstOrDefault(c => c.IdMarca == idMarca)!;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }