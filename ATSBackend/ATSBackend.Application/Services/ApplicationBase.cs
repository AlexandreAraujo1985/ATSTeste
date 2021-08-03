using System.Collections.Generic;
using ATSBackend.Domain.Interfaces.Services;

namespace ATSBackend.Application.Services
{
    public class ApplicationBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
        public ApplicationBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public TEntity Pesquisar(int id) => _serviceBase.Pesquisar(id);

        public IEnumerable<TEntity> Listar() => _serviceBase.Listar();

        public void Incluir(TEntity obj) => _serviceBase.Incluir(obj);

        public void Alterar(TEntity obj) => _serviceBase.Alterar(obj);

        public void Excluir(int id) => _serviceBase.Excluir(id);
    }
}
