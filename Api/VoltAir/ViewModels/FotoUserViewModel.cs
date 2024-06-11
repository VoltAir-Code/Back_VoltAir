using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VoltAir.ViewModels
{
    public class FotoUserViewModel
    {
        [NotMapped]
        [JsonIgnore]
        public IFormFile? Arquivo { get; set; }

        public string? Foto { get; set; }


    }
}
