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
                            IdModelo = c.IdModeloNavigation!.IdModelo,
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

        public Carro UpdateCar(Guid idUsuario, Carro car)
        {

            var userCar = ctx.Carros.FirstOrDefault(x => x.IdUsuario == idUsuario);

            if (userCar != null)
            {
                userCar.IdModelo = car.IdModelo;
                userCar.Placa = car.Placa;  
                ctx.Entry(userCar).CurrentValues.SetValues(userCar);
            }
            else
            {
                Carro carro = new Carro();
                carro.Placa = car.Placa;
                carro.IdUsuario = idUsuario;
                carro.IdModelo = car.IdModelo;
                var modeloSelecionado = ctx.Modelos.Find(car.IdModelo);
                carro.BateriaAtual = 1;

                ctx.Carros.Add(carro);  
            }

            ctx.SaveChanges();
            return  car;

        }

        public Carro UpdateCarBattery(Guid idUsuario, Carro car)
        {
            try
            {
                var userCar = ctx.Carros.FirstOrDefault(x => x.IdUsuario == idUsuario);

                userCar!.BateriaAtual = car.BateriaAtual;
                ctx.Entry(userCar).CurrentValues.SetValues(userCar);
                ctx.SaveChanges();
                return car;

            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
