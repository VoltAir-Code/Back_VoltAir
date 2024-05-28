using VoltAir.Domains;

namespace VoltAir.Interfaces
{
    public interface IUsuario
    {
        Usuario GetByEmailPassword(string email, string password);
    }
}
