using ATSBackend.Domain.Entities;
using ATSBackend.Infra.Data.Contexts;
using ATSBackend.Domain.Interfaces.Repositories;

namespace ATSBackend.Infra.Data.Repositories
{
    public class ExperienciaRepository : RepositoryBase<Experiencia>, IExperienciaRepository
    {
        public ExperienciaRepository(ATSContext db) : base(db) { }
    }
}
