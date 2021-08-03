using ATSBackend.Domain.Entities;
using ATSBackend.Domain.Interfaces.Services;
using ATSBackend.Domain.Interfaces.Repositories;

namespace ATSBackend.Domain.Services
{
    public class ExperienciaService : ServiceBase<Experiencia>, IExperienciaService
    {
        private readonly IExperienciaRepository _experienciaRepository;
        public ExperienciaService(IExperienciaRepository experienciaRepository) : base(experienciaRepository)
        {
            _experienciaRepository = experienciaRepository;
        }
    }
}
