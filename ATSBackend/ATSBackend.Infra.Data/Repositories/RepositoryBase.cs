using System.Linq;
using System.Collections.Generic;
using ATSBackend.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ATSBackend.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> where TEntity : class
    {
        protected readonly ATSContext _db;

        public RepositoryBase(ATSContext db)
        {
            _db = db;
        }

        public void Alterar(TEntity obj)
        {
            _db.Entry(obj).State = EntityState.Modified;
            _db.Set<TEntity>().Update(obj);
            _db.SaveChanges();
        }

        public void Excluir(int id)
        {
            var obj = Pesquisar(id);
            _db.Set<TEntity>().Remove(obj);
            _db.SaveChanges();
        }

        public void Incluir(TEntity obj)
        {
            _db.Set<TEntity>().Add(obj);
            _db.SaveChanges();
        }

        public IEnumerable<TEntity> Listar() =>
            _db.Set<TEntity>().ToList();

        public TEntity Pesquisar(int id) =>
            _db.Set<TEntity>().Find(id);
    }
}
