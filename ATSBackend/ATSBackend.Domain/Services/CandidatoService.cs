using System.Collections.Generic;
using ATSBackend.Domain.Entities;
using ATSBackend.Domain.Interfaces.Services;
using ATSBackend.Domain.Interfaces.Repositories;

namespace ATSBackend.Domain.Services
{
    public class CandidatoService : ServiceBase<Candidato>, ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;
        public CandidatoService(ICandidatoRepository candidatoRepository) : base(candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        public void AlterarCandidato(Candidato candidato) =>
            _candidatoRepository.AlterarCandidato(candidato);

        public void ExcluirCandidato(int idCandidato)
        {
            var candidatoExclusao = _candidatoRepository.Pesquisar(idCandidato);
            candidatoExclusao.Ativo = false;

            _candidatoRepository.Alterar(candidatoExclusao);
        }

        public void ExcluirExperienciaCandidato(int idExperiencia) =>
            _candidatoRepository.ExcluirExperienciaCandidato(idExperiencia);

        public IEnumerable<Candidato> ListarCandadatosAtivos() =>
            _candidatoRepository.ListarCandadatosAtivos();

        public IEnumerable<Candidato> ListarCandadatosPorVaga(int idVaga) =>
            _candidatoRepository.ListarCandadatosPorVaga(idVaga);

        public Candidato ObterCantidado(int idCadidato) =>
            _candidatoRepository.ObterCantidado(idCadidato);
    }
}
