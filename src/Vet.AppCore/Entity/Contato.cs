using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity.Generico;

namespace Vet.AppCore.Entity
{
    public class Contato:EntityGenericoNome
    {
        public Contato()
        {

        }

        public string Telefone { get; set; }
        public string Email { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}
