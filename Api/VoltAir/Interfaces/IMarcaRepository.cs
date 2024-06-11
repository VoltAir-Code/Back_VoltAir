﻿using VoltAir.Domains;

namespace VoltAir.Interfaces
{
    public interface IMarcaRepository
    {
        public List<Marca> GetMarca();

        Marca GetBrandById(Guid idMarca);
    }
}