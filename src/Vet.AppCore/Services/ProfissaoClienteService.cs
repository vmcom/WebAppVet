using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Vet.AppCore.Entity;
using Vet.AppCore.Interfaces.Repository;
using Vet.AppCore.Interfaces.Services;

namespace Vet.AppCore.Services
{
    public class ProfissaoClienteService : IService<ProfissaoCliente>, IProfissaoClienteService
    {
        private readonly IProfissaoClienteRepository _app;
        public ProfissaoClienteService(IProfissaoClienteRepository app)
        {
            _app = app;
        }

        public ProfissaoCliente Adicionar(ProfissaoCliente entity)
        {
            return _app.Adicionar(entity);
        }

        public ProfissaoCliente Atualizar(ProfissaoCliente entity)
        {
            return _app.Atualizar(entity);
        }

        public IEnumerable<ProfissaoCliente> Buscar(Expression<Func<ProfissaoCliente, bool>> expression)
        {
            return _app.Buscar(expression);
        }

        public ProfissaoCliente Get(int id)
        {
            return _app.Get(id);
        }

        public IEnumerable<ProfissaoCliente> GetAll()
        {
            return _app.GetAll();
        }

        public string Remover(ProfissaoCliente entity)
        {
            return _app.Remover(entity);
        }
    }
}
