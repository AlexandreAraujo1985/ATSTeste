using ATSBackend.Domain.Entities;
using ATSBackend.Application.Interfaces;
using ATSBackend.Domain.Interfaces.Services;

namespace ATSBackend.Application.Services
{
    public class CurriculoApplication : ApplicationBase<Curriculo>, ICurriculoApplication
    {
        private readonly ICurriculoService _curriculoService;
        public CurriculoApplication(ICurriculoService curriculoService) : base(curriculoService)
        {
            _curriculoService = curriculoService;
        }
    }
}
