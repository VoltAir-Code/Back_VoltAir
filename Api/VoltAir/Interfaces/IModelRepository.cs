using VoltAir.Domains;

namespace VoltAir.Interfaces
{
    public interface IModelRepository
    {

        public List<Modelo> GetModel();

        Modelo GetModelById(Guid idModelo);

    }
}
