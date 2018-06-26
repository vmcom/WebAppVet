using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Vet.AppCore.Entity;

namespace Vet.AppCore.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity entity);
        TEntity Atualizar(TEntity entity);
        string Remover(TEntity entity);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> expression);
    }
}
