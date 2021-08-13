using System.Collections.Generic;
using ATSBackend.Domain.Entities;
using ATSBackend.Application.Interfaces;
using ATSBackend.Domain.Interfaces.Services;

namespace ATSBackend.Application.Services
{
    public class CandidatoApplication : ApplicationBase<Candidato>, ICandidatoApplication
    {
        private readonly ICandidatoService _candidatoService;
        public CandidatoApplication(ICandidatoService candidatoService) : base(candidatoService)
        {
            _candidatoService = candidatoService;
        }

        public void AlterarCandidato(Candidato candidato) =>
            _candidatoService.AlterarCandidato(candidato);

        public void ExcluirCandidato(int idCandidato) =>
            _candidatoService.ExcluirCandidato(idCandidato);

        public void ExcluirExperienciaCandidato(int idExperiencia) =>
            _candidatoService.ExcluirExperienciaCandidato(idExperiencia);

        public IEnumerable<Candidato> ListarCandadatosAtivos() =>
            _candidatoService.ListarCandadatosAtivos();

        public IEnumerable<Candidato> ListarCandadatosPorVaga(int idVaga) =>
            _candidatoService.ListarCandadatosPorVaga(idVaga);

        public Candidato ObterCantidado(int idCadidato) =>
            _candidatoService.ObterCantidado(idCadidato);
    }
}
