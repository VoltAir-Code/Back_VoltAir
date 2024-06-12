using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;

namespace VoltAir.Repositories
{
    public class ModelRepository : IModelRepository
    {

        private readonly VoltaireContext ctx;

        public ModelRepository(VoltaireContext context)
        {
            ctx = context;
        }


        public List<Modelo> GetModel()
        {


            try
            {
                return ctx.Modelos.ToList();

            }
            catch (Exception)
            {
                throw;
            }

        }

        public Modelo GetModelById(Guid idModelo)
        {
            try
            {
                return ctx.Modelos
                     
                    .FirstOrDefault(c => c.IdModelo == idModelo)!;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
