using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Vet.AppCore.Entity;
using Vet.AppCore.Interfaces.Repository;
using Vet.AppCore.Interfaces.Services;

namespace Vet.AppCore.Services
{
    public class ClienteService : IService<Cliente>, IClienteService
    {
        private readonly IClienteRepository _app;
        public ClienteService(IClienteRepository app)
        {
            _app = app;
        }

        public Cliente Adicionar(Cliente entity)
        {
            if (_app.Buscar(x=>x.Cpf == entity.Cpf).Count() != 0)
            {
                return null;
            }
            return _app.Adicionar(entity);
        }

        public Cliente Atualizar(Cliente entity)
        {
            return _app.Atualizar(entity);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> expression)
        {
            return _app.Buscar(expression);
        }

        public Cliente Get(int id)
        {
            return _app.Get(id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _app.GetAll();
        }

        public IEnumerable<Cliente> ListaPorProfissao(string profissao)
        {
            return _app.ListaPorProfissao(profissao);
        }

        public string Remover(Cliente entity)
        {
            return _app.Remover(entity);
        }
    }
}
