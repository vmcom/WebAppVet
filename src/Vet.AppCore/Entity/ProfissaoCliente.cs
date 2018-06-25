using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity.Generico;

namespace Vet.AppCore.Entity
{
    public class ProfissaoCliente:EntityGenerico
    {
        public ProfissaoCliente()
        {

        }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int ProfissaoId { get; set; }
        public Profissao Profissao { get; set; }
    }
}
