using System.Collections.Generic;

namespace ATSBackend.Application.Interfaces
{
    public interface IApplicationBase<TEntity> where TEntity : class
    {
        TEntity Pesquisar(int id);
        IEnumerable<TEntity> Listar();
        void Incluir(TEntity obj);
        void Alterar(TEntity obj);
        void Excluir(int id);
    }
}
