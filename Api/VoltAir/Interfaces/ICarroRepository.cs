using VoltAir.Domains;

namespace VoltAir.Interfaces
{
    public interface ICarroRepository
    {
        public List<Carro> GetCarro();

        Carro UpdateCar(Guid idUsuario,Carro car);

        Carro UpdateCarBattery(Guid idUsuario, Carro car);

        Carro GetCarById(Guid idUsuario);
    }
}
