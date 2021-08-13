using ATSBackend.Domain.Entities;
using System.Collections.Generic;

namespace ATSBackend.Domain.Interfaces.Repositories
{
    public interface ICandidatoRepository : IRepositoryBase<Candidato>
    {
        Candidato ObterCantidado(int idCadidato);
        void AlterarCandidato(Candidato candidato);
        IEnumerable<Candidato> ListarCandadatosPorVaga(int idVaga);
        IEnumerable<Candidato> ListarCandadatosAtivos();
        void ExcluirExperienciaCandidato(int idExperiencia);
    }
}
