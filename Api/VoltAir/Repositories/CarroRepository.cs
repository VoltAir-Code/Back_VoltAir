using Microsoft.AspNetCore.Http.HttpResults;
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

                var carro = ctx.Carros.Include(x => x.IdModeloNavigation!.IdMarcaNavigation).FirstOrDefault(x => x.IdUsuario == idUser);

                return carro;
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

                if(userCar == null)
                {
                    return null;
                }

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
