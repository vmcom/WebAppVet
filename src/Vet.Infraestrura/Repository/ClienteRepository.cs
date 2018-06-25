using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vet.AppCore.Entity;
using Vet.AppCore.Interfaces.Repository;
using Vet.Infraestrura.Data;

namespace Vet.Infraestrura.Repository
{
    public class ClienteRepository : EfRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ContextBase context) : base(context)
        {

        }

        public IEnumerable<Cliente> ListaPorProfissao(string profissao)
        {
            return Buscar(x => x.Profissoes.Any(a => a.Profissao.Nome == profissao));
        }
    }
}
