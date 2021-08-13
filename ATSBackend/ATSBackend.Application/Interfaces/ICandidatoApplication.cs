using ATSBackend.Domain.Entities;
using System.Collections.Generic;

namespace ATSBackend.Application.Interfaces
{
    public interface ICandidatoApplication : IApplicationBase<Candidato>
    {
        Candidato ObterCantidado(int idCadidato);
        void AlterarCandidato(Candidato candidato);
        IEnumerable<Candidato> ListarCandadatosPorVaga(int idVaga);
        IEnumerable<Candidato> ListarCandadatosAtivos();
        void ExcluirCandidato(int idCandidato);
        void ExcluirExperienciaCandidato(int idExperiencia);
    }
}
