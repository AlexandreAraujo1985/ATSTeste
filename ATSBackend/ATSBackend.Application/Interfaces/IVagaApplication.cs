using ATSBackend.Domain.Entities;
using System.Collections.Generic;

namespace ATSBackend.Application.Interfaces
{
    public interface IVagaApplication : IApplicationBase<Vaga>
    {
        IEnumerable<Vaga> ListarVagasEmAberto();
        void EncerrarVaga(int idVaga);
    }
}
