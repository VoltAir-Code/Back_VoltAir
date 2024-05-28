﻿using System;
using System.Collections.Generic;

namespace VoltAir.Domains;

public partial class Marca
{
    public Guid IdMarca { get; set; } = Guid.NewGuid();

    public string? NomeMarca { get; set; }

    public virtual ICollection<Carro> Carros { get; set; } = new List<Carro>();
}
