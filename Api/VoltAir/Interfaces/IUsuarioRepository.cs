using VoltAir.Domains;
using VoltAir.ViewModels;

namespace VoltAir.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario GetByEmailPassword(string email, string password);

        public void UserRegister(Usuario usuario);

        public bool ChangePassword(string email, string newPassword);

        Usuario GetById(Guid id);

        void PutFoto(Guid id, string newUrl);

        Usuario PutUser(Guid id, UsuarioViewModel usuario);

    }
}
