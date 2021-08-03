using ATSBackend.Domain.Entities;
using ATSBackend.Domain.Interfaces.Services;
using ATSBackend.Application.Interfaces;

namespace ATSBackend.Application.Services
{
    public class ExperienciaApplication : ApplicationBase<Experiencia>, IExperienciaApplication
    {
        private readonly IExperienciaService _experienciaService;
        public ExperienciaApplication(IExperienciaService experienciaService) : base(experienciaService)
        {
            _experienciaService = experienciaService;
        }
    }
}
