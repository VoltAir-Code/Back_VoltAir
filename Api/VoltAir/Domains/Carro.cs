using System;
using System.Collections.Generic;

namespace VoltAir.Domains;

public partial class Carro
{
    public Guid IdCarro { get; set; }

    public Guid? IdMarca { get; set; }

    public Guid? IdRegistro { get; set; }

    public string? Modelo { get; set; }

    public string? Placa { get; set; }

    public TimeOnly? DurBateria { get; set; }

    public virtual Marca? IdMarcaNavigation { get; set; }

    public virtual Registro? IdRegistroNavigation { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
