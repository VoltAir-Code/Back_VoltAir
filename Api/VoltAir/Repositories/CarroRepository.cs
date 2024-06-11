using Microsoft.EntityFrameworkCore;
using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;

namespace VoltAir.Repositories
{
    public class CarroRepository : ICarroRepository
    {
        VoltaireContext ctx = new VoltaireContext();

        public Carro GetCarById(Guid idCarro)
        {
            try
            {
                return ctx.Carros
                    .Include(c => c.IdMarcaNavigation).FirstOrDefault(c => c.IdCarro == idCarro)!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Carro> GetCarro()
        {
            try
            {
                return ctx.Carros
                    .Include(c => c.IdMarcaNavigation)
                    .Select(c => new Carro
                    {
                        IdCarro = c.IdCarro,
            

                        IdMarcaNavigation = new Marca
                        {
                            IdMarca = c.IdMarcaNavigation!.IdMarca,
                            NomeMarca = c.IdMarcaNavigation.NomeMarca
                        }
                    }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Carro UpdateCar(Guid idCarro, Carro car)
        {
            var searchCar = ctx.Carros.Find(idCarro);

            searchCar!.IdMarca = car.IdMarca;

            searchCar.Placa = car.Placa;

            ctx.Entry(searchCar).CurrentValues.SetValues(searchCar);

            ctx.SaveChanges();

            return searchCar;

        }

    }
}
