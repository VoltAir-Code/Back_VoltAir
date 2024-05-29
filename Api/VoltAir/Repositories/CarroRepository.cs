using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;

namespace VoltAir.Repositories
{
    public class CarroRepository: ICarroRepository
    {
        VoltaireContext ctx = new VoltaireContext();

        public List<Carro> GetCarro()
        {
            try
            {
                return ctx.Carros.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
