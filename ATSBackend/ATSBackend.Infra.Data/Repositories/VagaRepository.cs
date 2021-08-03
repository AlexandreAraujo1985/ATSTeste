using System.Linq;
using ATSBackend.Domain.Entities;
using ATSBackend.Infra.Data.Contexts;
using ATSBackend.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace ATSBackend.Infra.Data.Repositories
{
    public class VagaRepository : RepositoryBase<Vaga>, IVagaRepository
    {
        public VagaRepository(ATSContext db) : base(db) { }

        public IEnumerable<Vaga> ListarVagasEmAberto() =>
            _db.Vagas.Where(x => x.Encerrada == false).ToList();
    }
}
