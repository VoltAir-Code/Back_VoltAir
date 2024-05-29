using System.ComponentModel.DataAnnotations;

namespace VoltAir.ViewModels
{
    public class UsuarioViewModel
    {

        [Required(ErrorMessage = "Nome Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email Obrigatório")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Senha Obrigatória")]
        public string Senha { get; set; }
        public Guid? IdCarro { get; set; }

        public string? Foto { get; set; }
    }
}
