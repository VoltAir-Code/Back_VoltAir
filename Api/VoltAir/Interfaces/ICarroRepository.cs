using VoltAir.Domains;

namespace VoltAir.Interfaces
{
    public interface ICarroRepository
    {
        public List<Carro> GetCarro();

        Carro UpdateCar(Guid idCarro,Carro car);

        Carro GetCarById(Guid idUsuario);
    }
}
