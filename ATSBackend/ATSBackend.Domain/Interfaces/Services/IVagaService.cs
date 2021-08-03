using ATSBackend.Domain.Entities;
using System.Collections.Generic;

namespace ATSBackend.Domain.Interfaces.Services
{
    public interface IVagaService : IServiceBase<Vaga>
    {
        IEnumerable<Vaga> ListarVagasEmAberto();
        void EncerrarVaga(int idVaga);
    }
}
