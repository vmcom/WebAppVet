using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity;
using Vet.AppCore.Interfaces.Repository;
using Vet.Infraestrura.Data;

namespace Vet.Infraestrura.Repository
{
    public class ProfissaoClienteRepository : EfRepository<ProfissaoCliente>, IProfissaoClienteRepository
    {
        public ProfissaoClienteRepository(ContextBase context) : base(context)
        {
        }
    }
}
