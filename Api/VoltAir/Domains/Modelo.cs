using System;
using System.Collections.Generic;

namespace VoltAir.Domains;

public partial class Modelo
{
    public Guid IdModelo { get; set; }

    public string? NomeModelo { get; set; }

    public int? Autonomia { get; set; }

    public int? Capacidade { get; set; }

    public DateTime? DurBateria { get; set; }

    public virtual ICollection<Carro> Carros { get; set; } = new List<Carro>();
}
