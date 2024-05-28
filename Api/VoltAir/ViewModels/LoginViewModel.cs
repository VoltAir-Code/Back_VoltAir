using System.ComponentModel.DataAnnotations;

namespace VoltAir.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email Obrigatório")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Senha Obrigatória")]
        public string? Password { get; set; }
    }
}
