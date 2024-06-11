using System;
using System.Collections.Generic;

namespace VoltAir.Domains;

public partial class Registro
{
    public Guid IdRegistro { get; set; }
<<<<<<< HEAD

    public Guid? IdCarro { get; set; }
=======
>>>>>>> b1e53c0fd7edac9fec8185233f2714036d7161b1

    public DateTime? UltimaRecarga { get; set; }

    public DateTime? DuracaoRecarga { get; set; }

    public virtual Carro? IdCarroNavigation { get; set; }
}
