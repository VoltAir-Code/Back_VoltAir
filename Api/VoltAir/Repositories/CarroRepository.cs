using Microsoft.EntityFrameworkCore;
using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;

namespace VoltAir.Repositories
{
    public class CarroRepository : ICarroRepository
    {
        VoltaireContext ctx = new VoltaireContext();

        public Carro GetCarById(Guid idUser)
        {
            try
            {

                return ctx.Carros
                    .Select(c => new Carro
                    {
                        IdCarro = c.IdCarro,
                        IdUsuario = c.IdUsuario,
                        IdModelo = c.IdModelo,
                        Placa = c.Placa,
                        BateriaAtual = c.BateriaAtual,

                        IdModeloNavigation = new Modelo
                        {
                            NomeModelo = c.IdModeloNavigation!.NomeModelo,
                            Capacidade = c.IdModeloNavigation!.Capacidade,
                            Autonomia = c.IdModeloNavigation!.Autonomia,
                            DurBateria = c.IdModeloNavigation!.DurBateria,
                            IdMarcaNavigation = new Marca
                            {
                                NomeMarca = c.IdModeloNavigation.IdMarcaNavigation!.NomeMarca,

                            }
                            
                        }

                    })
                    .FirstOrDefault(c => c.IdUsuario == idUser)!;



            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<Carro> GetCarro()
        {
            try
            {

                return ctx.Carros

                    .Select(c => new Carro
                    {
                        IdCarro = c.IdCarro



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


            searchCar!.Placa = car.Placa;


            ctx.Entry(searchCar).CurrentValues.SetValues(searchCar);

            ctx.SaveChanges();

            return searchCar;

        }

    }
}
