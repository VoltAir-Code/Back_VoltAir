using System.ComponentModel.DataAnnotations;

namespace VoltAir.ViewModels
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "Ultima Obrigatória")]
        public DateTime? UltimaRecarga { get; set; }

        [Required(ErrorMessage = "Duração Obrigatória")]
        public DateTime? DuracaoRecarga { get; set; }
    }
}
