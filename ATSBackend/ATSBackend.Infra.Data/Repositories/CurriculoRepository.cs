using ATSBackend.Domain.Entities;
using ATSBackend.Infra.Data.Contexts;
using ATSBackend.Domain.Interfaces.Repositories;

namespace ATSBackend.Infra.Data.Repositories
{
    public class CurriculoRepository : RepositoryBase<Curriculo>, ICurriculoRepository
    {
        public CurriculoRepository(ATSContext db) : base(db) { }
    }
}
