using Microsoft.AspNetCore.Http.HttpResults;
using VoltAir.Contexts;
using VoltAir.Domains;
using VoltAir.Interfaces;

namespace VoltAir.Repositories
{
    public class RegistroRepository : IRegistroRepository
    { 
        VoltaireContext ctx = new VoltaireContext();
        public void NewRegistro(Registro registro)
        {
            try
            {
                ctx.Registros.Add(registro);
                ctx.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
