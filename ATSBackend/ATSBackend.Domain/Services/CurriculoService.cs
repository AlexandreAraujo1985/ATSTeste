using ATSBackend.Domain.Entities;
using ATSBackend.Domain.Interfaces.Services;
using ATSBackend.Domain.Interfaces.Repositories;

namespace ATSBackend.Domain.Services
{
    public class CurriculoService : ServiceBase<Curriculo>, ICurriculoService
    {
        private readonly ICurriculoRepository _curriculoRepository;
        public CurriculoService(ICurriculoRepository curriculoRepository) : base(curriculoRepository)
        {
            _curriculoRepository = curriculoRepository;
        }
    }
}
