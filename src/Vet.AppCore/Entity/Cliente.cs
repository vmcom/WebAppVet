using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity.Generico;

namespace Vet.AppCore.Entity
{
    public class Cliente:EntityGenericoNome
    {
        public string Cpf { get; set; }

        public Cliente()
        {
            Contatos = new HashSet<Contato>();
        }

        public ICollection<Contato> Contatos { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<ProfissaoCliente> Profissoes { get; set; }

    }
}
