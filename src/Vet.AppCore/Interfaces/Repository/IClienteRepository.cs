using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity;

namespace Vet.AppCore.Interfaces.Repository
{
    public interface IClienteRepository: IRepository<Cliente>
    {
        IEnumerable<Cliente> ListaPorProfissao(string profissao);
    }
}
