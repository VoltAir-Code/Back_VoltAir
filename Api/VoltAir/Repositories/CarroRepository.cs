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
         .FirstOrDefault(c => c.IdCarro == idCarro)!;



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
                carro.BateriaAtual = modeloSelecionado!.DurBateria;

                ctx.Carros.Add(carro);  
            }


            ctx.SaveChanges();







            return  car;

        }

    }
}
