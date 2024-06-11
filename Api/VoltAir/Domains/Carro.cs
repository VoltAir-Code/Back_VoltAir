using System;
using System.Collections.Generic;

namespace VoltAir.Domains;

public partial class Carro
{
    public Guid IdCarro { get; set; }
<<<<<<< HEAD

    public Guid? IdMarca { get; set; }

    public string? Modelo { get; set; }
=======

    public Guid? IdUsuario { get; set; }

    public Guid? IdMarca { get; set; }

    public Guid? IdRegistro { get; set; }

    public Guid? IdModelo { get; set; }
>>>>>>> b1e53c0fd7edac9fec8185233f2714036d7161b1

    public string? Placa { get; set; }

    public DateTime? BateriaAtual { get; set; }

    public DateTime? CapacidadeAtual { get; set; }

    public virtual Marca? IdMarcaNavigation { get; set; }

<<<<<<< HEAD
    public virtual ICollection<Registro> Registros { get; set; } = new List<Registro>();
=======
    public virtual Modelo? IdModeloNavigation { get; set; }

    public virtual Registro? IdRegistroNavigation { get; set; }
>>>>>>> b1e53c0fd7edac9fec8185233f2714036d7161b1

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
