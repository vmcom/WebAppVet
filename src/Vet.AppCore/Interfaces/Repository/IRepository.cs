using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Vet.AppCore.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity:class
    {
        TEntity Adicionar(TEntity entity);
        TEntity Atualizar(TEntity entity);
        string Remover(TEntity entity);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll(TEntity entity);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> expression);
    }
}
