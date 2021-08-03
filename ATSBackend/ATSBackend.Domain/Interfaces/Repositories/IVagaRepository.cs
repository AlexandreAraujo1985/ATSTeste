using ATSBackend.Domain.Entities;
using System.Collections.Generic;

namespace ATSBackend.Domain.Interfaces.Repositories
{
    public interface IVagaRepository : IRepositoryBase<Vaga>
    {
        IEnumerable<Vaga> ListarVagasEmAberto();
    }
}
