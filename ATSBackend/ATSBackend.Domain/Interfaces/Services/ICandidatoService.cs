using ATSBackend.Domain.Entities;
using System.Collections.Generic;

namespace ATSBackend.Domain.Interfaces.Services
{
    public interface ICandidatoService : IServiceBase<Candidato>
    {
        Candidato ObterCantidado(int idCadidato);
        void AlterarCandidato(Candidato candidato);
        IEnumerable<Candidato> ListarCandadatosPorVaga(int idVaga);
        IEnumerable<Candidato> ListarCandadatosAtivos();
        void ExcluirCandidato(int idCandidato);
    }
}
