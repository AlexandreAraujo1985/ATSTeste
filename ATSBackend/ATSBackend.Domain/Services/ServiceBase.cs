using System.Collections.Generic;
using ATSBackend.Domain.Interfaces.Repositories;

namespace ATSBackend.Domain.Services
{
    public class ServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;
        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public TEntity Pesquisar(int id) => _repositoryBase.Pesquisar(id);

        public IEnumerable<TEntity> Listar() => _repositoryBase.Listar();

        public void Incluir(TEntity obj) => _repositoryBase.Incluir(obj);

        public void Alterar(TEntity obj) => _repositoryBase.Alterar(obj);

        public void Excluir(int id) => _repositoryBase.Excluir(id);
    }
}
