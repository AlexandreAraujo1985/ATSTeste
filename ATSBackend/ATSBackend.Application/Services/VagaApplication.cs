using ATSBackend.Domain.Entities;
using ATSBackend.Application.Interfaces;
using ATSBackend.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ATSBackend.Application.Services
{
    public class VagaApplication : ApplicationBase<Vaga>, IVagaApplication
    {
        private readonly IVagaService _vagaService;
        public VagaApplication(IVagaService vagaService) : base(vagaService)
        {
            _vagaService = vagaService;
        }

        public void EncerrarVaga(int idVaga) =>
            _vagaService.EncerrarVaga(idVaga);

        public IEnumerable<Vaga> ListarVagasEmAberto() =>
            _vagaService.ListarVagasEmAberto();
    }
}
