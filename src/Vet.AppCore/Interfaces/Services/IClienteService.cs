using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity;

namespace Vet.AppCore.Interfaces.Services
{
    public interface IClienteService : IService<Cliente>
    {
        IEnumerable<Cliente> ListaPorProfissao(string profissao);
    }
}
