using ATSBackend.Domain.Entities;
using ATSBackend.Infra.Data.Contexts;
using ATSBackend.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace ATSBackend.Infra.Data.Repositories
{
    public class CandidatoRepository : RepositoryBase<Candidato>, ICandidatoRepository
    {
        public CandidatoRepository(ATSContext db) : base(db) { }

        public void AlterarCandidato(Candidato candidato)
        {
            _db.Candidatos.Update(candidato);
            _db.Curriculos.Update(candidato.Curriculo);

            foreach (var experiencia in candidato.Curriculo.Experiencias)
            {
                if (experiencia.IdExperiencia == 0)
                    _db.Experiencias.Add(experiencia);
                else
                    _db.Experiencias.Update(experiencia);
            }
            _db.SaveChanges();
        }

        public void ExcluirExperienciaCandidato(int idExperiencia)
        {
            var experienciaCandidato = _db.Experiencias.Find(idExperiencia);
            _db.Experiencias.Remove(experienciaCandidato);

            _db.SaveChanges();
        }

        public IEnumerable<Candidato> ListarCandadatosAtivos() =>
            _db.Candidatos.Where(x => x.Ativo).ToList();

        public IEnumerable<Candidato> ListarCandadatosPorVaga(int idVaga) =>
            _db.Candidatos.Where(x => x.IdVaga == idVaga && x.Ativo).ToList();

        public Candidato ObterCantidado(int idCadidato)
        {
            var candidato = _db.Candidatos.Find(idCadidato);

            _db.Curriculos.Find(candidato.IdCurriculo);
            _db.Experiencias.ToList();

            return candidato;
        }
    }
}
