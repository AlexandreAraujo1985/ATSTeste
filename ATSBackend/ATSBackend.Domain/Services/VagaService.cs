using ATSBackend.Domain.Entities;
using ATSBackend.Domain.Interfaces.Services;
using ATSBackend.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace ATSBackend.Domain.Services
{
    public class VagaService : ServiceBase<Vaga>, IVagaService
    {
        private readonly IVagaRepository _vagaRepository;
        public VagaService(IVagaRepository vagaRepository) : base(vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }

        public void EncerrarVaga(int idVaga)
        {
            var vaga = _vagaRepository.Pesquisar(idVaga);
            vaga.Encerrada = true;

            _vagaRepository.Alterar(vaga);
        }

        public IEnumerable<Vaga> ListarVagasEmAberto() =>
            _vagaRepository.ListarVagasEmAberto();
    }
}
