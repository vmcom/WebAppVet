using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vet.AppCore.Entity;

namespace Vet.Infraestrura.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ContextBase context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Marcos Valesk O. Belice",
                    Data = DateTime.Now,
                    Cpf = "222.729.108-74"
                },
                new Cliente
                {
                    Nome = "Felipe Santander",
                    Data = DateTime.Now,
                    Cpf = "222.222.222-22"
                }
            };

            context.AddRange(clientes);
            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome="Comercial",
                    Data = DateTime.Now,
                    Cliente = clientes[0],
                    Email = "web.marcos@vmcom.com.br",
                    Telefone = "1121683400"
                },
                new Contato
                {
                    Nome="Comercial",
                    Data = DateTime.Now,
                    Cliente = clientes[1],
                    Email = "web.felipe@vmcom.com.br",
                    Telefone = "1121683400"
                }
            };
            context.AddRange(contatos);
            context.SaveChanges();
        }
    }
}
