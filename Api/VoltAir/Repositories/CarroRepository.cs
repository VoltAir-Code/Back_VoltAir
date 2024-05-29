using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;

namespace VoltAir.Repositories
{
    public class CarroRepository : ICarroRepository
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

        public Carro UpdateCar(Guid idCarro, Carro car)
        {
            var searchCar = ctx.Carros.Find(idCarro);

            searchCar.IdMarca = car.IdMarca;
            searchCar.Modelo = car.Modelo;
            searchCar.Placa = car.Placa;

            ctx.Entry(searchCar).CurrentValues.SetValues(searchCar);

            ctx.SaveChanges();

            return searchCar;

        }
    }
}
