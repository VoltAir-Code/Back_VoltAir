using VoltAir.Domains;

namespace VoltAir.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario GetByEmailPassword(string email, string password);

        public void UserRegister(Usuario usuario);

        public bool ChangePassword(string email, string newPassword);
    }
}
