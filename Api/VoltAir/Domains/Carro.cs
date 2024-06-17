using System;
using System.Collections.Generic;

namespace VoltAir.Domains;

public partial class Carro
{
    public Guid IdCarro { get; set; }

    public Guid? IdUsuario { get; set; }

    public Guid? IdRegistro { get; set; }

    public Guid? IdModelo { get; set; }

    public string? Placa { get; set; }

    public decimal? BateriaAtual { get; set; }

    public virtual Modelo? IdModeloNavigation { get; set; }

    public virtual Registro? IdRegistroNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
