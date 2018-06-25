using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity;

namespace Vet.Infraestrura.EntityConfig
{
    public class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
    {
        public void Configure(EntityTypeBuilder<ProfissaoCliente> builder)
        {
            builder.ToTable("ProfissaoCliente");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.Profissoes)
                .HasForeignKey(x => x.ClienteId);

            builder.HasOne(x => x.Profissao)
                .WithMany(x => x.Profissoes)
                .HasForeignKey(x => x.ProfissaoId);
        }
    }
}
