using System;
using System.Collections.Generic;

namespace VoltAir.Domains;

public partial class Registro
{
    public Guid IdRegistro { get; set; }

    public Guid? IdCarro { get; set; }

    public DateTime? UltimaRecarga { get; set; }

    public DateTime? DuracaoRecarga { get; set; }

    public virtual Carro? IdCarroNavigation { get; set; }
}
