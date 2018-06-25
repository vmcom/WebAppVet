using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity;
using Vet.AppCore.Interfaces.Repository;
using Vet.Infraestrura.Data;

namespace Vet.Infraestrura.Repository
{
    public class EnderecoRepository : EfRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ContextBase context) : base(context)
        {
        }
    }
}
