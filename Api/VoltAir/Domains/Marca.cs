using System;
using System.Collections.Generic;

namespace VoltAir.Domains;

public partial class Marca
{
    public Guid IdMarca { get; set; }

    public string? NomeMarca { get; set; }

    public virtual ICollection<Modelo> Modelos { get; set; } = new List<Modelo>();
}
