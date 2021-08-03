using System.Collections.Generic;

namespace ATSBackend.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Pesquisar(int id);
        IEnumerable<TEntity> Listar();
        void Incluir(TEntity obj);
        void Alterar(TEntity obj);
        void Excluir(int id);
    }
}
