using System;
using System.Collections.Generic;

namespace VoltAir.Domains;

public partial class Usuario
{
    public Guid IdUsuario { get; set; } = Guid.NewGuid();

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public int? CodRecupSenha { get; set; }

    public string? Foto { get; set; }

    public virtual ICollection<Carro> Carros { get; set; } = new List<Carro>();
}
