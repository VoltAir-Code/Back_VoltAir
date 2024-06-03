using System;
using System.Collections.Generic;

namespace VoltAir.Domains;

public partial class Registro
{
    public Guid IdRegistro { get; set; } = Guid.NewGuid();

    public DateTime? UltimaRecarga { get; set; }

    public DateTime? DuracaoRecarga { get; set; }

    public virtual ICollection<Carro> Carros { get; set; } = new List<Carro>();
}
