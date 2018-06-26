using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Vet.AppCore.Entity;
using Vet.AppCore.Interfaces.Repository;
using Vet.AppCore.Interfaces.Services;

namespace Vet.AppCore.Services
{
    public class ContatoService : IService<Contato>, IContatoService
    {
        private readonly IContatoRepository _app;
        public ContatoService(IContatoRepository app)
        {
            _app = app;
        }

        public Contato Adicionar(Contato entity)
        {
            return _app.Adicionar(entity);
        }

        public Contato Atualizar(Contato entity)
        {
            return _app.Atualizar(entity);
        }

        public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> expression)
        {
            return _app.Buscar(expression);
        }

        public Contato Get(int id)
        {
            return _app.Get(id);
        }

        public IEnumerable<Contato> GetAll()
        {
            return _app.GetAll();
        }

        public string Remover(Contato entity)
        {
            return _app.Remover(entity);
        }
    }
}
