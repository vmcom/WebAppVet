using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity.Generico;

namespace Vet.AppCore.Entity
{
    public class Profissao:EntityGenericoNome
    {
        public Profissao()
        {

        }

        public string Descricao { get; set; }
        public string Crmv { get; set; }
        public ICollection<ProfissaoCliente> Profissoes { get; set; }
    }
}
