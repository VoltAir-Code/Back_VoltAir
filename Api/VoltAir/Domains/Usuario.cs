using System;
using System.Collections.Generic;

namespace VoltAir.Domains;

public partial class Usuario
{
    public Guid IdUsuario { get; set; }

    public Guid? IdCarro { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public string? CodRecupSenha { get; set; }

    public string? Foto { get; set; }

    public virtual Carro? IdCarroNavigation { get; set; }
}
