using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Vet.AppCore.Entity;
using Vet.AppCore.Interfaces.Repository;
using Vet.AppCore.Interfaces.Services;

namespace Vet.AppCore.Services
{
    public class EnderecoService : IService<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _app;
        public EnderecoService(IEnderecoRepository app)
        {
            _app = app;
        }

        public Endereco Adicionar(Endereco entity)
        {
            return _app.Adicionar(entity);
        }

        public Endereco Atualizar(Endereco entity)
        {
            return _app.Atualizar(entity);
        }

        public IEnumerable<Endereco> Buscar(Expression<Func<Endereco, bool>> expression)
        {
            return _app.Buscar(expression);
        }

        public Endereco Get(int id)
        {
            return _app.Get(id);
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _app.GetAll();
        }

        public string Remover(Endereco entity)
        {
            return _app.Remover(entity);
        }
    }
}
