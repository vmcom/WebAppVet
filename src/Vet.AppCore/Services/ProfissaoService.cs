using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Vet.AppCore.Entity;
using Vet.AppCore.Interfaces.Repository;
using Vet.AppCore.Interfaces.Services;

namespace Vet.AppCore.Services
{
    public class ProfissaoService : IService<Profissao>, IProfissaoService
    {
        private readonly IProfissaoRepository _app;
        public ProfissaoService(IProfissaoRepository app)
        {
            _app = app;
        }

        public Profissao Adicionar(Profissao entity)
        {
            return _app.Adicionar(entity);
        }

        public Profissao Atualizar(Profissao entity)
        {
            return _app.Atualizar(entity);
        }

        public IEnumerable<Profissao> Buscar(Expression<Func<Profissao, bool>> expression)
        {
            return _app.Buscar(expression);
        }

        public Profissao Get(int id)
        {
            return _app.Get(id);
        }

        public IEnumerable<Profissao> GetAll()
        {
            return _app.GetAll();
        }

        public string Remover(Profissao entity)
        {
            return _app.Remover(entity);
        }
    }
}
