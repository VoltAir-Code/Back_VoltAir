using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoltAir.ViewModels
{
    public class UsuarioViewModel
    {

        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
    

    
    }
}
